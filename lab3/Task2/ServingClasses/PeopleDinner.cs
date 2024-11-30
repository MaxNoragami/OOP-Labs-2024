namespace lab3.Task2
{
    public class PeopleDinner : IDineable
    {
        public void ServeDinner(int carId)
        {
            Console.WriteLine("Serving diner to PEOPLE from car {0}", carId);
            ServeData.IncrementDining();
            ServeData.IncrementPeopleAmount();
        }
    }
}