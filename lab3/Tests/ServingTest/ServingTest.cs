using lab3.Task2;
namespace ServingTest;

public class ServingTest
{
    RobotsDinner robotDinner = new RobotsDinner();
    PeopleDinner peopleDinner = new PeopleDinner();
    ElectricStation electricStation = new ElectricStation();
    GasStation gasStation = new GasStation();

    [Fact]
    public void ServingRobotsTest()
    {
        robotDinner.ServeDinner(1);
        robotDinner.ServeDinner(2);
        robotDinner.ServeDinner(3);
        robotDinner.ServeDinner(4);

        int expectedAmountRobots = 4;
        Assert.Equal(ServeData.AmountRobots, expectedAmountRobots);
        ServeData.ResetData();
    }

    [Fact]
    public void ServingHumansTest()
    {
        peopleDinner.ServeDinner(5);
        peopleDinner.ServeDinner(6);
        peopleDinner.ServeDinner(7);
        peopleDinner.ServeDinner(8);
        
        int expectedAmountPeople = 4;
        Assert.Equal(ServeData.AmountPeople, expectedAmountPeople);
        ServeData.ResetData();
    }

    [Fact]
    public void AmountDiningTest()
    {
        // Different entities dining
        robotDinner.ServeDinner(1);
        robotDinner.ServeDinner(2);
        robotDinner.ServeDinner(3);
        robotDinner.ServeDinner(4);
        peopleDinner.ServeDinner(5);
        peopleDinner.ServeDinner(6);

        int expectedAmountDining = 6;
        Assert.Equal(ServeData.AmountDining, expectedAmountDining);
        ServeData.ResetData();
    }

    [Fact]
    public void AmountNotDiningTest()
    {
        robotDinner.ServeDinner(1);
        ServeData.IncrementNotDining(); // Car 2 doesn't dine
        ServeData.IncrementNotDining(); // Car 3 doesn't dine
        ServeData.IncrementNotDining(); // Car 4 doesn't dine
        peopleDinner.ServeDinner(5);
        peopleDinner.ServeDinner(6);

        int expectedAmountNotDining = 3;
        Assert.Equal(ServeData.AmountDining, expectedAmountNotDining);
        ServeData.ResetData();
    }

    [Fact]
    public void RefuelingElectricCarsTest()
    {
        electricStation.Refuel(1);
        electricStation.Refuel(2);
        electricStation.Refuel(3);
        electricStation.Refuel(4);

        int expectedElectricCars = 4;
        Assert.Equal(ServeData.ElectricCars, expectedElectricCars);
    }

    [Fact]
    public void RefuelingGasCarsTest()
    {
        gasStation.Refuel(5);
        gasStation.Refuel(6);
        gasStation.Refuel(7);
        gasStation.Refuel(8);

        int expectedGasCars = 4;
        Assert.Equal(ServeData.GasCars, expectedGasCars);
    }

    [Fact]
    public void ConsumptionGasCarsTest()
    {
        ServeData.IncrementGasConsumption(10);
        ServeData.IncrementGasConsumption(10);
        ServeData.IncrementGasConsumption(10);

        int expectedGasConsumption = 30;
        Assert.Equal(ServeData.GasConsumption, expectedGasConsumption);
    }

    [Fact]
    public void ConsumptionElectricCarsTest()
    {
        ServeData.IncrementElectricConsumption(10);
        ServeData.IncrementElectricConsumption(10);
        ServeData.IncrementElectricConsumption(10);

        int expectedElectricConsumption = 30;
        Assert.Equal(ServeData.ElectricConsumption, expectedElectricConsumption);
    }
}