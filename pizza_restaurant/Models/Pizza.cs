using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pizza_restaurant.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        public string nom {  get; set; }
        public float prix { get; set; }

        [Display(Name ="Végétarienne")]
        public bool vegetarienne {  get; set; }
		
        [JsonIgnore]
		public string? ingredients { get; set; }

        [NotMapped] // Sert à ne pas stocker dans la DB
        [JsonPropertyName("ingredients")]

        public string[] listeIngredients
        {
            get
            {
                if ((ingredients == null || ingredients.Count() == 0))
                {
                    return null;
                }
                return ingredients.Split(", ");
            }
        }



    }
}
