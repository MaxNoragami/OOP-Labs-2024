using lab3.Task3;

namespace CarStationTest;

public class CarStationTest
{
    CarStation stationPeopleElectric = new CarStation(new PeopleDinner(), new ElectricStation(), new LinkedListQueue<Car>());
    CarStation stationRobotsElectric = new CarStation(new RobotsDinner(), new ElectricStation(), new CircularQueue<Car>(10));
    
    private CarStation stationPeopleGas;
    private SimpleQueue<Car> simpleQueue;

    public CarStationTest()
    {
        simpleQueue = new SimpleQueue<Car>();
        stationPeopleGas = new CarStation(new PeopleDinner(), new GasStation(), simpleQueue);
    }


    [Fact]
    public void AddingCarsToStationQueueTest()
    {   
        Car car1 = new Car(1, "GAS", "PEOPLE", true, 33);
        Car car2 = new Car(2, "GAS", "PEOPLE", false, 28);

        stationPeopleGas.AddCar(car1);
        stationPeopleGas.AddCar(car2);

        Assert.True(simpleQueue.Size() == 2);
    }

    [Fact]
    public void ServingCarsFromStationQueueTest()
    {
        stationPeopleGas.ServeCars();
        stationPeopleGas.ServeCars();

        Assert.True(simpleQueue.Size() == 0);
    }
}