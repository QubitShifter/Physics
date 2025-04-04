namespace CoffeeMachineApp.Models
{
    public class Drink
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public float Cost { get; set; }

        public Drink(string name, List<Ingredient> ingredients, float cost)
        {
            Name = name;
            Ingredients = ingredients;
            Cost = cost;
        }
    }
}
