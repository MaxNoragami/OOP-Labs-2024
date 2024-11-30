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
            throw new NotImplementedException();
        }

        public void AddCar(Car car)
        {
            throw new NotImplementedException();
        }


    }
}