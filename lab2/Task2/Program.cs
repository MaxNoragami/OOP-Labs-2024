namespace Lab3.Task2
{
    class Program
    {
        static void Main()
        {
            Coffee coffee = new Coffee(Intensity.STRONG);
            coffee.PrintCoffeeDetails();

            Cappuccino cappuccino = new Cappuccino(Intensity.NORMAL, 50);
            cappuccino.PrintCoffeeDetails();

            Americano americano = new Americano(Intensity.NORMAL, 40);
            americano.PrintCoffeeDetails();

            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(Intensity.LIGHT, 70, 30);
            pumpkinSpiceLatte.PrintCoffeeDetails();

            SyrupCappuccino syrupCappuccino = new SyrupCappuccino(Intensity.LIGHT, 50, SyrupType.CHOCOLATE);
            syrupCappuccino.PrintCoffeeDetails();
        }
    }
}