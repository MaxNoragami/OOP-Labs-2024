namespace Lab3.Task4
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Barista barista = new Barista("John Doe");
            barista.RequestCoffee();
            barista.ViewOrderDetails();
        }
    }
}