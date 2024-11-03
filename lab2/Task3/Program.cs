namespace Lab3.Task3
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Cappuccino cappuccino = new Cappuccino(Intensity.NORMAL, 50).MakeCappuccino();
            cappuccino.PrintCoffeeDetails();
            Console.WriteLine();

            Americano americano = new Americano(Intensity.NORMAL, 40).MakeAmericano();
            americano.PrintCoffeeDetails();
            Console.WriteLine();

            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(Intensity.LIGHT, 70, 30).MakePumpkinSpiceLatte();
            pumpkinSpiceLatte.PrintCoffeeDetails();
            Console.WriteLine();

            SyrupCappuccino syrupCappuccino = new SyrupCappuccino(Intensity.LIGHT, 50, SyrupType.CHOCOLATE).MakeSyrupCappuccino();
            syrupCappuccino.PrintCoffeeDetails();
            Console.WriteLine();
        }
    }
}