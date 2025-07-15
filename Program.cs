using MinhaAplicacao.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar o serviço para conexão com o banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 41)) // Substitua pela versão do seu MySQL
    ));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();