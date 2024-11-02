namespace Lab3.Task3
{
    class SyrupCappuccino : Cappuccino
    {
        // Fields
        private SyrupType syrup;

        // Properties
        protected SyrupType Syrup{get{return syrup;}}

        // Methods 
        public override void PrintCoffeeDetails()
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