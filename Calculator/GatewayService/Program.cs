var builder = WebApplication.CreateBuilder(args);
var address = builder.Configuration.GetValue<string>("CalculatorServiceAdress");

builder.Services.AddGrpcClient<Calculator.GRPCService.GRPCServiceClient>(address, options => { options.Address = new Uri(address); });
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
