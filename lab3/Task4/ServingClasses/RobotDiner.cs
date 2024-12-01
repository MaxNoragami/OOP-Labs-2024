namespace lab3.Task4
{
    public class RobotsDiner : IDineable
    {
        public void ServeDiner(int carId)
        {
            Console.WriteLine("Serving diner to ROBOTS from car {0}", carId);
            ServeData.IncrementDining();
        }
    }
}