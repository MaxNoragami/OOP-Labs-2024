using lab3.Src;
namespace SemaphoreTest;

public class SemaphoreTest
{
    CarStation stationGasPeople = new CarStation(new PeopleDiner(), new GasStation(), new CircularQueue<Car>(10));
    CarStation stationGasRobots = new CarStation(new RobotsDiner(), new GasStation(), new CircularQueue<Car>(10));
    CarStation stationElectricPeople = new CarStation(new PeopleDiner(), new ElectricStation(), new CircularQueue<Car>(10));
    CarStation stationElectricRobots = new CarStation(new RobotsDiner(), new ElectricStation(), new CircularQueue<Car>(10));

    String jsonCar1 = """
                {
                "id": 1,
                "type": "GAS",
                "passengers": "PEOPLE", 
                "isDining": false, 
                "consumption": 17
                }
            """;

    String jsonCar2 = """
                {
                "id": 2, 
                "type": "ELECTRIC",
                "passengers": "PEOPLE", 
                "isDining": true, 
                "consumption": 35
                }
            """;

    String jsonCar3 = """
                {
                "id": 3, 
                "type": "GAS", 
                "passengers": "PEOPLE", 
                "isDining": false, 
                "consumption": 48
                }
            """;
        
    String jsonCar4 = """
                {
                "id": 4, 
                "type": "GAS", 
                "passengers": "ROBOTS", 
                "isDining": true, 
                "consumption": 33
                }
            """;

    [Fact]
    public void ParsingJsonToCarObjTest()
    {
        LinkedListQueue<Car> carQueueTest = new LinkedListQueue<Car>();
        LinkedListQueue<String> jsonData = new LinkedListQueue<String>();
        jsonData.Enqueue(jsonCar1);
        jsonData.Enqueue(jsonCar2);
        jsonData.Enqueue(jsonCar3);
        jsonData.Enqueue(jsonCar4);

        ParseJson.ToCar(jsonData, carQueueTest);

        LinkedListQueue<Car> carQueueExpected = new LinkedListQueue<Car>();
        carQueueExpected.Enqueue(new Car(1, "GAS", "PEOPLE", false, 17));
        carQueueExpected.Enqueue(new Car(2, "ELECTRIC", "PEOPLE", true, 35));
        carQueueExpected.Enqueue(new Car(3, "GAS", "PEOPLE", false, 48));
        carQueueExpected.Enqueue(new Car(4, "GAS", "ROBOTS", true, 33));

        while(carQueueTest.Size() > 0) 
        {   
            Car dequeuedTest = carQueueTest.Dequeue();
            Car expectedCar = carQueueExpected.Dequeue();

            Assert.Equal(expectedCar.Id, dequeuedTest.Id);
            Assert.Equal(expectedCar.Type, dequeuedTest.Type);
            Assert.Equal(expectedCar.Passengers, dequeuedTest.Passengers);
            Assert.Equal(expectedCar.IsDining, dequeuedTest.IsDining);
            Assert.Equal(expectedCar.Consumption, dequeuedTest.Consumption);
        }
    }

    [Fact]
    public void SemaphoreServingCarsTest()
    {
        List<CarStation> carStations = new List<CarStation>(){stationElectricPeople, stationElectricRobots, stationGasPeople, stationGasRobots};
        lab3.Src.Semaphore semaphore = new lab3.Src.Semaphore(carStations);
        
        LinkedListQueue<Car> carQueueTest = new LinkedListQueue<Car>();
        LinkedListQueue<String> jsonData = new LinkedListQueue<String>();
        jsonData.Enqueue(jsonCar1);
        jsonData.Enqueue(jsonCar2);
        jsonData.Enqueue(jsonCar3);
        jsonData.Enqueue(jsonCar4);

        ParseJson.ToCar(jsonData, carQueueTest);

        semaphore.ServeCars(carQueueTest);

        int expectedGasCars = 3;
        int expectedElectricCars = 1;
        int expectedRobots = 1;
        int expectedPeople = 3;
        int expectedDining = 2;
        int expectedNotDining = 2;
        int expectedElectricConsumption = 35;
        int expectedGasConsumption = 98;

        foreach(var station in carStations)
        {
            station.ServeCars();
        }

        Assert.Equal(ServeData.GasCars, expectedGasCars);
        Assert.Equal(ServeData.ElectricCars, expectedElectricCars);
        Assert.Equal(ServeData.AmountRobots, expectedRobots);
        Assert.Equal(ServeData.AmountPeople, expectedPeople);
        Assert.Equal(ServeData.AmountDining, expectedDining);
        Assert.Equal(ServeData.AmountNotDining, expectedNotDining);
        Assert.Equal(ServeData.GasConsumption, expectedGasConsumption);
        Assert.Equal(ServeData.ElectricConsumption, expectedElectricConsumption);
        
    }
}