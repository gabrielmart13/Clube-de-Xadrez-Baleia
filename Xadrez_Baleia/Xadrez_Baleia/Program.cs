
using Microsoft.EntityFrameworkCore;
using System.Text;
using XadrezBaleia.Application.Interfaces;
using XadrezBaleia.Application.Services;
using XadrezBaleia.Infraestructure.Repositories;
using XadrezBaleia.Infraestructure.Repositories.Interfaces;
using XadrezBaleia.Infrastructure;
using XadrezBaleia.Infrastructure.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// 1. Controllers e Swagger

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// 2. Banco de dados

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySQL(
            builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string não encontrada")
        )
);


// 3. Repositories

builder.Services.AddScoped<IGeralRepo, GeralRepo>();
builder.Services.AddScoped<IClassesRepo, ClassesRepo>();
builder.Services.AddScoped<IRatingRepo, RatingRepo>();
builder.Services.AddScoped<IPartidasRepo, PartidasRepo>();
builder.Services.AddScoped<IEventRepo, EventRepo>();


// 4. Services

builder.Services.AddScoped<ITurmasService, TurmasService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IPartidasService, PartidasService>();
builder.Services.AddScoped<IEventosService, EventosService>();
builder.Services.AddScoped<IUsuariosService, UsuariosService>();
builder.Services.AddScoped<IAutenticationService, AutenticationService>();
builder.Services.AddScoped<IAdministradoresService, AdministradoresService>();



// 5. Construção da aplicação

var app = builder.Build();


// 6. Pipeline HTTP

if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
