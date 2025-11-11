using Ashbourne_Gym_Membership_Test.Models;
using Ashbourne_Gym_Membership_Test.Services;
using System.Windows.Forms;
using System.Drawing;

namespace GymMembershipTest
{
    public partial class FrmMembers : Form
    {
        private MockApiService _apiService = new MockApiService();

        public FrmMembers()
        {
            InitializeComponent();
            this.Load += FrmMembers_Load;
            this.btnAdd.Click += btnAdd_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnUndo.Click += btnUndo_Click;
            this.dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
        }

        private async void FrmMembers_Load(object sender, EventArgs e)
        {
            await LoadMembersAsync();
            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
        }

        private async Task LoadMembersAsync()
        {
            try
            {
                GymDataStore.Members = await _apiService.GetMembersAsync();
                GymDataStore.MembershipTypes = await _apiService.GetMembershipTypesAsync();

                membersBindingSource.DataSource = GymDataStore.Members;
                dgvMembers.DataSource = membersBindingSource;

                cmbMembershipType.DataSource = null;
                cmbMembershipType.DataSource = GymDataStore.MembershipTypes;
                cmbMembershipType.DisplayMember = "Name";
                cmbMembershipType.ValueMember = "MembershipTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (membersBindingSource.Current is Member selectedMember)
            {
                txtFirstName.Text = selectedMember.FirstName;
                txtLastName.Text = selectedMember.LastName;
                dtpDateOfBirth.Value = selectedMember.DateOfBirth;
                txtEmail.Text = selectedMember.Email;
                cmbMembershipType.SelectedValue = selectedMember.MembershipType?.MembershipTypeId ?? -1;
            }
        }

        private void RefreshMembersGrid()
        {
            membersBindingSource.ResetBindings(false);
        }

        private bool IsMembershipTypeFull(MembershipType membershipType, int? excludeMemberId = null)
        {
            // Count current members with this membership type
            int currentCount = GymDataStore.Members
                .Count(m => m.MembershipType?.MembershipTypeId == membershipType.MembershipTypeId
                         && (!excludeMemberId.HasValue || m.MemberId != excludeMemberId.Value));

            return currentCount >= membershipType.MaxMembers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMemberInput())
            {
                return;
            }

            MembershipType selectedMembershipType = (MembershipType)cmbMembershipType.SelectedItem;

            // Check if membership type has reached maximum capacity
            if (IsMembershipTypeFull(selectedMembershipType))
            {
                MessageBox.Show($"The '{selectedMembershipType.Name}' membership type has reached its maximum capacity of {selectedMembershipType.MaxMembers} members. Please select a different membership type.",
                    "Membership Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Basic validation for duplicate email
            if (GymDataStore.Members.Any(m => m.Email.Equals(txtEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A member with this email already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Member newMember = new Member
            {
                MemberId = GymDataStore.Members.Any() ? GymDataStore.Members.Max(m => m.MemberId) + 1 : 1,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Value,
                Email = txtEmail.Text.Trim(),
                MembershipType = selectedMembershipType
            };

            SignUp newSignUp = new SignUp
            {
                Member = newMember,
                MembershipType = selectedMembershipType
            };

            membersBindingSource.Add(newMember);
            GymDataStore.SignUps.Add(newSignUp);
            RefreshMembersGrid();
            ClearMemberInput();
            MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (membersBindingSource.Current is not Member selectedMember)
            {
                MessageBox.Show("Please select a member to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateMemberInput())
            {
                return;
            }

            MembershipType selectedMembershipType = (MembershipType)cmbMembershipType.SelectedItem;

            // Check if the membership type is being changed
            bool membershipTypeChanged = selectedMember.MembershipType?.MembershipTypeId != selectedMembershipType.MembershipTypeId;

            // If changing to a different membership type, check if it's full
            if (membershipTypeChanged && IsMembershipTypeFull(selectedMembershipType, selectedMember.MemberId))
            {
                MessageBox.Show($"The '{selectedMembershipType.Name}' membership type has reached its maximum capacity of {selectedMembershipType.MaxMembers} members. Please select a different membership type.",
                    "Membership Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate email, excluding the current member
            if (GymDataStore.Members.Any(m => m.MemberId != selectedMember.MemberId &&
                                            m.Email.Equals(txtEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A member with this email already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedMember.FirstName = txtFirstName.Text.Trim();
            selectedMember.LastName = txtLastName.Text.Trim();
            selectedMember.DateOfBirth = dtpDateOfBirth.Value;
            selectedMember.Email = txtEmail.Text.Trim();
            selectedMember.MembershipType = selectedMembershipType;

            RefreshMembersGrid();
            ClearMemberInput();
            MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (membersBindingSource.Current is not Member selectedMember)
            {
                MessageBox.Show("Please select a member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GymDataStore.LastDeletedMember = selectedMember;
                membersBindingSource.RemoveCurrent();
                RefreshMembersGrid();
                ClearMemberInput();
                MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUndo.Visible = true;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (GymDataStore.LastDeletedMember != null)
            {
                membersBindingSource.Add(GymDataStore.LastDeletedMember);
                GymDataStore.LastDeletedMember = null;
                RefreshMembersGrid();
                btnUndo.Visible = false;
            }
        }

        private bool ValidateMemberInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            int age = DateTime.Today.Year - dtpDateOfBirth.Value.Year;
            if (dtpDateOfBirth.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age < 16 || age > 100)
            {
                MessageBox.Show("Date of Birth must result in an age between 16 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirth.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("A valid Email address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (cmbMembershipType.SelectedItem == null)
            {
                MessageBox.Show("Membership Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMembershipType.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ClearMemberInput()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Today;
            txtEmail.Clear();
            cmbMembershipType.SelectedIndex = -1;
            dgvMembers.ClearSelection();
        }
    }
}