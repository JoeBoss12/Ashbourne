using Ashbourne_Gym_Membership_Test.Models;
using Ashbourne_Gym_Membership_Test.Services;

namespace GymMembershipTest
{
    public partial class FrmMemberships : Form
    {
        public FrmMemberships()
        {
            InitializeComponent();
            this.Load += FrmMemberships_Load;
            this.btnAdd.Click += btnAdd_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnDelete.Click += btnDelete_Click;
        }

        private async void FrmMemberships_Load(object sender, EventArgs e)
        {
            await LoadMembershipTypesAsync();
            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            dgvMembershipTypes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMembershipTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembershipTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembershipTypes.MultiSelect = false;
        }

        private async Task LoadMembershipTypesAsync()
        {
            try
            {
                // Ensure GymDataStore.MembershipTypes is populated from MockApiService
                if (!GymDataStore.MembershipTypes.Any())
                {
                    MockApiService apiService = new MockApiService();
                    GymDataStore.MembershipTypes = await apiService.GetMembershipTypesAsync();
                }
                membershipTypesBindingSource.DataSource = GymDataStore.MembershipTypes;
                dgvMembershipTypes.DataSource = membershipTypesBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading membership types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMembershipTypeInput())
            {
                return;
            }

            MembershipType newMembershipType = new MembershipType
            {
                MembershipTypeId = GymDataStore.MembershipTypes.Any() ? GymDataStore.MembershipTypes.Max(mt => mt.MembershipTypeId) + 1 : 1,
                Name = txtName.Text,
                MonthlyFee = numMonthlyFee.Value,
                InitialFee = numInitialFee.Value,
                MaxMembers = (int)numMaxMembers.Value
            };

            if (GymDataStore.MembershipTypes.Any(mt => mt.Name.Equals(newMembershipType.Name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A membership type with this name already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            membershipTypesBindingSource.Add(newMembershipType);
            ClearMembershipTypeInput();
        }
        private void dgvMembershipTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (membershipTypesBindingSource.Current is MembershipType selectedMembershipType)
            {
                txtName.Text = selectedMembershipType.Name;
                numMonthlyFee.Value = selectedMembershipType.MonthlyFee;
                numInitialFee.Value = selectedMembershipType.InitialFee;
                numMaxMembers.Value = selectedMembershipType.MaxMembers;
            }
            else
            {
                ClearMembershipInput();
            }
        }

        private void ClearMembershipInput()
        {
            txtName.Clear();
            numMonthlyFee.Value = 0;
            numInitialFee.Value = 0;
            numMaxMembers.Value = 0;
            dgvMembershipTypes.ClearSelection();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (membershipTypesBindingSource.Current is not MembershipType selectedMembershipType)
            {
                MessageBox.Show("Please select a membership type to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateMembershipTypeInput())
            {
                return;
            }

            if (GymDataStore.MembershipTypes.Any(mt => mt.MembershipTypeId != selectedMembershipType.MembershipTypeId && mt.Name.Equals(txtName.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A membership type with this name already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enforce MaxMembers rule: cannot set MaxMembers less than current sign-ups
            int currentSignUps = GymDataStore.SignUps.Count(s => s.MembershipType.MembershipTypeId == selectedMembershipType.MembershipTypeId);
            if (numMaxMembers.Value < currentSignUps)
            {
                MessageBox.Show($"Cannot set Max Members to {numMaxMembers.Value} as there are currently {currentSignUps} members signed up for this type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedMembershipType.Name = txtName.Text;
            selectedMembershipType.MonthlyFee = numMonthlyFee.Value;
            selectedMembershipType.InitialFee = numInitialFee.Value;
            selectedMembershipType.MaxMembers = (int)numMaxMembers.Value;

            membershipTypesBindingSource.ResetBindings(false);
            ClearMembershipTypeInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (membershipTypesBindingSource.Current is not MembershipType selectedMembershipType)
            {
                MessageBox.Show("Please select a membership type to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Prevent deletion if there are members signed up for this membership type
            if (GymDataStore.SignUps.Any(s => s.MembershipType.MembershipTypeId == selectedMembershipType.MembershipTypeId))
            {
                MessageBox.Show("Cannot delete membership type as there are members signed up for it.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this membership type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                membershipTypesBindingSource.RemoveCurrent();
                ClearMembershipTypeInput();
            }
        }

        private bool ValidateMembershipTypeInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Membership Type Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numMonthlyFee.Value <= 0)
            {
                MessageBox.Show("Monthly Fee must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numInitialFee.Value < 0)
            {
                MessageBox.Show("Initial Fee cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numMaxMembers.Value <= 0)
            {
                MessageBox.Show("Max Members must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearMembershipTypeInput()
        {
            txtName.Clear();
            numMonthlyFee.Value = 0;
            numInitialFee.Value = 0;
            numMaxMembers.Value = 0;
        }
    }
}
