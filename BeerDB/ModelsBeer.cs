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


        public string Region { get; set; }


        [Column(TypeName = "decimal(5, 2)")]
        public decimal Calories { get; set; }


        public string Colour { get; set; }


        [Column(TypeName = "decimal(5, 2)")]
        public decimal Degree { get; set; }


        [Column(TypeName = "decimal(5, 2)")]
        public decimal Volume{ get; set; }

        public string Taste { get; set; }

    }
}
