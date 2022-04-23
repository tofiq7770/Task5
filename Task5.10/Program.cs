using System;
using System.Text.RegularExpressions;
//10) Verilmish metinde butun reqemleri legv et. 
namespace Task5._10
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Metn Daxil Et:");
            string word = Console.ReadLine();
            word = word.ToLower();

            word = Regex.Replace(word, @"[\d]", string.Empty);

            Console.WriteLine(word);
        }
    }
}
