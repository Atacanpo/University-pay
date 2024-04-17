using Microsoft.EntityFrameworkCore;
using UniversityBankingApplication.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UBADatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

builder.Services.AddDbContext<UBAContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
