using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(String[] args)
        {
            if(args.Length > 0)
            {
                foreach(String path in args)
                {
                    String? fileData = FileReader.ReadFileIntoString(path);
                    TextData textData = new TextData(path, fileData);
                    Console.WriteLine(textData.ToString());
                }
            }
            else
            {
                Console.WriteLine("ERROR: No arguments were provided!");
            }

        }
    }
}