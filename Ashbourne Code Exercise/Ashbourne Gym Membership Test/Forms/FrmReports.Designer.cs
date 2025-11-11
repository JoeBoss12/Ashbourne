namespace GymMembershipTest
{
    partial class ReportForm
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
            this.rtbReports = new System.Windows.Forms.RichTextBox();
            this.btnMembersAge30 = new System.Windows.Forms.Button();
            this.btnMembershipTypeSignups = new System.Windows.Forms.Button();
            this.btnMembersWithMembershipTypes = new System.Windows.Forms.Button();
            this.btnCountMembersPerMembershipType = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();  // ADD THIS LINE

            this.SuspendLayout();
            // 
            // rtbReports
            // 
            this.rtbReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbReports.Location = new System.Drawing.Point(0, 0);
            this.rtbReports.Name = "rtbReports";
            this.rtbReports.Size = new System.Drawing.Size(800, 300);
            this.rtbReports.TabIndex = 0;
            this.rtbReports.Text = "";
            // 
            // btnMembersAge30
            // 
            this.btnMembersAge30.Location = new System.Drawing.Point(12, 315);
            this.btnMembersAge30.Name = "btnMembersAge30";
            this.btnMembersAge30.Size = new System.Drawing.Size(200, 29);
            this.btnMembersAge30.TabIndex = 1;
            this.btnMembersAge30.Text = "Members Age > 30";
            this.btnMembersAge30.UseVisualStyleBackColor = true;
            // 
            // btnMembershipTypeSignups
            // 
            this.btnMembershipTypeSignups.Location = new System.Drawing.Point(218, 315);
            this.btnMembershipTypeSignups.Name = "btnMembershipTypeSignups";
            this.btnMembershipTypeSignups.Size = new System.Drawing.Size(200, 29);
            this.btnMembershipTypeSignups.TabIndex = 2;
            this.btnMembershipTypeSignups.Text = "Membership Type Sign-ups";
            this.btnMembershipTypeSignups.UseVisualStyleBackColor = true;
            // 
            // btnMembersWithMembershipTypes
            // 
            this.btnMembersWithMembershipTypes.Location = new System.Drawing.Point(12, 350);
            this.btnMembersWithMembershipTypes.Name = "btnMembersWithMembershipTypes";
            this.btnMembersWithMembershipTypes.Size = new System.Drawing.Size(200, 29);
            this.btnMembersWithMembershipTypes.TabIndex = 3;
            this.btnMembersWithMembershipTypes.Text = "Members with Membership Types";
            this.btnMembersWithMembershipTypes.UseVisualStyleBackColor = true;
            // 
            // btnCountMembersPerMembershipType
            // 
            this.btnCountMembersPerMembershipType.Location = new System.Drawing.Point(218, 350);
            this.btnCountMembersPerMembershipType.Name = "btnCountMembersPerMembershipType";
            this.btnCountMembersPerMembershipType.Size = new System.Drawing.Size(200, 29);
            this.btnCountMembersPerMembershipType.TabIndex = 4;
            this.btnCountMembersPerMembershipType.Text = "Count Members per Membership Type";
            this.btnCountMembersPerMembershipType.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(424, 315);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 29);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Report";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCountMembersPerMembershipType);
            this.Controls.Add(this.btnMembersWithMembershipTypes);
            this.Controls.Add(this.btnMembershipTypeSignups);
            this.Controls.Add(this.btnMembersAge30);
            this.Controls.Add(this.rtbReports);
            this.Name = "ReportForm";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReports;
        private System.Windows.Forms.Button btnMembersAge30;
        private System.Windows.Forms.Button btnMembershipTypeSignups;
        private System.Windows.Forms.Button btnMembersWithMembershipTypes;
        private System.Windows.Forms.Button btnCountMembersPerMembershipType;
        private System.Windows.Forms.Button btnExport;
    }
}
