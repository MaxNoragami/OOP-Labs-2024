namespace lab3.Task5
{
    public class PeopleDiner : IDineable
    {
        public void ServeDiner(int carId)
        {
            Console.WriteLine("Serving diner to PEOPLE from car {0}", carId);
            ServeData.IncrementDining();
        }
    }
}