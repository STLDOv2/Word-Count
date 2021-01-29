using System;

namespace Word_Count
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Console.Write("Write a sentence: ");

            string inputSentence = Console.ReadLine();

            Console.WriteLine(WordCounter(inputSentence));

            Console.ReadLine();

        }
        static string WordCounter(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return $"The word count is {Convert.ToString(wordCount)}";
        }
    }
}
