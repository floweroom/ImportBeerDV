using BeerDB;
using ImportBeerDV.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("SqlServer");

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BeerContext>(opts =>
{
    opts.UseSqlServer(connectionString);
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var Db = scope.ServiceProvider.GetRequiredService<BeerContext>();
    Db.Database.EnsureDeleted();
    Db.Database.EnsureCreated();
    //Db.Database.Migrate();
    if (!Db.BModels.Any())
    {


        ModelsBeer modelsBeer = new ModelsBeer
        {
            Category = "Лимонад",

            Brand = "Волковский лимонад",

            Name = "Лимонад со вкусом арбуза",

            Region = "Россия",

            Calories = 250,

            Colour = "Красный",

            Volume = 0.5M,

            Taste = "Арбуз",

        };

        ModelsBeer modelsBeer1 = new ModelsBeer
        {

            Category = "Лимонад",

            Brand = "Волковский лимонад",

            Name = "Лимонад со вкусом персика",

            Region = "Россия",

            Calories = 250,

            Colour = "Персиковый",

            Volume = 0.5M,

            Taste = "Персик",

        };

        ModelsBeer modelsBeer2 = new ModelsBeer
        {

            Category = "Лимонад",

            Brand = "Волковский лимонад",

            Name = "Лимонад со вкусом манго-кокос",

            Region = "Россия",

            Calories = 250,

            Colour = "Оранжевый",

          
            Volume = 0.5M,

            Taste = "Цитрусовые"


        };
        ModelsBeer modelsBeer3 = new ModelsBeer
        {


            Category = "Лимонад",

            Brand = "Волковский лимонад",

            Name = "Лимонад со вкусом Cola",

            Region = "Россия",

            Calories = 250,

            Colour = "Темный",

           
            Volume = 0.5M,

            Taste = "Кола"

        };


        Db.BModels.Add(modelsBeer);
        Db.BModels.Add(modelsBeer1);
        Db.BModels.Add(modelsBeer2);
        Db.BModels.Add(modelsBeer3);

        await Db.SaveChangesAsync();
    }
}

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
