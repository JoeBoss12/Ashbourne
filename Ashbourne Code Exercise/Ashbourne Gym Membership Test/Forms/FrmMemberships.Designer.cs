namespace GymMembershipTest
{
    partial class FrmMemberships
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
            this.dgvMembershipTypes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.numMonthlyFee = new System.Windows.Forms.NumericUpDown();
            this.lblInitialFee = new System.Windows.Forms.Label();
            this.numInitialFee = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMembers = new System.Windows.Forms.Label();
            this.numMaxMembers = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipTypes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembershipTypes
            // 
            this.dgvMembershipTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembershipTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMembershipTypes.Location = new System.Drawing.Point(0, 0);
            this.dgvMembershipTypes.Name = "dgvMembershipTypes";
            this.dgvMembershipTypes.RowHeadersWidth = 51;
            this.dgvMembershipTypes.Size = new System.Drawing.Size(800, 250);
            this.dgvMembershipTypes.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMonthlyFee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numMonthlyFee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInitialFee, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numInitialFee, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMaxMembers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numMaxMembers, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 120);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(128, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(369, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthlyFee.Location = new System.Drawing.Point(3, 30);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(119, 30);
            this.lblMonthlyFee.TabIndex = 2;
            this.lblMonthlyFee.Text = "Monthly Fee:";
            this.lblMonthlyFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMonthlyFee
            // 
            this.numMonthlyFee.DecimalPlaces = 2;
            this.numMonthlyFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMonthlyFee.Location = new System.Drawing.Point(128, 33);
            this.numMonthlyFee.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numMonthlyFee.Name = "numMonthlyFee";
            this.numMonthlyFee.Size = new System.Drawing.Size(369, 27);
            this.numMonthlyFee.TabIndex = 3;
            // 
            // lblInitialFee
            // 
            this.lblInitialFee.AutoSize = true;
            this.lblInitialFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInitialFee.Location = new System.Drawing.Point(3, 60);
            this.lblInitialFee.Name = "lblInitialFee";
            this.lblInitialFee.Size = new System.Drawing.Size(119, 30);
            this.lblInitialFee.TabIndex = 4;
            this.lblInitialFee.Text = "Initial Fee:";
            this.lblInitialFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numInitialFee
            // 
            this.numInitialFee.DecimalPlaces = 2;
            this.numInitialFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numInitialFee.Location = new System.Drawing.Point(128, 63);
            this.numInitialFee.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numInitialFee.Name = "numInitialFee";
            this.numInitialFee.Size = new System.Drawing.Size(369, 27);
            this.numInitialFee.TabIndex = 5;
            // 
            // lblMaxMembers
            // 
            this.lblMaxMembers.AutoSize = true;
            this.lblMaxMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxMembers.Location = new System.Drawing.Point(3, 90);
            this.lblMaxMembers.Name = "lblMaxMembers";
            this.lblMaxMembers.Size = new System.Drawing.Size(119, 30);
            this.lblMaxMembers.TabIndex = 6;
            this.lblMaxMembers.Text = "Max Members:";
            this.lblMaxMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMaxMembers
            // 
            this.numMaxMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMaxMembers.Location = new System.Drawing.Point(128, 93);
            this.numMaxMembers.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numMaxMembers.Name = "numMaxMembers";
            this.numMaxMembers.Size = new System.Drawing.Size(369, 27);
            this.numMaxMembers.TabIndex = 7;
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
            // FrmMemberships
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvMembershipTypes);
            this.Name = "FrmMemberships";
            this.Text = "Memberships";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipTypes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembershipTypes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.NumericUpDown numMonthlyFee;
        private System.Windows.Forms.Label lblInitialFee;
        private System.Windows.Forms.NumericUpDown numInitialFee;
        private System.Windows.Forms.Label lblMaxMembers;
        private System.Windows.Forms.NumericUpDown numMaxMembers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
