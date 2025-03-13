using CoffeeMachineApp.Interfaces;
using CoffeeMachineApp.Models;

namespace CoffeeMachineApp.Services
{
    public class CoffeeMachineResourcesManager : IMachineResourceManager
    {
        public List<CoffeeMachineResource> CoffeeMachineResourceResources { get; set; }

        public CoffeeMachineResourcesManager(List<CoffeeMachineResource> coffeeMachineResourceResources)
        {
            CoffeeMachineResourceResources = coffeeMachineResourceResources;
        }

        public void PrintReport()
        {
            foreach (var cmr in CoffeeMachineResourceResources)
            {
                if (cmr.ResourceName.ToLower() == "water" || cmr.ResourceName.ToLower() == "milk")
                {
                    Console.WriteLine($"{cmr.ResourceName}: {cmr.ResourceQuantity}ml");
                }
                else if (cmr.ResourceName.ToLower() == "coffee")
                {
                    Console.WriteLine($"{cmr.ResourceName}: {cmr.ResourceQuantity}g");
                }
                else
                {
                    Console.WriteLine($"{cmr.ResourceName}: ${cmr.ResourceQuantity}");
                }
            }
        }

        public void ReduceResources(Drink coffee)
        {
            foreach (var ing in coffee.Ingredients)
            {
                CoffeeMachineResourceResources.Find(cmr => cmr.ResourceName == ing.Name).ResourceQuantity -= ing.Quantity;
            }
            CoffeeMachineResourceResources.Find(cmr => cmr.ResourceName == "Money").ResourceQuantity += coffee.Cost;
        }
    }
}
