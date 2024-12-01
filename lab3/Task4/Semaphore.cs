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
            if(car.Type == CarType.GAS && car.Passengers == PassengersType.PEOPLE)
            {
                foreach(CarStation station in carStations)
                {
                    if(station.GetRefulingService() is GasStation && station.GetDiningService() is PeopleDiner) 
                    {
                        station.AddCar(car);
                        break;
                    } 
                }
            }
            else if(car.Type == CarType.GAS && car.Passengers == PassengersType.ROBOTS)
            {
                foreach(CarStation station in carStations)
                {
                    if(station.GetRefulingService() is GasStation && station.GetDiningService() is RobotsDiner) 
                    {
                        station.AddCar(car);
                        break;
                    } 
                }
            }
            else if(car.Type == CarType.ELECTRIC && car.Passengers == PassengersType.ROBOTS)
            {
                foreach(CarStation station in carStations)
                {
                    if(station.GetRefulingService() is ElectricStation && station.GetDiningService() is RobotsDiner) 
                    {
                        station.AddCar(car);
                        break;
                    } 
                }
            }
            else if(car.Type == CarType.ELECTRIC && car.Passengers == PassengersType.PEOPLE)
            {
                foreach(CarStation station in carStations)
                {
                    if(station.GetRefulingService() is ElectricStation && station.GetDiningService() is PeopleDiner)
                    {
                        station.AddCar(car);
                        break;
                    } 
                }
            }
        }

        public void ServeCars(LinkedListQueue<Car> CarsForServing)
        {
            while(CarsForServing.Size() > 0)
            {
                LeadToRightStation(CarsForServing.Dequeue());
            }
        }

    }
}