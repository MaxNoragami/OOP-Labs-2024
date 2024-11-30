namespace lab3.Task3
{
    public static class ServeData
    {
        public static int GasCars { get; private set; }
        public static int ElectricCars { get; private set; }
        public static int GasConsumption { get; private set; }
        public static int ElectricConsumption { get; private set; }
        public static int AmountDining { get; private set; }
        public static int AmountNotDining { get; private set; }
        public static int AmountRobots { get; private set; }
        public static int AmountPeople { get; private set; }

        public static void IncrementGasCars() => GasCars++;
        public static void IncrementElectricCars() => ElectricCars++;
        public static void IncrementGasConsumption(int consumption) => GasConsumption += consumption;
        public static void IncrementElectricConsumption(int consumption) => ElectricConsumption += consumption;
        public static void IncrementDining() => AmountDining++;
        public static void IncrementNotDining() => AmountNotDining++;
        public static void IncrementRobotsAmount() => AmountRobots++;
        public static void IncrementPeopleAmount() => AmountPeople++;

        public static void ResetData()
        {
            GasCars = 0;
            ElectricCars = 0;
            GasConsumption = 0;
            ElectricConsumption = 0;
            AmountDining = 0;
            AmountNotDining = 0;
            AmountRobots = 0;
            AmountPeople = 0;
        }
    }
}