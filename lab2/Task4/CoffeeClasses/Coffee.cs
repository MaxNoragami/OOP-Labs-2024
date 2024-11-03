namespace Lab3.Task4.Coffees
{
    internal abstract class Coffee
    {
        // Fields
        private Intensity coffeeIntensity;
        private String? coffeeName;

        // Properties
        protected Intensity CoffeeIntensity{get{return coffeeIntensity;}}
        internal String? CoffeeName{get{return coffeeName;} set{coffeeName = value;}}

        // Methods 
        internal virtual void PrintCoffeeDetails()
        {
            Console.WriteLine("{0} intensity: {1}", CoffeeName, CoffeeIntensity);
        }

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