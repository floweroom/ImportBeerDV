using BeerDB;
using ImportBeerDV.Entities;
using ImportBeerDV.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImportBeerDV.Controllers.BaseControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelBeerController<T> : ControllerBase where T : class, IEntity
    {
        protected IBeerRepository<T> Repository { get; }
        BeerContext db;
        ModelBeerController(BeerContext context)
        {
            db = context;
            if (!db.BModels.Any())
            {
                db.BModels.Add(new ModelsBeer { Brand = "Krusovice", Name = "светлое", Botle= 0,5, Region="Holand" });
                db.BModels.Add(new ModelsBeer { Brand = "Paulaner", Name = "Salvator", Botle = 0,5, Region = "Germany" });
                db.SaveChanges();
            }
        }
        
            [HttpGet("count")]
            public virtual async Task<IActionResult> Count()
        {
            var count = await Repository.Count();
            return Ok(count);
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            var items = await Repository.GetAllAsync();
            if (!items.Any())
                return NoContent();
            return Ok(items);
        }

        [HttpGet("({Skip}:{Take})")]
        public virtual async Task<IActionResult> Get(int Skip, int Take)
        {
            var items = await Repository.GetAsync(Skip, Take);
            if (!items.Any())
                return NoContent();
            return Ok(items);
        }

        [HttpGet("{Id}")]
        public virtual async Task<IActionResult> GetById(int Id)
        {
            var item = await Repository.GetIdAsync(Id);
            if (item is null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] T item)
        {
            var id = await Repository.AddAsync(item);
            return CreatedAtAction(nameof(GetById), new { Id = id }, item);
        }

        [HttpPut]
        public virtual async Task<IActionResult> Update([FromBody] T item)
        {
            var result = await Repository.UpdateAsync(item);
            if (result)
                return Ok(true);
            return NotFound(false);
        }

        [HttpDelete("{Id}")]
        public virtual async Task<IActionResult> Delete(int Id)
        {
            var item = await Repository.RemoveAsync(Id);
            if (item is null)
                return NotFound();
            return Ok(item);
        }
    }
}
