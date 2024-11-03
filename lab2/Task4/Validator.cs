using System.Text.RegularExpressions;

namespace Lab3.Task4.Validation
{
    static class Validator
    {
        static internal List<string> FilterInput(string input)
        {
            List<string> inputList = new List<string>();
            string[] inputArray = Regex.Split(input, @"[!\""#\$%&'()*+,-./:;?@\[\\\]^_`{|}~\s]+");
            foreach(string s in inputArray)
                if(!string.IsNullOrEmpty(s)) inputList.Add(s);
            return inputList;
        }

        static internal Intensity GetIntensity()
        {   
            while(true)
            {
                Console.Write("Set intensity (1. LIGHT, 2. NORMAL, 3. STRONG): ");
                string? intensityInput = Console.ReadLine();
                if(intensityInput != null)
                {   
                    int choice;
                    bool isInputInt = int.TryParse(intensityInput, out choice);
                    if(isInputInt)
                    {
                        switch(choice)
                        {
                            case 1:
                                return Intensity.LIGHT;
                            case 2:
                                return Intensity.NORMAL;
                            case 3:
                                return Intensity.STRONG;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        static internal SyrupType GetSyrup()
        {   
            while(true)
            {
                Console.Write("Set syrup type (1. MACADAMIA, 2. VANILLA, 3. COCONUT, 4. CARAMEL, 5. CHOCOLATE, 6. POPCORN): ");
                string? syrupInput = Console.ReadLine();
                if(syrupInput != null)
                {   
                    int choice;
                    bool isInputInt = int.TryParse(syrupInput, out choice);
                    if(isInputInt)
                    {
                        switch(choice)
                        {
                            case 1:
                                return SyrupType.MACADAMIA;
                            case 2:
                                return SyrupType.VANILLA;
                            case 3:
                                return SyrupType.COCONUT;
                            case 4:
                                return SyrupType.CARAMEL;
                            case 5:
                                return SyrupType.CHOCOLATE;
                            case 6:
                                return SyrupType.POPCORN;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        static internal int AddExtra(string type, string mUnit)
        {   bool isInputInt = false;
            int amount;
            do
            {
                Console.Write("Set amount of {0} to be added, in {1}: ", type, mUnit);
                string? input = Console.ReadLine();
                isInputInt = int.TryParse(input, out amount);
            } while(!isInputInt);
            return amount;
        }
    }
}