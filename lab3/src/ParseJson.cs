using System.Net.Mail;
using Newtonsoft.Json;

namespace lab3.Src
{
    public static class ParseJson
    {
       private static Car? Deserialize(String jsonData)
       {
            if(File.Exists(jsonData))
            {
                jsonData = File.ReadAllText(jsonData);
            }
            Car? car = JsonConvert.DeserializeObject<Car>(jsonData);
            if(car != null) return car;
            return null;
       }

       public static void ToCar(LinkedListQueue<String> sourceJson, LinkedListQueue<Car> carsForServing)
       {
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