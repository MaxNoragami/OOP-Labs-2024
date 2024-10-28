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
            numberOfVowels = ExtractNumberOfVowels();
            numberOfConsonants = ExtractNumberOfConsonants();
            numberOfLetters = numberOfVowels + numberOfConsonants;
            numberOfSentences = ExtractNumberOfSentences();
            longestWord = ExtractLongestWord();
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

        private int ExtractNumberOfVowels()
        {   
            String? currentText = GetText();
            int vowels = 0;
            if(currentText != null)
            {
                currentText = currentText.ToLower();
                for(int i = 0; i < currentText.Length; i++)
                {
                    if("aeiou".Contains(currentText[i]))
                    {
                        vowels++;
                    }
                }
                return vowels;
            }
            return -1;
        }

        private int ExtractNumberOfConsonants()
        {
            String? currentText = GetText();
            int consonants = 0;
            if(currentText != null)
            {
                currentText = currentText.ToLower();
                for(int i = 0; i < currentText.Length; i++)
                {
                    if("bcdfghjklmnpqrstvwxyz".Contains(currentText[i]))
                    {
                        consonants++;
                    }
                }
                return consonants;
            }
            return -1;
        }

        private int ExtractNumberOfSentences()
        {
            String? currentText = GetText();
            if(currentText != null)
            {   
                currentText = currentText.Trim();
                String[] sentences = currentText.Split(new char[] {'.','!','?'});
                return sentences.Length - 1;
            }
            return -1;
        }

       private string? ExtractLongestWord()
        {
            string? currentText = GetText();
            char[] symbols = { '!', ',', '?', '\\', '\"', '#', '$', '%', '&', '\'', '(', '-', '\'', ')', '*', '+', '.', '/', ':', ';', '?', '@', '[', ']', '^', '`', '{', '|', '}', '~','\n' };

            if (currentText != null)
            {
                foreach (char symbol in symbols)
                {
                    currentText = currentText.Replace(symbol, ' ');
                }

                string[] words = currentText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string? largestWord = "";
                foreach (string word in words)
                {
                    if (word.Length > largestWord.Length)
                    {
                        largestWord = word;
                    }
                }
                return largestWord;
            }
            return null;
        }


    }
}