namespace Lab3.Task4.Coffees
{
    // The abstract base class 
    internal abstract class Coffee
    {
        // Fields
        private Intensity coffeeIntensity;
        private String? coffeeName;

        // Properties
        protected Intensity CoffeeIntensity{get{return coffeeIntensity;}}
        internal String? CoffeeName{get{return coffeeName;} set{coffeeName = value;}}

        // Methods 
        // The virtual method that get overridden by the subclasses
        internal virtual void PrintCoffeeDetails()
        {
            Console.WriteLine("{0} intensity: {1}", CoffeeName, CoffeeIntensity);
        }

        // The base method for making the coffee
        protected Coffee MakeCoffee()
        {
            Console.WriteLine("\nMaking {0}", CoffeeName);
            Thread.Sleep(500);
            Console.WriteLine("Intensity set to {0}", CoffeeIntensity);
            Thread.Sleep(500);
            return this;
        }

        // Constructor
        protected Coffee(Intensity intensity)
        {
            coffeeIntensity = intensity;
        }
    }
}