using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerDB
{
    public class ModelsBeer
    {
        public int Id {  get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public int Botle {  get; set; }

        public int Price { get; set; }

        public string Region { get; set; }
    }
}
