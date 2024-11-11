namespace Lab3.Task1
{
    class Cappuccino : Coffee
    {
        // Fields
        private int mlOfMilk;

        // Properties
        public int MlOfMilk{get{return mlOfMilk;}}

        // Constructor
        public Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
        {
            coffeeName = "Cappuccino";
            this.mlOfMilk = mlOfMilk;
        }
    }
}