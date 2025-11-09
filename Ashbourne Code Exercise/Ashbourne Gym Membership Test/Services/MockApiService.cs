using Ashbourne_Gym_Membership_Test.Models;
using System.Text.Json;

namespace Ashbourne_Gym_Membership_Test.Services
{
    // This class simulates API calls using embedded JSON.
    // You may extend this to simulate POST/PUT operations or error handling if needed.
    public class MockApiService
    {
        private string memberJson = @"[
            {""MemberId"": 1, ""FirstName"": ""Alice"", ""LastName"": ""Smith"", ""Email"": ""alice@example.com"", ""DateOfBirth"": ""1990-05-01""},
            {""MemberId"": 2, ""FirstName"": ""Bob"", ""LastName"": ""Jones"", ""Email"": ""bob@example.com"", ""DateOfBirth"": ""1985-08-15""}
        ]";


        private string membershipJson = @"[
            {""MembershipTypeId"": 1, ""Name"": ""Standard"", ""MonthlyFee"": 30.0, ""InitialFee"": 50.0, ""MaxMembers"": 1},
            {""MembershipTypeId"": 2, ""Name"": ""Premium"", ""MonthlyFee"": 50.0, ""InitialFee"": 75.0, ""MaxMembers"": 5}
        ]";

        public async Task<List<Member>> GetMembersAsync()
        {
            await Task.Delay(300);
            return JsonSerializer.Deserialize<List<Member>>(memberJson);
        }

        public async Task<List<MembershipType>> GetMembershipTypesAsync()
        {
            await Task.Delay(300);
            return JsonSerializer.Deserialize<List<MembershipType>>(membershipJson);
        }
    }
}
