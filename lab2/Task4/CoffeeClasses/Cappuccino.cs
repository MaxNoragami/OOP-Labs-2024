namespace Lab3.Task4.Coffees
{
    internal class Cappuccino : Coffee
    {
        // Fields
        private int mlOfMilk;

        // Properties
        protected int MlOfMilk{get{return mlOfMilk;}}

        // Methods 
        internal override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Cappuccino milk: {0}", MlOfMilk);
        }

        internal Cappuccino MakeCappuccino()
        {
            MakeCoffee();
            Console.WriteLine("Adding {0} mls of MILK", MlOfMilk);
            Thread.Sleep(500);
            return this;
        }

        // Constructor
        internal Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
        {
            CoffeeName = "Cappuccino";
            this.mlOfMilk = mlOfMilk;
        }
    }
}