namespace Ashbourne_Gym_Membership_Test.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}
