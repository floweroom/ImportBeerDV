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
    //Db.Database.EnsureCreated();
    Db.Database.Migrate();
    if (!Db.BModels.Any())
    {


        ModelsBeer modelsBeer = new ModelsBeer
        {
            Category = "Пиво",

            Brand = "Velkopopovicky Kozel",

            Name = "Темное",

            Region = "Чехия",

            Calories = 4311,

            Colour = "Темное",

            Degree = 4,

            Volume = 0.5M,

            Taste = "Цитрусово-пряный",

        };

        ModelsBeer modelsBeer1 = new ModelsBeer
        {

            Category = "Пиво",

            Brand = "Krušovice",

            Name = "černé",

            Region = "Чехия",

            Calories = 35,

            Colour = "Светлое",

            Degree = 3.8M,

            Volume = 0.33M,

            Taste = "Шоколад",

        };

        ModelsBeer modelsBeer2 = new ModelsBeer
        {

            Category = "Пиво",

            Brand = "Blanche de Bruxelles",

            Name = "Rosee",

            Region = "Бельгия",

            Calories = 45,

            Colour = "Светлое",

            Degree = 4.5M,

            Volume = 0.33M,

            Taste = "Цитрусовые"


        };
        ModelsBeer modelsBeer3 = new ModelsBeer
        {


            Category = "Пиво",

            Brand = "The Musketeers ",

            Name = "Troubadour Magma",

            Region = "Бельгия",

            Calories = 48,

            Colour = "Светлое",

            Degree = 0.9M,

            Volume = 0.33M,

            Taste = "Смородина"

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
