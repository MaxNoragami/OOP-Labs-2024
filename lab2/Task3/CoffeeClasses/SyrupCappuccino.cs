namespace Lab3.Task3
{
    sealed class SyrupCappuccino : Cappuccino
    {
        // Fields
        private SyrupType syrup;

        // Properties
        private SyrupType Syrup{get{return syrup;}}

        // Methods 
        public override sealed void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Syrup Cappuccino syrup type: {0}", Syrup);
        }

        public SyrupCappuccino MakeSyrupCappuccino()
        {
            MakeCappuccino();
            Console.WriteLine("Adding some {0} syrup", Syrup);
            return this;
        }

        // Constructor
        public SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
        {
            CoffeeName = "SyrupCappuccino";
            this.syrup = syrup;
        }
    }
}