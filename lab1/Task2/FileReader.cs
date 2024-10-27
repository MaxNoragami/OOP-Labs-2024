using System.IO;

namespace Task2
{
    static class FileReader
    {
        public static String? ReadFileIntoString(String? path)
        {
            if(path != null)
            {
                if(File.Exists(path))
                {
                    return File.ReadAllText(path);
                }
                else
                {
                    Console.WriteLine("WARNING: File at {0}, couldn't be found!", path);
                }
            }
            else
            {
                Console.WriteLine("WARNING: No path was provided!");
            }
            return null;
        }

    }
}