namespace lab3.Task3
{
    public class RobotsDinner : IDineable
    {
        public void ServeDinner(int carId)
        {
            Console.WriteLine("Serving diner to ROBOTS from car {0}", carId);
            ServeData.IncrementDining();
            ServeData.IncrementRobotsAmount();
        }
    }
}