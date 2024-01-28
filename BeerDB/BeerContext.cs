using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerDB
{
    public class BeerContext: DbContext
    {
        public DbSet<ModelsBeer> BModels { get; set; } = null!;

        public BeerContext(DbContextOptions<BeerContext> options) : base(options) {
        }
    }
}
