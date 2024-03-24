using SimpleApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IGreetingService, GreetingService>();

var app = builder.Build();

app.MapGet("/", (IGreetingService service) => service.Greet("Updated Hello, World!"));

app.Run();
