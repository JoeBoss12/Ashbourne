using System.Drawing;

namespace GymMembershipTest
{
    partial class FrmMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();  
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.membersBindingSource = new System.Windows.Forms.BindingSource();  // ADD THIS LINE

            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();  // ADD THIS

            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMembers.Location = new System.Drawing.Point(0, 0);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.Size = new System.Drawing.Size(800, 250);
            this.dgvMembers.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDateOfBirth, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateOfBirth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMembershipType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbMembershipType, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Location = new System.Drawing.Point(3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(119, 30);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(128, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(369, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(3, 30);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 30);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(128, 33);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(369, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateOfBirth.Location = new System.Drawing.Point(3, 60);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(119, 30);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date of Birth:";
            this.lblDateOfBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(128, 63);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(369, 27);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(3, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 30);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(128, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMembershipType.Location = new System.Drawing.Point(3, 120);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(119, 30);
            this.lblMembershipType.TabIndex = 8;
            this.lblMembershipType.Text = "Membership Type:";
            this.lblMembershipType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbMembershipType
            // 
            this.cmbMembershipType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Location = new System.Drawing.Point(128, 123);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(369, 28);
            this.cmbMembershipType.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(550, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(550, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(550, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(550, 380);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(94, 29);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataSource = typeof(Ashbourne_Gym_Membership_Test.Models.Member);
            // 
            // FrmMembers
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvMembers);
            this.Name = "FrmMembers";
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.ComboBox cmbMembershipType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.BindingSource membersBindingSource;
    }
}