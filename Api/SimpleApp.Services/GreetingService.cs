namespace SimpleApp.Services;

public sealed class GreetingService : IGreetingService
{
  public string Greet(string greeting) 
  {
    return greeting;
  }
}
