namespace Task1
{
    class Display
    {
        // The definition of the private attributes 
        private int width;
        private int height;
        private float ppi;
        private String? model;

        // The definition of the getters and setters
        public int Width {get {return width;} set {this.width = value;}}
        public int Height {get {return height;} set {this.height = value;}}
        public float Ppi {get {return ppi;} set {this.ppi = value;}}
        public String? Model {get {return model;} set {this.model = value;}}

        // Methods for comparison
        public void CompareSize(Display m)
        {

        }

        public void CompareSharpness(Display m)
        {
            
        }

        public void CompareWithMonitor(Display m)
        {
            
        }

        // Constructor
        public Display(int width, int height, float ppi, String model)
        {
            Width = width;
            Height = height;
            Ppi = ppi;
            Model = model;
        }

    }
}