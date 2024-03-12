using BeerDB;
using ImportBeerDV.Entities;
using ImportBeerDV.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ImportBeerDV.Repository.Interfaces
{
    public interface IBeerRepository<T> where T : class, IEntity
    {
        Task<int> Count(CancellationToken Cancel = default);

        Task<ModelsBeer> GetIdAsync(int id);

        Task<IEnumerable<T>> GetAsync(int Skip, int Take, CancellationToken Cancel = default);

        Task <IEnumerable<BeerDto>> GetAllAsync();
        
        public Task AddAsync(BeerDto Beer);

        public Task UpdateAsync(int Id, BeerDto Beer);


        public Task DeleteAsync(int id);


    }
}
