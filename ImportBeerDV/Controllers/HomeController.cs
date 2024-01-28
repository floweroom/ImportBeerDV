using ImportBeerDV.Models;
using Microsoft.AspNetCore.Mvc;
using BeerDB;

public class HomeController : Controller
{


    private ILogger<HomeController> _logger;

    private BeerContext _beerContext;

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

        //foreach (ModelsBeer beer in BeerDB.)
        return new BeerDto[0];

    }


}

