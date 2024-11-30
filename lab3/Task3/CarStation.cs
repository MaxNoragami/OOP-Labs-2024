namespace lab3.Task3
{
    public class CarStation 
    {
        private IDineable diningService;
        private IRefuelable refuelingService;
        private IQueue<Car> queue;

        public CarStation(IDineable dineable, IRefuelable refuelable, IQueue<Car> queue)
        {
            diningService = dineable;
            refuelingService = refuelable;
            this.queue = queue;
        }

        public void ServeCars()
        {
            while(queue.Size() > 0)
            {
                Car dequeuedCar = queue.Dequeue();

                // Serving the entities at the Diner
                if(dequeuedCar.IsDining) diningService.ServeDinner(dequeuedCar.Id);
                else ServeData.IncrementNotDining();

                // Refuling the car
                refuelingService.Refuel(dequeuedCar.Id);
                if (dequeuedCar.Type == CarType.ELECTRIC) ServeData.IncrementElectricConsumption(dequeuedCar.Consumption);
                else ServeData.IncrementGasConsumption(dequeuedCar.Consumption);
                
                Console.WriteLine("Car {0} has been served", dequeuedCar);
            }
        }

        public void AddCar(Car car)
        {
            queue.Enqueue(car);
        }


    }
}