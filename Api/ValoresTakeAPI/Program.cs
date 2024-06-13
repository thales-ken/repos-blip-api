using Application.Services;
using Domain.Interfaces;
using Domain.Settings;
using Infrastructure.Api;
using RestEase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(RestClient.For<IGithubClient>("https://api.github.com"));
builder.Services.AddScoped<IGithubService, GithubService>();
var settings = builder.Configuration.GetSection("Settings").Get<CustomSettings>();
#pragma warning disable CS8634 // O tipo não pode ser usado como parâmetro de tipo no tipo ou método genérico. A anulabilidade do argumento de tipo não corresponde à restrição 'class'.
builder.Services.AddSingleton(settings);
#pragma warning restore CS8634 // O tipo não pode ser usado como parâmetro de tipo no tipo ou método genérico. A anulabilidade do argumento de tipo não corresponde à restrição 'class'.

var app = builder.Build();

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
