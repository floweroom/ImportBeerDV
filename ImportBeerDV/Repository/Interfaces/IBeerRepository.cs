using BeerDB;
using ImportBeerDV.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ImportBeerDV.Repository.Interfaces
{
    public interface IBeerRepository
    {
        public Task<ModelsBeer> GetId(int id);

        public Task <IEnumerable<BeerDto>> Get();


        public Task Add(BeerDto Beer);

        public Task Update(int Id, BeerDto Beer);


        public Task Delete(int id);


    }
}
