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
    // Db.Database.EnsureCreated();
    Db.Database.Migrate();
    if (!Db.BModels.Any())
    {
        ModelsBeer modelsBeer = new ModelsBeer
        {
            
            Brand = "Velkopopovicky Kozel",

            Name = "Темное",

            Region = "Чехия",

            Calories = "43",

            Colour = "Темное",

            Degree = 4,

            Volume = 0.5,

            Taste = "Цитрусово-пряный",

        };

        ModelsBeer modelsBeer1 = new ModelsBeer
        {
            

            Brand = "Krušovice",

            Name = "černé",
                     
            Region = "Чехия",

            Calories = "35",

            Colour = "Светлое",

            Degree = 3.8,

            Volume = 0.33,

            Taste = "Шоколад",

        };

        ModelsBeer modelsBeer2 = new ModelsBeer
        {
            
            Brand = "Blanche de Bruxelles",

            Name = "Rosee",

            Region = "Бельгия",
                        
            Calories = 0.45

            Colour = "Светлое",

            Degree = 4.5,

            Volume = 0.33,

            Taste = "Цитрусовые"


        }; 
        ModelsBeer modelsBeer2 = new ModelsBeer
        {
            
            Brand = "The Musketeers ",

            Name = "Troubadour Magma",

            Region = "Бельгия",

            Calories = 0.48,

            Colour = "Светлое",

            Degree = 0.9,

            Volume = 0.33,
            
            Taste = "Смородина"

        };
        

        Db.BModels.Add(modelsBeer);
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
