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
#pragma warning disable CS8634 // O tipo n�o pode ser usado como par�metro de tipo no tipo ou m�todo gen�rico. A anulabilidade do argumento de tipo n�o corresponde � restri��o 'class'.
builder.Services.AddSingleton(settings);
#pragma warning restore CS8634 // O tipo n�o pode ser usado como par�metro de tipo no tipo ou m�todo gen�rico. A anulabilidade do argumento de tipo n�o corresponde � restri��o 'class'.

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
