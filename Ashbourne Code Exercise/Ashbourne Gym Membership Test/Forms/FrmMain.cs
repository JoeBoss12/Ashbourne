using GymMembershipTest;

namespace GymMembershipTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            LoadFormIntoTabPage(new FrmMembers(), tabPageMembers);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageMembers && !tabPageMembers.Controls.OfType<FrmMembers>().Any())
            {
                LoadFormIntoTabPage(new FrmMembers(), tabPageMembers);
            }
            else if (tabControlMain.SelectedTab == tabPageMembershipTypes && !tabPageMembershipTypes.Controls.OfType<FrmMemberships>().Any())
            {
                LoadFormIntoTabPage(new FrmMemberships(), tabPageMembershipTypes);
            }
            else if (tabControlMain.SelectedTab == tabPageReports && !tabPageReports.Controls.OfType<ReportForm>().Any())
            {
                LoadFormIntoTabPage(new ReportForm(), tabPageReports);
            }
        }

        private void LoadFormIntoTabPage(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
            form.Show();
        }
    }
}
