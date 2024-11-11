namespace Lab3.Task3
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Coffee cappuccino = new Cappuccino(Intensity.NORMAL, 50).MakeCappuccino();
            cappuccino.PrintCoffeeDetails();
            Console.WriteLine();

            Coffee americano = new Americano(Intensity.NORMAL, 40).MakeAmericano();
            americano.PrintCoffeeDetails();
            Console.WriteLine();

            Coffee pumpkinSpiceLatte = new PumpkinSpiceLatte(Intensity.LIGHT, 70, 30).MakePumpkinSpiceLatte();
            pumpkinSpiceLatte.PrintCoffeeDetails();
            Console.WriteLine();

            Coffee syrupCappuccino = new SyrupCappuccino(Intensity.LIGHT, 50, SyrupType.CHOCOLATE).MakeSyrupCappuccino();
            syrupCappuccino.PrintCoffeeDetails();
            Console.WriteLine();
        }
    }
}