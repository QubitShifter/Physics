using CoffeeMachineApp.Models;
using CoffeeMachineApp.Services;

namespace CoffeeMachineApp.Interfaces
{
    public interface IMachineManager
    {
        void StartCoffeMachine(List<CoffeeMachineResource>? resources, List<Drink>? coffeeOptions);
        void MakeCoffee(List<CoffeeMachineResource>? resources, Drink coffeeChoice);
        float ProcessCoins();
    }
}
