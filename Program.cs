using Npgsql;
using System.Data;
using Temples.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Register the Npgsql connection for Dapper
builder.Services.AddScoped<IDbConnection>(db => new NpgsqlConnection(
    builder.Configuration.GetConnectionString("PostgresDBConnection")
));

builder.Services.AddScoped<ITempleRepository, TempleRepository>();

// Add services to the container.
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

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

