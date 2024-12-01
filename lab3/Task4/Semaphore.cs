namespace lab3.Task4
{
    public class Semaphore
    {
        private List<CarStation> carStations = new List<CarStation>();

        public Semaphore(List<CarStation> carStations)
        {
            this.carStations = carStations;
        }

        public List<CarStation> GetCarStations()
        {   
            return carStations;
        }

        private void LeadToRightStation(Car car)
        {
            throw new NotImplementedException();
        }

        public void ServeCars(LinkedListQueue<Car> CarsForServing)
        {
            throw new NotImplementedException();
        }

    }
}