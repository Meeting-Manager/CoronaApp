using CoronaApp;
using CoronaApp.Dal;
using CoronaApp.Services;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPatientBusinessLogic, PatientBusinessLogic>();
builder.Services.AddScoped<IPatientDataAccess, PatientDataAccess>();
builder.Services.AddScoped<ILocationBusinessLogic, LocationBusinessLogic>();
builder.Services.AddScoped<ILocationDataAccess, LocationDataAccess>();
builder.Services.AddSingleton<IDB, DB>();


var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);


var app = builder.Build();
app.UseLoggerMiddleware();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
public partial class Program { }
