using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StockWebAPI.Data;
using AutoMapper; // Ensure AutoMapper namespace is included  

var builder = WebApplication.CreateBuilder(args);

// Area de Services  

builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(Program).Assembly)); // Fix for CS1503  

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name=DefaultConnection"));

builder.Services.AddSwaggerGen();

// Fin de Area de Services  

var app = builder.Build();

//Area de Middlewares  

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
