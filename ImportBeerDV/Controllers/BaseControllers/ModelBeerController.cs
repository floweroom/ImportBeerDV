using BeerDB;
using ImportBeerDV.Entities;
using ImportBeerDV.Models;
using ImportBeerDV.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ImportBeerDV.Controllers.BaseControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelBeerController : ControllerBase
    {

        private BeerContext db;
        public ModelBeerController(BeerContext context)
        {
            db = context;


        }

        [HttpGet("get")]
        public async Task<ActionResult<IEnumerable<ModelsBeer>>> Get()
        {
            return await db.BModels.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ModelsBeer>> Get(int id)

        {
            ModelsBeer modelbeer = await db.BModels.FirstOrDefaultAsync(x => x.Id == id);
            if (modelbeer == null)
                return NotFound();
            return new ObjectResult(modelbeer);


        }

        [HttpPost]
        public async Task<ActionResult<BeerDto>> Post(BeerDto beerDto)
        {
            if (beerDto == null)
            {
                return BadRequest();
            }
            else
            {
                ModelsBeer modelsBeer = new ModelsBeer
                {
                   
                    Brand = beerDto.Brand,

                    Name = beerDto.Name,

                    Region = beerDto.Region,

                    Calories = beerDto.Calories,

                    Strength = beerDto.Strength,

                    Colour = beerDto.Colour,

                    Volume = beerDto.Volume,

                   

                };


                db.BModels.Add(modelsBeer);
                await db.SaveChangesAsync();
                return Ok(beerDto);

            }
        }

            [HttpDelete]

            public async Task<ActionResult<ModelsBeer>> Delete(int id)
            {

                ModelsBeer modelsbeer = db.BModels.FirstOrDefault(x => x.Id == id);
                if (modelsbeer == null)
                {
                    return NotFound();
                }
                db.BModels.Remove(modelsbeer);
                await db.SaveChangesAsync();
                return Ok(modelsbeer);
            }
            [HttpPost("{Id}")]

            public async Task Update(int Id, BeerDto beerDto)
            {
                ModelsBeer modelsBeer = new ModelsBeer
                {
                   
                    Brand = beerDto.Brand,

                    Name = beerDto.Name,

                    Region = beerDto.Region,

                    Calories = beerDto.Calories,

                    Strength = beerDto.Strength,

                    Colour = beerDto.Colour,

                    Volume = beerDto.Volume,


                };
                db.BModels.Update(modelsBeer);
                await db.SaveChangesAsync();




            }
     }






    
}









