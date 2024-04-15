using System.ComponentModel.DataAnnotations.Schema;

namespace ImportBeerDV.Models
{
    public class BeerDto
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public string Region { get; set; }

        public decimal Calories { get; set; }

        public string Colour { get; set; }

        public decimal Degree { get; set; }

        public decimal Volume { get; set; }

        public string Taste { get; set; }

       
    }

}
