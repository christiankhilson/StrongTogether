using StrongTogether.Areas.Identity.Data;
using StrongTogether.Models;
using Xunit;

namespace StrongTogetherTest
{
    public class UnitTest1
    {
        [Fact]
        // Test user creation
        public void Test1()
        {
            //1, "Panda", "Panda", 1, 5, 5, 105, "Get fit"
            StrongTogetherUser user = new StrongTogetherUser();
            user.FirstName = "Fluffiest";
            user.LastName = "Panda";
            user.Gender = true;
            user.FootHeight = 5;
            user.InchHeight = 5;
            user.Weight = 105;
            user.FitnessId = 1;

            Assert.Equal("Fluffiest", user.FirstName);
        }

        [Fact]
        // Test fitness goal creation
        public void Test2()
        {
            FitnessGoal goal = new FitnessGoal();
            goal.FitnessDescription = "Get fit";

            Assert.Equal("Get fit", goal.FitnessDescription);
        }

        [Theory]
        [InlineData("Get fit", "Get fit")]
        [InlineData("Muscular endurance", "Muscular endurance")]
        [InlineData("Heart health", "Heart health")]
        [InlineData("Muscle building", "Muscle building")]
        // Test the fitness goals
        public void Test3(string input, string expectedOutput)
        {
            Assert.Equal(input, expectedOutput);
        }

        [Theory]
        [InlineData("Wonderwoman", "Wonderwoman")]
        [InlineData("Ace Ventura", "Ace Ventura")]
        [InlineData("Harry Potter", "Harry Potter")]
        [InlineData("Fluffy Panda", "Fluffy Panda")]
        // Test the user names
        public void Test4(string input, string expectedOutput)
        {
            Assert.Equal(input, expectedOutput);
        }
    }
}