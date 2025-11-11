namespace GymMembershipTest
{
    partial class FrmMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMembers = new System.Windows.Forms.TabPage();
            this.tabPageMembershipTypes = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMembers);
            this.tabControlMain.Controls.Add(this.tabPageMembershipTypes);
            this.tabControlMain.Controls.Add(this.tabPageReports);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMembers
            // 
            this.tabPageMembers.Location = new System.Drawing.Point(4, 29);
            this.tabPageMembers.Name = "tabPageMembers";
            this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembers.Size = new System.Drawing.Size(792, 417);
            this.tabPageMembers.TabIndex = 0;
            this.tabPageMembers.Text = "Members";
            this.tabPageMembers.UseVisualStyleBackColor = true;
            // 
            // tabPageMembershipTypes
            // 
            this.tabPageMembershipTypes.Location = new System.Drawing.Point(4, 29);
            this.tabPageMembershipTypes.Name = "tabPageMembershipTypes";
            this.tabPageMembershipTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembershipTypes.Size = new System.Drawing.Size(792, 417);
            this.tabPageMembershipTypes.TabIndex = 1;
            this.tabPageMembershipTypes.Text = "Membership Types";
            this.tabPageMembershipTypes.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Location = new System.Drawing.Point(4, 29);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(792, 417);
            this.tabPageReports.TabIndex = 2;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FrmMain";
            this.Text = "Gym Membership Management";
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMembers;
        private System.Windows.Forms.TabPage tabPageMembershipTypes;
        private System.Windows.Forms.TabPage tabPageReports;
    }
}
