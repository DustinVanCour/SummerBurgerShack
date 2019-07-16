using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
    public class Burger
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(.90, double.MaxValue)]
        public double Price { get; set; }

    }
}