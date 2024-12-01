namespace lab3.Task4
{
    public class Car
    {
        public int Id {get; set;}
        public CarType Type {get; set;}
        public PassengersType Passengers {get; set;}
        public bool IsDining {get; set;}
        public int Consumption {get; set;}

        public Car(int id, string type, string passengers, bool isDining, int consumption)
        {
            Id = id;
            Type = (type == "ELECTRIC")? CarType.ELECTRIC : CarType.GAS;
            Passengers = (passengers == "ROBOTS")? PassengersType.ROBOTS : PassengersType.PEOPLE;
            IsDining = isDining;
            Consumption = consumption;
        }
    }
}