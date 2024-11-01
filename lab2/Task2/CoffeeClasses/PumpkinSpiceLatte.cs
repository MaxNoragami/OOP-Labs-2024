namespace Lab3.Task2
{
    class PumpkinSpiceLatte : Cappuccino
    {
        // Fields
        private int mgOfPumpkinSpice;

        // Properties
        public int MgOfPumpkinSpice{get{return mgOfPumpkinSpice;}}

        // Methods 
        public override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Pumpkin Spice Latte pumpkin-spice: {0}", MgOfPumpkinSpice);
        }

        // Constructor
        public PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
        {
            coffeeName = "PumpkinSpiceLatte";
            this.mgOfPumpkinSpice = mgOfPumpkinSpice;
        }
    }
}