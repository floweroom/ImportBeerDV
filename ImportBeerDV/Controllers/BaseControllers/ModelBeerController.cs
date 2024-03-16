using BeerDB;
using ImportBeerDV.Entities;
using ImportBeerDV.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<ModelsBeer>> Post(ModelsBeer modelsBeer)
        {
            if (modelsBeer == null)
            {
                return BadRequest();
            }

            db.BModels.Add(modelsBeer);
            await db.SaveChangesAsync();
            return Ok(modelsBeer);

        }

        [HttpPut]
        public async Task<ActionResult<ModelsBeer>> Put(ModelsBeer modelsBeer)
        {
            if (modelsBeer == null)
            {
                return BadRequest();
            }
            if (!db.BModels.Any(x => x.Id == modelsBeer.Id))
            {
                return NotFound();
            }
            db.Update(modelsBeer);
            await db.SaveChangesAsync();
            return Ok(modelsBeer);
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
            db.SaveChangesAsync();
            return Ok(modelsbeer);
        }
    }

         


        
 }


           
          
     
 
    

