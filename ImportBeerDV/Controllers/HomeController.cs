using ImportBeerDV.Models;
using Microsoft.AspNetCore.Mvc;
using BeerDB;

public class HomeController : Controller
{


    private ILogger<HomeController> _logger;

    public BeerContext _beerContext;

    public HomeController(ILogger<HomeController> logger, BeerContext beerContext)
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

}

