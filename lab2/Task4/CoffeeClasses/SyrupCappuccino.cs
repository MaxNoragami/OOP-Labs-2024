namespace Lab3.Task4.Coffees
{
    sealed internal class SyrupCappuccino : Cappuccino
    {
        // Fields
        private SyrupType syrup;

        // Properties
        private SyrupType Syrup{get{return syrup;}}

        // Methods 
        sealed internal override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Syrup Cappuccino syrup type: {0}", Syrup);
        }

        internal SyrupCappuccino MakeSyrupCappuccino()
        {
            MakeCappuccino();
            Console.WriteLine("Adding some {0} syrup", Syrup);
            Thread.Sleep(500);
            return this;
        }

        // Constructor
        internal SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
        {
            CoffeeName = "SyrupCappuccino";
            this.syrup = syrup;
        }
    }
}