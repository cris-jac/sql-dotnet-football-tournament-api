//using LaboratorioAws.Data;
using LaboratorioAws.Services;
using Microsoft.EntityFrameworkCore;
using Model.Interfaces;
using Repository.Data;
using Repository.Repositories;
using Security.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Change: New Context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddDbContext<AuthDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("AuthConnection"));
});

// Token service
builder.Services.AddScoped<TokenService>();

// Unit Of Work pattern
//builder.Services.AddScoped< UnitOfWork>();
builder.Services.AddScoped< UnitOfWork>();

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
