namespace Lab3.Task2
{
    class SyrupCappuccino : Cappuccino
    {
        // Fields
        private SyrupType syrup;

        // Properties
        public SyrupType Syrup{get{return syrup;}}

        // Methods 
        public override void PrintCoffeeDetails()
        {
            base.PrintCoffeeDetails();
            Console.WriteLine("Syrup Cappuccino syrup type: {0}", Syrup);
        }

        // Constructor
        public SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
        {
            coffeeName = "SyrupCappuccino";
            this.syrup = syrup;
        }
    }
}