namespace Lab3.Task4.Coffees
{
    sealed internal class PumpkinSpiceLatte : Cappuccino
    {
        // Fields
        private int mgOfPumpkinSpice;

        // Properties
        private int MgOfPumpkinSpice{get{return mgOfPumpkinSpice;}}

        // Methods 
        sealed internal override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Pumpkin Spice Latte pumpkin-spice: {0}", MgOfPumpkinSpice);
        }

        internal PumpkinSpiceLatte MakePumpkinSpiceLatte()
        {
            MakeCappuccino();
            Console.WriteLine("Sprinkling {0} mg of pumpkin spice", MgOfPumpkinSpice);
            Thread.Sleep(500);
            return this;
        }

        // Constructor
        internal PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
        {
            CoffeeName = "PumpkinSpiceLatte";
            this.mgOfPumpkinSpice = mgOfPumpkinSpice;
        }


    }
}