using Ashbourne_Gym_Membership_Test.Models;
using Ashbourne_Gym_Membership_Test.Services;
using System.Text;

namespace GymMembershipTest
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            this.btnMembersAge30.Click += btnMembersAge30_Click;
            this.btnMembershipTypeSignups.Click += btnMembershipTypeSignups_Click;
            this.btnMembersWithMembershipTypes.Click += btnMembersWithMembershipTypes_Click;
            this.btnCountMembersPerMembershipType.Click += btnCountMembersPerMembershipType_Click;
        }

        private void DisplayReport(string title, string content)
        {
            rtbReports.Clear();
            rtbReports.AppendText($"==== {title} ====\n\n");
            rtbReports.AppendText(content);
        }

        private void btnMembersAge30_Click(object sender, EventArgs e)
        {
            var membersOver30 = GymDataStore.Members
                .Where(m => (DateTime.Today.Year - m.DateOfBirth.Year) > 30)
                .OrderBy(m => m.LastName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var member in membersOver30)
            {
                sb.AppendLine($"ID: {member.MemberId}, Name: {member.FirstName} {member.LastName}, Age: {(DateTime.Today.Year - member.DateOfBirth.Year)}");
            }

            DisplayReport("Members Age > 30", sb.ToString());
        }

        private void btnMembershipTypeSignups_Click(object sender, EventArgs e)
        {
            var membershipTypeSignups = GymDataStore.SignUps
                .Where(s => s.MembershipType != null)  // Add null check
                .GroupBy(s => s.MembershipType.Name)
                .Select(g => new { MembershipType = g.Key, Count = g.Count() })
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var signup in membershipTypeSignups)
            {
                sb.AppendLine($"Membership Type: {signup.MembershipType}, Sign-ups: {signup.Count}");
            }

            DisplayReport("Membership Type Sign-ups", sb.ToString());
        }

        private void btnMembersWithMembershipTypes_Click(object sender, EventArgs e)
        {
            var membersWithTypes = from member in GymDataStore.Members
                                   where member.MembershipType != null  // Add null check
                                   join membershipType in GymDataStore.MembershipTypes
                                   on member.MembershipType.MembershipTypeId equals membershipType.MembershipTypeId
                                   select new
                                   {
                                       MemberName = $"{member.FirstName} {member.LastName}",
                                       member.Email,
                                       MembershipTypeName = membershipType.Name
                                   };

            StringBuilder sb = new StringBuilder();
            foreach (var item in membersWithTypes)
            {
                sb.AppendLine($"Name: {item.MemberName}, Email: {item.Email}, Membership: {item.MembershipTypeName}");
            }

            DisplayReport("Members with Membership Types", sb.ToString());
        }

        private void btnCountMembersPerMembershipType_Click(object sender, EventArgs e)
        {
            var countMembers = GymDataStore.Members
                .GroupBy(m => m.MembershipType?.Name ?? "Unassigned")
                .Select(g => new { MembershipType = g.Key, Count = g.Count() })
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var item in countMembers)
            {
                sb.AppendLine($"Membership Type: {item.MembershipType}, Member Count: {item.Count}");
            }

            DisplayReport("Count Members per Membership Type", sb.ToString());
        }
    }
}