using Ashbourne_Gym_Membership_Test.Models;

namespace Ashbourne_Gym_Membership_Test.Services
{
    public static class GymDataStore
    {
        public static List<Member> Members = new List<Member>();
        public static List<MembershipType> MembershipTypes = new List<MembershipType>();
        public static List<SignUp> SignUps = new List<SignUp>();
    }
}
