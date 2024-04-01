using Microsoft.EntityFrameworkCore;
using FeedBackPortal.Data;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

var mySqlConnection = Environment.GetEnvironmentVariable("MySqlConnection");

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(mySqlConnection,
    new MySqlServerVersion(new Version(8, 0, 1))));


builder.Services.AddControllers();  // For Controllers



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







app.Run();

