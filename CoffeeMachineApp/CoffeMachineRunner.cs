using CoffeeMachineApp.Models;
using CoffeeMachineApp.Services;

public class CoffeMachineRunner
{
    public static void Main()
    {
        List<CoffeeMachineResource> resources = new List<CoffeeMachineResource>()
        {
            new CoffeeMachineResource("Water", 1000),
            new CoffeeMachineResource("Milk", 500),
            new CoffeeMachineResource("Coffee", 200),
            new CoffeeMachineResource("Money", 0.0f)
        };

        List<Drink> coffeeOptions = new List<Drink>
        {
            new Drink("espresso", new List<Ingredient> { new Ingredient("Water", 50), new Ingredient("Coffee", 20) }, 3.0f),
            new Drink("latte", new List<Ingredient> { new Ingredient("Water", 200), new Ingredient("Milk", 150), new Ingredient("Coffee", 24) }, 5.0f),
            new Drink("cappuccino", new List<Ingredient> { new Ingredient("Water", 250), new Ingredient("Milk", 100), new Ingredient("Coffee", 24) }, 4.0f)
        };

        CoffeeMachineManager coffeeMachine = new CoffeeMachineManager();
        coffeeMachine.StartCoffeMachine(resources, coffeeOptions);
    }
}