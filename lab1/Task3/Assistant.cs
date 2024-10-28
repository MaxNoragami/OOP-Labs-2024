namespace Task3
{
    class Assistant
    {
        private String? assistantName;
        private List<Display> assignedDisplays;
        public String? AssistantName {get{ return this.assistantName;}}
        public List<Display> AssignedDisplays {get{return this.assignedDisplays;}}        

        public void AssignDisplays(Display d)
        {
            this.AssignedDisplays.Add(d);
        }

        public void Assist()
        {
            for(int i = 0; i < AssignedDisplays.Capacity - 1; i++)
            {
                Display display1 = this.AssignedDisplays.ElementAt(i);
                
                Display display2 = this.AssignedDisplays.ElementAt(i + 1);

                display1.CompareWithMonitor(display2);
                Console.WriteLine();
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

        public Assistant(String? name)
        {
            assistantName = name;
            assignedDisplays = new List<Display>();
        }
    }
}