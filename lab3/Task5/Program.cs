namespace lab3.Task5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task5 Running.....");

            List<CarStation> carStations = new List<CarStation>()
                {
                    new CarStation(new PeopleDiner(), new GasStation(), new CircularQueue<Car>(10)),
                    new CarStation(new RobotsDiner(), new GasStation(), new CircularQueue<Car>(10)),
                    new CarStation(new PeopleDiner(), new ElectricStation(), new CircularQueue<Car>(10)),
                    new CarStation(new RobotsDiner(), new ElectricStation(), new CircularQueue<Car>(10))
                };
            
            Semaphore semaphore = new Semaphore(carStations);

            LinkedListQueue<Car> carQueue = new LinkedListQueue<Car>();

            Thread thread1 = new Thread(() => AddingCarsToRightStation(carQueue, semaphore));
            Thread thread2 = new Thread(() => ServingTheCarsFromStations(carStations));

            thread1.Start();
            thread2.Start();
        }

        private static void AddingCarsToRightStation(LinkedListQueue<Car> carQueue, Semaphore semaphore)
        {
            string[] files = Directory.GetFiles("../../../../JSON/queue/", "*.json");
            foreach(var file in files)
            {
                LinkedListQueue<String> jsonData = new LinkedListQueue<string>();
                jsonData.Enqueue(file);
                ParseJson.ToCar(jsonData, carQueue);
                File.Delete(file);

                Thread.Sleep(2000);
                semaphore.ServeCars(carQueue);
            }
        }

        private static void ServingTheCarsFromStations(List<CarStation> carStations)
        {   
            bool areCarsEnqueued = true;

            while(areCarsEnqueued)
            {   
                int emptyStations = 0;
                
                Thread.Sleep(9000);
                
                bool firstCarsToServeExist = true;
                foreach(var station in carStations)
                {
                    if(station.IsEmpty())
                    {
                        emptyStations++;
                        continue;
                    }
                    if(firstCarsToServeExist) 
                    {
                        Console.WriteLine("\n------ Serving Cars at the station ------");
                        firstCarsToServeExist = false;
                    }
                    
                    station.ServeCars();
                }
                
                if(emptyStations == carStations.Count) break;

                Console.WriteLine("\n-----------------------------------------\n");
            }
            
            Console.WriteLine("\nAll cars have been served successfully!");
            Thread.Sleep(1000);
            ServeData.Overview();
        }
    }
}