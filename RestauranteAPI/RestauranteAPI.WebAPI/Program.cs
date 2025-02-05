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

builder.Services.AddControllers();

//Habilita o acesso aos endpoints no Swagger
builder.Services.AddEndpointsApiExplorer();

// Adiciona suporte ao Swagger para documentação da API
builder.Services.AddSwaggerGen();

// Configuração do OData para permitir filtros, ordenação, paginação, etc.
builder.Services.ODataConfiguration();

// Constrói a aplicação com as configurações definidas
var app = builder.Build();

CreateDatabase(app);


// Configure the HTTP Command pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redireciona requisições HTTP para HTTPS
app.UseHttpsRedirection();

// Mapeia os controladores para as rotas definidas
app.MapControllers();

app.Run();

// Cria o banco de dados caso ele ainda não exista.
void CreateDatabase(WebApplication app)
{
    // Cria um escopo de serviço para acessar os serviços da aplicação
    var serviceScope = app.Services.CreateScope();

    // Obtém o contexto do banco de dados
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();

    //Verifica se o Banco de Dados foi criado
    dataContext?.Database.EnsureCreated();

    // Carga no banco de dados, não necessária no caso deste crud
    //var sqlFile = "./Scripts/inserts.sql";

    //Usado no Conecta, porém não é necessário neste crud básico
    //var sql = File.ReadAllText(sqlFile);
    //dataContext?.Database.ExecuteSqlRaw(sql);
}
