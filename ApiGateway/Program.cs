using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("ocelot.json")
    .AddEnvironmentVariables();

builder.Services.AddOcelot();

var app = builder.Build();
app.UseAuthentication();

await app.UseOcelot();
app.Run();
