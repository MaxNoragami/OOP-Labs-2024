using lab3.Src;

namespace ServingTest;

public class ServingTest
{
    RobotsDiner robotDinner = new RobotsDiner();
    PeopleDiner peopleDinner = new PeopleDiner();
    ElectricStation electricStation = new ElectricStation();
    GasStation gasStation = new GasStation();

    [Fact]
    public void AmountDiningTest()
    {
        // Different entities dining
        robotDinner.ServeDiner(1);
        robotDinner.ServeDiner(2);
        robotDinner.ServeDiner(3);
        robotDinner.ServeDiner(4);
        peopleDinner.ServeDiner(5);
        peopleDinner.ServeDiner(6);

        int expectedAmountDining = 6;
        Assert.Equal(ServeData.AmountDining, expectedAmountDining);
        ServeData.ResetData();
    }

    [Fact]
    public void AmountNotDiningTest()
    {
        robotDinner.ServeDiner(1);
        ServeData.IncrementNotDining(); // Car 2 doesn't dine
        ServeData.IncrementNotDining(); // Car 3 doesn't dine
        ServeData.IncrementNotDining(); // Car 4 doesn't dine
        peopleDinner.ServeDiner(5);
        peopleDinner.ServeDiner(6);

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