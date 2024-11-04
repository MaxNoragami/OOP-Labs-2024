using System.Dynamic;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using Lab3.Task4.Coffees;
using Lab3.Task4.Validation;
namespace Lab3.Task4
{
    public class Barista
    {
        // Fields
        private String baristaName;
        private List<Coffee> coffeeOrders = new List<Coffee>();

        // Properties
        public String BaristaName {get{return baristaName;}}

        // Methods

        // Requesting the coffee to be made
        public void RequestCoffee()
        {
            bool requestDone = false;
            List<string> input = new List<string>();
            Console.WriteLine("Hi there, I am {0}, your personal barista!", BaristaName);
            Thread.Sleep(1000);
            Console.WriteLine("What would you like to drink, today?");
            Thread.Sleep(500);

            // Gathering the details regarding which coffee types should be ordered
            do
            {
                Console.Write("\nEnter coffee type: ");
                string? tempInput = Console.ReadLine();
                if(tempInput != null)
                {
                    input.AddRange(Validator.FilterInput(tempInput));
                    Console.Write("\nCurrent request: ");
                    foreach(string s in input) Console.Write("<{0}> ", s);
                    Thread.Sleep(500);
                    Console.WriteLine("\nWould you like anything else? (y/N)");
                    string? addMore = Console.ReadLine();
                    if(addMore != null && (addMore.ToLower() == "yes" || addMore.ToLower() == "y")) continue;
                    requestDone = true;
                }
            } while(!requestDone); 

            // Making the desired coffee order  
            MakeOrder(input);
        }
        
        // Method that calls other methods from the coffee classes in orer to serve it to the customer
        private void MakeOrder(List<string> drinks)
        {   
            Intensity intensity;
            SyrupType syrupType;
            int mlOfMilk;
            int mlOfWater;
            int mgOfPumpkinSpice;
            Console.Clear();
            
            // Iterating over each request in order to and adding making the required coffee while adding it to a list of coffeeOrders
            for(int i = 0; i < drinks.Count; i++)
            {
                drinks[i] = drinks[i].ToLower();
                Console.WriteLine("\nCurrent drink: {0}", drinks[i]);
                Thread.Sleep(1000);
                // Determining the coffee type
                switch(drinks[i])
                {
                    case "cappuccino":
                    {
                        intensity = Validator.GetIntensity();
                        mlOfMilk = Validator.AddExtra("MILK", "ml");
                        Thread.Sleep(500);
                        coffeeOrders.Add(new Cappuccino(intensity, mlOfMilk).MakeCappuccino());
                        break;
                    }
                    case "americano":
                    {
                        intensity = Validator.GetIntensity();
                        mlOfWater = Validator.AddExtra("WATER", "ml");
                        Thread.Sleep(500);
                        coffeeOrders.Add(new Americano(intensity, mlOfWater).MakeAmericano());
                        break;
                    }
                    case "pumpkinspicelatte":
                    {
                        intensity = Validator.GetIntensity();
                        mlOfMilk = Validator.AddExtra("MILK", "ml");
                        mgOfPumpkinSpice = Validator.AddExtra("PUMPKIN SPICE", "mg");
                        Thread.Sleep(500);
                        coffeeOrders.Add(new PumpkinSpiceLatte(intensity, mlOfMilk, mgOfPumpkinSpice).MakePumpkinSpiceLatte());
                        break;
                    }
                    case "syrupcappuccino":
                    {
                        intensity = Validator.GetIntensity();
                        mlOfMilk = Validator.AddExtra("MILK", "ml");
                        syrupType = Validator.GetSyrup();
                        Thread.Sleep(500);
                        coffeeOrders.Add(new SyrupCappuccino(intensity, mlOfMilk, syrupType).MakeSyrupCappuccino());
                        break;
                    }
                    default:
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("Apologies, but we do not serve {0}, yet", drinks[i]);
                        break;
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        // Method for viewing the coffee orders 
        public void ViewOrderDetails()
        {
            if(coffeeOrders.Count != 0)
            {
                bool validInput = false;
                do
                {  
                    Console.WriteLine("Would you like to view your order's details? (Y/n)");
                    string? viewDetails = Console.ReadLine();
                    if(viewDetails != null && (viewDetails.ToLower() == "yes" || viewDetails.ToLower() == "y"))
                    {
                        Console.Clear();
                        // Printing the details of each coffee order
                        for(int i = 0; i < coffeeOrders.Count(); i++)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("\n{0}. Details of {1}", i + 1, coffeeOrders[i].CoffeeName);
                            coffeeOrders[i].PrintCoffeeDetails();
                        }
                        validInput = true;
                    }
                    else if(viewDetails == null || viewDetails.ToLower() == "no" || viewDetails.ToLower() == "n") break;
                } while(!validInput);
                Thread.Sleep(2000);
                Console.WriteLine("\nHere you go....");
                Thread.Sleep(1500);
                Console.WriteLine("\nEnjoy! :D");
            } 
            else
            {
                Console.WriteLine("No coffee orders have been requested!");
            }
        }

        // Constructor
        public Barista(String baristaName)
        {
            this.baristaName = baristaName;
        }
    }
}