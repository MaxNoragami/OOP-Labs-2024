namespace Lab3.Task4.Coffees
{
    sealed internal class Americano : Coffee
    {
        // Fields
        private int mlOfWater;

        // Properties
        private int MlOfWater{get{return mlOfWater;}}

        // Methods 
        sealed internal override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Americano water: {0}", MlOfWater);
        }

        internal Americano MakeAmericano()
        {
            MakeCoffee();
            Console.WriteLine("Adding {0} mls of WATER", MlOfWater);
            Thread.Sleep(500);
            return this;
        }

        // Constructor
        internal Americano(Intensity intensity, int mlOfWater) : base(intensity)
        {
            CoffeeName = "Americano";
            this.mlOfWater = mlOfWater;
        }
    }
}