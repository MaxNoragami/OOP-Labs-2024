namespace Lab3.Task2
{
    class Cappuccino : Coffee
    {
        // Fields
        private int mlOfMilk;

        // Properties
        public int MlOfMilk{get{return mlOfMilk;}}

        // Methods 
        public override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Cappuccino milk: {0}", MlOfMilk);
        }

        // Constructor
        public Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
        {
            coffeeName = "Cappuccino";
            this.mlOfMilk = mlOfMilk;
        }
    }
}