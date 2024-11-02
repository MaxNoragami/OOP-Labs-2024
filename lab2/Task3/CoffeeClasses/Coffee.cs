namespace Lab3.Task3
{
    abstract class Coffee
    {
        // Fields
        private Intensity coffeeIntensity;
        private String? coffeeName;

        // Properties
        protected Intensity CoffeeIntensity{get{return coffeeIntensity;}}
        protected String? CoffeeName{get{return coffeeName;} set{coffeeName = value;}}

        // Methods 
        public virtual void PrintCoffeeDetails()
        {
            Console.WriteLine("{0} intensity: {1}", CoffeeName, CoffeeIntensity);
        }

        protected Coffee MakeCoffee()
        {
            Console.WriteLine("Making {0}", CoffeeName);
            Console.WriteLine("Intensity set to {0}", CoffeeIntensity);
            return this;
        }

        // Constructor
        protected Coffee(Intensity intensity)
        {
            coffeeIntensity = intensity;
        }
    }
}