using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetAdv.Ariel.GenericDelegate.Hw
{
    class Program
    {
        public static List<int> numbers = new List<int>() { 25, 31, 43 };
        public static Func<List<int>, int> FindSmalestNumber = small =>
        {
            return small.AsQueryable().Min();
        };
        public static Func<List<int>, int> FindAverage = avg =>
        {
            //return (int)Queryable.Average(avg.AsQueryable());
            return ((int)avg.Average());
            // this two ways work :)
        };
        public static Func<string, string> MiddelChar = mid =>
        {
            string emtza;
            if (mid.Length % 2 == 0)
            {
                emtza = (mid.Substring((mid.Length / 2) - 1, 2));
            }
            else
            {
                emtza = (mid[mid.Length / 2]).ToString();
            }
            return emtza;
        };
        public static Func<string, int> NumberOfVowels = vowels =>
        {
            int vowelsCount = 0;
            int vowelsLength = vowels.Length;
            for (int i = 0; i < vowelsLength; i++)
            {
                if (vowels[i] == 'a' || vowels[i] == 'e' || vowels[i] == 'i' || vowels[i] == 'o' || vowels[i] == 'u' ||
               vowels[i] == 'A' || vowels[i] == 'E' || vowels[i] == 'I' || vowels[i] == 'O' || vowels[i] == 'U')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        };
        public static Func<string, int> NumberOfWords = words =>
        {
            int wordsCount = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == ' ' || i == words.Length - 1)
                {
                    wordsCount++;
                }
            }
            return wordsCount;
        };
        public static Func<int, int> SumOfInt = sumInt =>
        {
            int sum = 0;

            while (sumInt != 0)
            {
                int rem;
                sumInt = Math.DivRem(sumInt, 10, out rem);
                sum += rem;
            }
            return sum;
        };
        public static Action<int> PentagonalNumber = pentagonOrder =>
        {
            int pentNumber;

            int counter = 0;
            for (int i = 1; i <= pentagonOrder; i++)
            {
                int n = (int)Math.Pow(i, 2);
                pentNumber = (3 * n - i) / 2;
                Console.Write(pentNumber + " ");
                counter++;
                if (counter % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        };

        static void Main(string[] args)
        {
            PentagonalNumber(50);
            Console.WriteLine(SumOfInt(12345));
            Console.WriteLine(NumberOfWords("hello Worrld and Ariel is"));
            Console.WriteLine(NumberOfVowels("w3resource"));
            Console.WriteLine(MiddelChar("arieln"));
            Console.WriteLine(FindSmalestNumber(numbers));
            Console.WriteLine(FindAverage(numbers));



        }
    }
}

