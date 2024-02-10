using APIPizzaria.Data;
using APIPizzaria.Interface;
using APIPizzaria.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var DefaultConnection = "server=localhost;userid=root;password=895smigol;database=APIPizzaria;";

builder.Services.AddDbContext<DarpinosDbContext>(options =>
{
    options.UseMySql(DefaultConnection, ServerVersion.AutoDetect(DefaultConnection));
});

builder.Services.AddScoped<DarpinosDbContext>();

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
