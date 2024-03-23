using SimpleApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IGreetingService, GreetingService>();

var app = builder.Build();

app.MapGet("/", (IGreetingService service) => service.Greet("Hello, World!"));

app.Run();
