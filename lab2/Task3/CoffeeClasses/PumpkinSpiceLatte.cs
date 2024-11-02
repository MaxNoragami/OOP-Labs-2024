namespace Lab3.Task3
{
    class PumpkinSpiceLatte : Cappuccino
    {
        // Fields
        private int mgOfPumpkinSpice;

        // Properties
        protected int MgOfPumpkinSpice{get{return mgOfPumpkinSpice;}}

        // Methods 
        public override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Pumpkin Spice Latte pumpkin-spice: {0}", MgOfPumpkinSpice);
        }

        public PumpkinSpiceLatte MakePumpkinSpiceLatte()
        {
            MakeCappuccino();
            Console.WriteLine("Sprinkling {0} mg of pumpkin spice", MgOfPumpkinSpice);
            return this;
        }

        // Constructor
        public PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
        {
            CoffeeName = "PumpkinSpiceLatte";
            this.mgOfPumpkinSpice = mgOfPumpkinSpice;
        }
    }
}