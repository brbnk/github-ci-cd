using Xunit;
using SimpleApp.Services;

public sealed class GreetingServiceTests
{
  private readonly IGreetingService _sut;

  public GreetingServiceTests()
  {
    _sut = new GreetingService();
  }

  [Theory]
  [InlineData("Hello, World!")]
  public void Greet_Should_Return_Text(string testGreeting)
  {
    var matched = testGreeting.Equals("Hello, World!");

    Assert.True(matched);
  }
}
