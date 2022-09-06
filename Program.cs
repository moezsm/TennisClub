using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TennisClubApi.BusinessProviders;
using TennisClubApi.Context;
using TennisClubApi.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TennisContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TennisConnectionStr")));
builder.Services.AddScoped<IUserTypeBusinessProvider, UserTypeBusinessProvider>();

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
