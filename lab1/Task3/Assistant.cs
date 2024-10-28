namespace Task3
{
    class Assistant
    {
        // Defining the private attributes
        private String? assistantName;
        private List<Display> assignedDisplays;

        // The properties definition
        public String? AssistantName {get{ return this.assistantName;} set{ this.assistantName = value;}}
        public List<Display> AssignedDisplays {get{return this.assignedDisplays;}}        

        // The implementation of the methods
        public void AssignDisplays(Display d)
        {
            this.AssignedDisplays.Add(d);
        }

        public void Assist()
        {   
            Console.WriteLine("\n{0} mentions that:", AssistantName);
            if(AssignedDisplays.Count > 1)
            {
                for(int i = 0; i < AssignedDisplays.Count - 1; i++)
                {
                    Display display1 = this.AssignedDisplays.ElementAt(i);
                    Display display2 = this.AssignedDisplays.ElementAt(i + 1);

                    display1.CompareWithMonitor(display2);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There are not enough assigned Displays in order to Assist you with choosing one!");
            }
        }

        public Display? BuyDisplay(Display d)
        {
            Display? purchasedDisplay = null;
            foreach(Display display in AssignedDisplays)
            {
                if(display.Equals(d))
                {
                    assignedDisplays.Remove(display);
                    purchasedDisplay = display;
                    break;
                }
            } 
            return purchasedDisplay;
        }

        // Constructor
        public Assistant(String? name)
        {
            AssistantName = name;
            assignedDisplays = new List<Display>();
        }
    }
}