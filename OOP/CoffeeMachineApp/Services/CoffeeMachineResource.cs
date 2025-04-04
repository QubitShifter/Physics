namespace CoffeeMachineApp.Services
{
    public class CoffeeMachineResource
    {
        public string ResourceName { get; set; }
        public float ResourceQuantity { get; set; }

        public CoffeeMachineResource(string resourceName, float resourceQuantity)
        {
            ResourceName = resourceName;
            ResourceQuantity = resourceQuantity;
        }
    }
}
