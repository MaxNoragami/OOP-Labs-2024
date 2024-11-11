namespace Lab3.Task2
{
    class Americano : Coffee
    {
        // Fields
        private int mlOfWater;

        // Properties
        public int MlOfWater{get{return mlOfWater;}}

        // Methods 
        public override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Americano water: {0}", MlOfWater);
        }

        // Constructor
        public Americano(Intensity intensity, int mlOfWater) : base(intensity)
        {
            coffeeName = "Americano";
            this.mlOfWater = mlOfWater;
        }
    }
}