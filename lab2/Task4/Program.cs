namespace Lab3.Task4
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Barista barista = new Barista("John Doe");
            // Requesting to make the coffee
            barista.RequestCoffee();
            // Veiwing the order's detials
            barista.ViewOrderDetails();
        }
    }
}