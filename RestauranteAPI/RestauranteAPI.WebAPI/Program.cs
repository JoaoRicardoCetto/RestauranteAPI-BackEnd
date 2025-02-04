using RestauranteAPI.Application.Services;
using RestauranteAPI.Infrastructure;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o services no container
//Configuração do Banco de Dados (Camada de Infra)
builder.Services.ConfigurePersistenceApp(builder.Configuration);

//Configuração da Application
builder.Services.ConfigureApplicationApp();

builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ODataConfiguration();

#region Adição do Serilog
//Log.Logger = new LoggerConfiguration()
//            .MinimumLevel.Debug()
//            .WriteTo.Console()
//            .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
//            .CreateLogger();
//builder.Host.UseSerilog(Log.Logger);
#endregion

var app = builder.Build();

CreateDatabase(app);

//app.MapDefaultEndpoints();

// Configure the HTTP Command pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();

    // Carga no banco de dados, não necessária no caso deste crud
    //var sqlFile = "./Scripts/inserts.sql";

    //Usado no Conecta, porém não é necessário neste crud básico
    //var sql = File.ReadAllText(sqlFile);
    //dataContext?.Database.ExecuteSqlRaw(sql);
}
