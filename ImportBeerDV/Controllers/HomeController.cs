using ImportBeerDV.Models;
using Microsoft.AspNetCore.Mvc;
using BeerDB;
using ImportBeerDV.Repository;
using ImportBeerDV.Repository.Interfaces;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IBeerRepository _beerRepository;

    private readonly BeerContext _beerdb;
    public HomeController(ILogger<HomeController> logger, IBeerRepository beerrepository, BeerContext beerdb)
    {
        _logger = logger;
        _beerdb = beerdb;
        _beerRepository = beerrepository;

    }

}

