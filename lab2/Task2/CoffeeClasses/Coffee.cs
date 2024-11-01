namespace Lab3.Task2
{
    class Coffee
    {
        // Fields
        private Intensity coffeeIntensity;
        protected String coffeeName;

        // Properties
        public Intensity CoffeeIntensity{get{return coffeeIntensity;}}
        public String CoffeeName{get{return coffeeName;}}

        // Methods 
        public virtual void PrintCoffeeDetails()
        {
            
            Console.WriteLine("{0} intensity: {1}", CoffeeName, CoffeeIntensity);
        }

        // Constructor
        public Coffee(Intensity intensity)
        {
            coffeeName = "Coffee";
            coffeeIntensity = intensity;
        }
    }
}