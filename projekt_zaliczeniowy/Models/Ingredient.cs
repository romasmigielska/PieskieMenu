using System.ComponentModel.DataAnnotations.Schema;

namespace projekt_zaliczeniowy.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal Quantity { get; set; }
        public int? RecipeId { get; set; }
        public bool Definition { get; set; }
    }
}
