using CoffeeMachineApp.Models;

namespace CoffeeMachineApp.Interfaces
{
    public interface IMachineResourceManager
    {
        void PrintReport();
        void ReduceResources(Drink coffee);
    }
}