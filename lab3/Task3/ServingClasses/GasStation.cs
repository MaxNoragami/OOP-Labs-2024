namespace lab3.Task3
{
    public class GasStation : IRefuelable
    {
        public void Refuel(int carId)
        {
            Console.WriteLine("Refueling GAS Car {0}", carId);
            ServeData.IncrementGasCars();
        }
    }
}