using BeerDB;
using ImportBeerDV.Models;
using ImportBeerDV.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ImportBeerDV.Repository
{
    public class BeerRepository: IBeerRepository
    {
        private ILogger<BeerRepository> _logger;

        public BeerContext _beerContext;

        public BeerRepository(ILogger<BeerRepository> logger, BeerContext beerContext)
        {
            _logger = logger;

            _beerContext = beerContext;

        }
        //[HttpDelete(Name = "")]
        [HttpGet("{id}")]
        public async Task<ModelsBeer> GetId(int id)
        {
            //ModelsBeer beer = BeerDB.
            return new ModelsBeer();
        }


        [HttpGet]
        public IEnumerable<BeerDto> Get()
        {

            //List<BeerDto> result = new List<BeerDto>();

            //foreach (ModelsBeer modelsBeer in _beerContext.BModels.ToList();)
            return new BeerDto[0];

        }

        [HttpPost]
        public async Task Add(BeerDto Beer)
        {
            ModelsBeer beer = new ModelsBeer()
            {
                Brand = Beer.Brand,

                Name = Beer.Name,

                Botle = Beer.Botle,

                Price = Beer.Price,

                Region = Beer.Region,

            };

            _beerContext.Add(Beer);
            _beerContext.SaveChanges();
        }

        Task<IEnumerable<BeerDto>> IBeerRepository.Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(int Id, BeerDto Beer)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
