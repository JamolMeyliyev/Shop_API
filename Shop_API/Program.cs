using Microsoft.EntityFrameworkCore;
using Shop_API.Context;
using Shop_API.Managers;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ShopDbContext>(options =>
{
    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    options.UseNpgsql("Server=localhost; Port=5434; Database=postgres; User Id=postgres; Password=postgres;");
});

builder.Services.AddScoped<IAuthorManager, AuthorManager>();
builder.Services.AddScoped<IBookManager, BookManager>();
builder.Services.AddScoped<IDiscountManager, DiscountManager>();
builder.Services.AddScoped<IGenreManager, GenreManager>();
builder.Services.AddScoped<IPublisherManager,PublisherManager>();
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
