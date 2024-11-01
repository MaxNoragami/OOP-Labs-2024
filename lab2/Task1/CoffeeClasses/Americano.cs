namespace Lab3.Task1
{
    class Americano : Coffee
    {
        // Fields
        private int mlOfWater;

        // Properties
        public int MlOfWater{get{return mlOfWater;}}

        // Constructor
        public Americano(Intensity intensity, int mlOfWater) : base(intensity)
        {
            coffeeName = "Americano";
            this.mlOfWater = mlOfWater;
        }
    }
}