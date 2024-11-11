namespace Lab3.Task1
{
    class SyrupCappuccino : Cappuccino
    {
        // Fields
        private SyrupType syrup;

        // Properties
        public SyrupType Syrup{get{return syrup;}}

        // Constructor
        public SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
        {
            coffeeName = "SyrupCappuccino";
            this.syrup = syrup;
        }
    }
}