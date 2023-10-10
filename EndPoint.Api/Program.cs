using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.CarwashServices.Queries.Create;
using CarwashProject.Application.Services.CarwashServices.Queries.GetServiceById;
using CarwashProject.Application.Services.CarwashServices.Queries.Update;
using CarwashProject.Application.Services.Workers.Queries.Create;
using CarwashProject.Application.Services.Workers.Queries.Delete;
using CarwashProject.Application.Services.Workers.Queries.GetWorker;
using CarwashProject.Application.Services.Workers.Queries.GetWorkerById;
using CarwashProject.Application.Services.Workers.Queries.Update;
using CarwashProject.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sql")));
builder.Services.AddScoped<IAppDbContext, AppDbContext>();
builder.Services.AddScoped<IGetWorkerService, GetWorkerService>();
builder.Services.AddScoped<IGetWorkerByIdService, GetWorkerByIdService>();
builder.Services.AddScoped<ICreate, Create>();
builder.Services.AddScoped<IDelete, Delete>();
builder.Services.AddScoped<IUpdate, Update>();
builder.Services.AddScoped<ICreate2, Create2>();
builder.Services.AddScoped<IUpdate2, Update2>();
builder.Services.AddScoped<IGetServiceById, GetServiceById>();

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
