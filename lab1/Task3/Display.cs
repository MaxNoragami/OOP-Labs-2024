namespace Task3
{
    class Display
    {
        // The definition of the private attributes 
        private int width;
        private int height;
        private float ppi;
        private String? model;

        // The definition of the Properties (getters and setters)
        public int Width {get {return width;} set {width = value;}}
        public int Height {get {return height;} set {height = value;}}
        public float Ppi {get {return ppi;} set {ppi = value;}}
        public String? Model {get {return model;} set {model = value;}}

        // Methods for comparison
        public void CompareSize(Display m)
        {   
            int currentSize = Height * Width;
            int otherSize = m.Height * m.Width;
            Console.WriteLine(
                (currentSize > otherSize)? 
                    $"The {Model} has a bigger size of {currentSize}px^2, than the {m.Model} of size {otherSize}px^2." 
                : (currentSize < otherSize)?
                    $"The {m.Model} has a bigger size of {otherSize}px^2, than the {Model} of size {currentSize}px^2."
                : 
                    $"Both, {Model} and {m.Model}, have the same size of {currentSize}px^2."
            );
        }

        public void CompareSharpness(Display m)
        {
            Console.WriteLine(
                (Ppi > m.Ppi)? 
                    $"The {Model} is sharper with a density of {Ppi}ppi, than the {m.Model} with a density of {m.Ppi}ppi." 
                : (Ppi < m.Ppi)?
                    $"The {m.Model} is sharper with a density of {m.Ppi}ppi, than the {Model} with a density of {Ppi}ppi." 
                : 
                    $"Both, {Model} and {m.Model}, have the same sharpness, the density being of {Ppi}ppi."
            );
        }

        public void CompareWithMonitor(Display m)
        {
            CompareSize(m);
            CompareSharpness(m);
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