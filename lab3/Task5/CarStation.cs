namespace lab3.Task5
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
                Console.WriteLine();
                Car dequeuedCar = queue.Dequeue();

                // Serving the entities at the Diner
                if(dequeuedCar.IsDining) diningService.ServeDiner(dequeuedCar.Id);
                else ServeData.IncrementNotDining();
                
                if(dequeuedCar.Passengers == PassengersType.PEOPLE) ServeData.IncrementPeopleAmount();
                else ServeData.IncrementRobotsAmount();

                // Refuling the car
                refuelingService.Refuel(dequeuedCar.Id);
                if (dequeuedCar.Type == CarType.ELECTRIC) ServeData.IncrementElectricConsumption(dequeuedCar.Consumption);
                else ServeData.IncrementGasConsumption(dequeuedCar.Consumption);
                
                Console.WriteLine("Car {0} has been served", dequeuedCar.Id);
            }
        }

        public void AddCar(Car car)
        {
            queue.Enqueue(car);
        }

        public bool IsEmpty()
        {
            if(queue.Size() == 0) return true;
            return false;
        }

        public IDineable GetDiningService(){return diningService;}
        public IRefuelable GetRefulingService(){return refuelingService;}


    }
}