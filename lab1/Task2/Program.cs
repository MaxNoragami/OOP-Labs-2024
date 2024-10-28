using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(String[] args)
        {
            if(args.Length > 0)
            {
                String? fileData = FileReader.ReadFileIntoString(args[0]);
                TextData textData = new TextData(args[0], fileData);
                Console.WriteLine("The file, {0}, contains in total {1} vowels and {2} consonants, so in total {3} letters. Moreover, out of {4} available sentences, '{5}' is the longest word",  
                    textData.GetFilename(), textData.GetNumberOfVowels(), textData.GetNumberOfConsonants(), textData.GetNumberOfLetters(), textData.GetNumberOfSentences(), textData.GetLongestWord());
            }
            else
            {
                Console.WriteLine("ERROR: No arguments were provided!");
            }

        }
    }
}