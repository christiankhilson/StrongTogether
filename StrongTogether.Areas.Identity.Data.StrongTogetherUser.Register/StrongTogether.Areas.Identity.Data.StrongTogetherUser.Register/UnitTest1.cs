using Xunit;
using StrongTogether.Areas.Identity.Data.StrongTogetherUser;
using StrongerTogether;

namespace StrongTogether.Areas.Identity.Data.StrongTogetherUser.Register;

public class UnitTest1
{
    [Fact]
    // Test user creation
    public void Test1()
    {
        StrongTogetherUser user = new StrongTogetherUser(1, "Panda", "Panda", 1, 5, 5, 105, "Get fit");
        Assert.NotNull(user);
    }

    [Fact]
    // Test fitness goal creation
    public void Test2()
    {
        FitnessGoal goal = new FitnessGoal("Get fit")
        Assert.NotNull(goal);
    }

    [Theory]
    [InlineData("Get fit", "Get fit")]
    [InlineData("Muscular endurance", "Muscular endurance")]
    [InlineData("Heart health", "Heart health")]
    [InlineData("Muscle building", "Muscle building")]
    // Test the fitness goals
    public void Test3(string input, string expectedOutput)
    {
        Assert.AreEqual(input, expectedOutput);
    }

    [Theory]
    [InlineData("Wonderwoman", "Wonderwoman")]
    [InlineData("Ace Ventura", "Ace Ventura")]
    [InlineData("Harry Potter", "Harry Potter")]
    [InlineData("Fluffy Panda", "Fluffy Panda")]
    // Test the user names
    public void Test4(string input, string expectedOutput)
    {
        Assert.AreEqual(input, expectedOutput);
    }
}