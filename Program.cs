using System;
using System.Linq;

namespace ProgrammingTest
{
    class Program
    {
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        static void PrintPhrase(string[] words)
        {
            var sentence = string.Concat(words);
            Console.WriteLine($"Phase: {sentence} ");
        }

        static int CountOccurences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }


        static void Main(string[] args)
        {

            string lineSentences = "LINE MELODY procides ringtones, ringback tones for LINE Call colorize your LINE Call experience and express your feelings through LINE MELODY";

            int countOccurences = CountOccurences(lineSentences, "LINE MELODY");
            Console.WriteLine($"Count LINE MELODY: {countOccurences} ");

            int sumWords = CountOccurences(lineSentences, "LINE") + CountOccurences(lineSentences, "Call");
            Console.WriteLine($"Sum of LINE and Call: {sumWords} ");

            string[] words = { "express", "your", "feelings" };
            PrintPhrase(words);

            string[] wordString = lineSentences.Split(' ');
   
            foreach (var word in wordString)
            {
                string text = ReverseString(word);
                Console.Write($"{text}");
            }
            

        }
    }
}
