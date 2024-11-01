namespace Lab3.Task1
{
    class Coffee
    {
        // Fields
        private Intensity coffeeIntensity;
        protected String coffeeName;

        // Properties
        public Intensity CoffeeIntensity{get{return coffeeIntensity;}}
        public String CoffeeName{get{return coffeeName;}}

        // Constructor
        public Coffee(Intensity intensity)
        {
            coffeeName = "Coffee";
            coffeeIntensity = intensity;
        }
    }
}