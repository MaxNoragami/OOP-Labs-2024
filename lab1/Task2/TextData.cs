namespace Task2
{
    class TextData
    {
        // Private attributes definition
        private String? fileName;
        private String? text;
        private int numberOfVowels;
        private int numberOfConsonants;
        private int numberOfLetters;
        private int numberOfSentences;
        private String? longestWord;

        // Getters
        public String? GetFilename() {return fileName;}
        public String? GetText() {return text;}
        public int GetNumberOfVowels() {return numberOfVowels;}
        public int GetNumberOfConsonants() {return numberOfConsonants;}
        public int GetNumberOfLetters() {return numberOfLetters;}
        public int GetNumberOfSentences() {return numberOfSentences;}
        public String? GetLongestWord() {return longestWord;}

        // Constructor
        public TextData(String? path, String? text)
        {
            fileName = ExtractFilename(path);
            this.text = text;
            // numberOfVowels = ExtractNumberOfVowels();
            // numberOfConsonants = ExtractNumberOfConsonants();
            // numberOfLetters = ExtractNumberOfLetters();
            // numberOfSentences = ExtractNumberOfSentences();
            // longestWord = ExtractLongestWord();
        }

        // Parsing Logic
        private string? ExtractFilename(String? path)
        {
            String[] pathContent;

            if(path != null)
            {
                if(path.Contains("\\"))
                {
                    pathContent = path.Split("\\"); 
                }
                else if(path.Contains("/"))
                {
                    pathContent = path.Split("/");
                }
                else
                {
                    return path;
                }
                return pathContent[pathContent.Length - 1];
            }
            return null;
        }

        // private string? ExtractLongestWord()
        // {
        //     throw new NotImplementedException();
        // }

        // private int ExtractNumberOfSentences()
        // {
        //     throw new NotImplementedException();
        // }

        // private int ExtractNumberOfLetters()
        // {
        //     throw new NotImplementedException();
        // }

        // private int ExtractNumberOfConsonants()
        // {
        //     throw new NotImplementedException();
        // }

        // private int ExtractNumberOfVowels()
        // {
        //     throw new NotImplementedException();
        // }

        public override string ToString()
        {
            return string.Format("The file, {0}, ", GetFilename());
        }

    }
}