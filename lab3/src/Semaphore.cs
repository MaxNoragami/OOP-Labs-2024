namespace lab3.Src
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

        // Choosing the right station for each car
        private void LeadToRightStation(Car car)
        {
            if(car.Type == CarType.GAS && car.Passengers == PassengersType.PEOPLE)
            {
                foreach(CarStation station in carStations)
                {
                    if(station.GetRefulingService() is GasStation && station.GetDiningService() is PeopleDiner) 
                    {
                        Console.WriteLine("Adding Car {0}, to the GAS station for PEOPLE", car.Id);
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
                        Console.WriteLine("Adding Car {0}, to the GAS station for ROBOTS", car.Id);
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
                        Console.WriteLine("Adding Car {0}, to the ELECTRIC station for ROBOTS", car.Id);
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
                        Console.WriteLine("Adding Car {0}, to the ELECTRIC station for PEOPLE", car.Id);
                        station.AddCar(car);
                        break;
                    } 
                }
            }
        }

        // Going through each added car from each station and serving them
        public void ServeCars(LinkedListQueue<Car> CarsForServing)
        {
            while(CarsForServing.Size() > 0)
            {
                LeadToRightStation(CarsForServing.Dequeue());
            }
        }

    }
}