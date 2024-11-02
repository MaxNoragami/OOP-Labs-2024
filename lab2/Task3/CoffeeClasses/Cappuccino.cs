namespace Lab3.Task3
{
    class Cappuccino : Coffee
    {
        // Fields
        private int mlOfMilk;

        // Properties
        protected int MlOfMilk{get{return mlOfMilk;}}

        // Methods 
        public override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Cappuccino milk: {0}", MlOfMilk);
        }

        public Cappuccino MakeCappuccino()
        {
            MakeCoffee();
            Console.WriteLine("Adding {0} mls of MILK", MlOfMilk);
            return this;
        }

        // Constructor
        public Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
        {
            CoffeeName = "Cappuccino";
            this.mlOfMilk = mlOfMilk;
        }
    }
}