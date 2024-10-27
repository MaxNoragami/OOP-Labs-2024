using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(String[] args)
        {
            if(args.Length > 0)
            {
                FileReader.ReadFileIntoString(args[0]);
            }
            else
            {
                Console.WriteLine("ERROR: No arguments were provided!");
            }

        }
    }
}