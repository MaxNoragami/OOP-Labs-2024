using System.Net.Mail;
using Newtonsoft.Json;

namespace lab3.Src
{
    public static class ParseJson
    {
       private static Car? Deserialize(String jsonData)
       {    
            // Checking first if the provided string is a file location
            if(File.Exists(jsonData))
            {
                jsonData = File.ReadAllText(jsonData);
            }
            
            // Deserializing into Car obj
            Car? car = JsonConvert.DeserializeObject<Car>(jsonData);
            if(car != null) return car;
            return null;
       }

       public static void ToCar(LinkedListQueue<String> sourceJson, LinkedListQueue<Car> carsForServing)
       {
            // We deserialize the content of each json file
            while(sourceJson.Size() > 0)
            {
                if(sourceJson.Peek() != null)
                {
                    carsForServing.Enqueue(Deserialize(sourceJson.Dequeue()));
                }
            }
       }
    }
}