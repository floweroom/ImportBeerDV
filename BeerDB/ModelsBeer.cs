using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Botle {  get; set; }

        public string Region { get; set; }

        public int Amount { get; set; } 
    }
}
