namespace Lab3.Task1
{
    class PumpkinSpiceLatte : Cappuccino
    {
        // Fields
        private int mgOfPumpkinSpice;

        // Properties
        public int MgOfPumpkinSpice{get{return mgOfPumpkinSpice;}}

        // Constructor
        public PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
        {
            coffeeName = "PumpkinSpiceLatte";
            this.mgOfPumpkinSpice = mgOfPumpkinSpice;
        }
    }
}