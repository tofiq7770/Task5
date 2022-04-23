using System;
//8) Verilmish metnde ilk qabagima cixan { a}  simvolundan sonra gelen simvolu 10 defe dalbadal cap et.
namespace Task5._8
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Metn Daxil Et:");
            string word = Console.ReadLine();
            word = word.ToLower();
            int index1 = word.IndexOf('a');
            int index2 = index1 + 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{word[index2]}");
            }
        }
    }
}
