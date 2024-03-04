using System.ComponentModel.DataAnnotations;

namespace ImportBeerDV.Entities
{
    public interface INamedEntity : IEntity
    {
        [Required]
        string Name { get; set; }
    }
}
