namespace Ashbourne_Gym_Membership_Test.Models
{
    public class MembershipType
    {
        public int MembershipTypeId { get; set; }
        public string Name { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal InitialFee { get; set; }
        public int MaxMembers { get; set; }
    }
}
