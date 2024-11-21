using CalculatorService.Services;
using System.Data;
using Npgsql;
using CalculatorService.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddGrpc();
builder.Services.AddTransient<CalculatorC>();
builder.Services.AddScoped<IDbConnection>(_ =>
{
    return new NpgsqlConnection(connectionString);
});

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
}

app.MapGrpcService<CalculatorGRPCService>();

app.Run();
