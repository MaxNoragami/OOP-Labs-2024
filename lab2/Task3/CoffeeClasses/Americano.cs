namespace Lab3.Task3
{
    sealed class Americano : Coffee
    {
        // Fields
        private int mlOfWater;

        // Properties
        protected int MlOfWater{get{return mlOfWater;}}

        // Methods 
        public override sealed void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Americano water: {0}", MlOfWater);
        }

        public Americano MakeAmericano()
        {
            MakeCoffee();
            Console.WriteLine("Adding {0} mls of WATER", MlOfWater);
            return this;
        }

        // Constructor
        public Americano(Intensity intensity, int mlOfWater) : base(intensity)
        {
            CoffeeName = "Americano";
            this.mlOfWater = mlOfWater;
        }
    }
}