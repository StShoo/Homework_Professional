namespace Homework_P_1_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new WordsCollection();
            words[0] = new WordsData("морква", "carrot");
            words[1] = new WordsData("жовтавий", "yellowi");
            words[2] = new WordsData("оселя", "home");
            words[3] = new WordsData("сусід", "neighbor");
            words[4] = new WordsData("пес", "dog");
            words[5] = new WordsData("гора", "mountin");
            words[6] = new WordsData("предмет", "item");

            foreach (WordsData word in words)
            {
                Console.WriteLine($"UA: {word.WordUa}, Eng: {word.WordEng}");
            }

            string wordToFind = Console.ReadLine();
            bool foundFlag = false;

            foreach (WordsData word in words)
            {
                if (word.WordUa.Equals(wordToFind))
                {
                    Console.WriteLine($"Translation for {wordToFind} is {word.WordEng}");
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                Console.WriteLine("Translation wasnt found");
            }
        }
    }
}