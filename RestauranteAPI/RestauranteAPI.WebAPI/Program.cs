using RestauranteAPI.Application.Services;
using RestauranteAPI.Infrastructure;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.AddServiceDefaults();
// Add services to the container.
builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

/*PERGUNTAR O PQ DO ERRO AO VINICIUS OU BRUNO
Quando eu comento o que dá erro nessas linhas, o código roda e abre o swagger normal,
porém eu acho q o banco não funciona corretamente */
void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
    dataContext?.Database.Migrate();

    // Carga no banco de dados
    var sqlFile = "./Scripts/inserts.sql";
    var sql = File.ReadAllText(sqlFile);
    dataContext?.Database.ExecuteSqlRaw(sql);
}
