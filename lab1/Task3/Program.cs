namespace Task3
{
    class Program
    {
        static void Main()
        {
            // Instances of the Display class
            Display samsung = new Display(1366, 768, 82.48f, "SAMSUNG UE-19");
            Display hp = new Display(2560, 1600, 226.98f, "HP AERO 13");
            Display tcl = new Display(1920, 1080, 51.23f, "TCL 43S");

            // New Assistant instance
            Assistant alexa = new Assistant("Alexa");

            // Assigning the available displays to her
            alexa.AssignDisplays(samsung);
            alexa.AssignDisplays(hp);
            alexa.AssignDisplays(tcl);

            // Assisting me with info about the selected Displays
            alexa.Assist();

            // Purchasing one of the displays
            Display? purchased = alexa.BuyDisplay(hp);
            if(purchased != null)
                Console.WriteLine($"The {purchased.Model} display was bought!");
            else
                Console.WriteLine("No such display was found in the assigned list!");

            // Assisting me with info about the remaining Displays
            alexa.Assist();
        }
    }
}