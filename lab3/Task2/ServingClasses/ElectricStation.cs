namespace lab3.Task2
{
    public class ElectricStation : IRefuelable
    {
        public void Refuel(int carId)
        {
            Console.WriteLine("Refueling ELECTRIC Car {0}", carId);
            ServeData.IncrementElectricCars();
        }
    }
}