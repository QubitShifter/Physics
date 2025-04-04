using CoffeeMachineApp.Interfaces;
using CoffeeMachineApp.Models;

namespace CoffeeMachineApp.Services
{
    public class CoffeeMachineManager : IMachineManager
    {
        public void StartCoffeMachine(List<CoffeeMachineResource>? resources, List<Drink>? coffeeOptions)
        {
            CoffeeMachineResourcesManager coffeeMachineResourceManager = new CoffeeMachineResourcesManager(resources);

            while (true)
            {
                Console.Write("What would you like? (espresso/latte/cappuccino): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "off")
                {
                    Console.WriteLine("Turning off the machine...");
                    return;
                }
                else if (choice == "report")
                {
                    coffeeMachineResourceManager.PrintReport();
                }
                else if (coffeeOptions.Exists(c => c.Name == choice))
                {
                    Drink coffeeChoice = coffeeOptions.Find(c => c.Name == choice);
                    MakeCoffee(resources, coffeeChoice);
                }
                else
                {
                    Console.WriteLine("Invalid selection. Try again.");
                }
            }
        }

        public void MakeCoffee(List<CoffeeMachineResource>? resources, Drink coffeeChoice)
        {
            CoffeeMachineResourcesManager coffeeMachineResourceManager = new CoffeeMachineResourcesManager(resources);
            float insertedMoney = ProcessCoins();

            foreach (var ing in coffeeChoice.Ingredients)
            {
                if (!coffeeMachineResourceManager.CoffeeMachineResourceResources.Exists(cmr => cmr.ResourceName == ing.Name) ||
                     coffeeMachineResourceManager.CoffeeMachineResourceResources.Find(cmr => cmr.ResourceName == ing.Name).ResourceQuantity < ing.Quantity)
                {
                    Console.WriteLine("Sorry, there is not enough " + ing.Name + ".");
                    return;
                }
            }

            if (insertedMoney < coffeeChoice.Cost)
            {
                Console.WriteLine("Sorry, that's not enough money. Money refunded.");
                return;
            }

            if (insertedMoney > coffeeChoice.Cost)
            {
                Console.WriteLine($"Here is ${insertedMoney - coffeeChoice.Cost:0.00} in change.");
            }

            coffeeMachineResourceManager.ReduceResources(coffeeChoice);
            Console.WriteLine("Here is your " + coffeeChoice.Name + ". Enjoy!");
        }

        public float ProcessCoins()
        {
            Console.WriteLine("Please insintoins.");
            Console.Write("Quarters: "); int quarters = int.Parse(Console.ReadLine());
            Console.Write("Dimes: "); int dimes = int.Parse(Console.ReadLine());
            Console.Write("Nickels: "); int nickels = int.Parse(Console.ReadLine());
            Console.Write("Pennies: "); int pennies = int.Parse(Console.ReadLine());


            return quarters * 0.25f + dimes * 0.10f + nickels * 0.05f + pennies * 0.01f;
        }
    }

}
