using System;
  // 2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a} simvoludurmu ?
namespace Task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string word = "Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a} simvoludurmu ?";
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 1)
                {
                    countA++;
                    if (word[i] == 'a')
                    {
                        countB++;
                    }
                }
            }
            if (countA == countB)
            {
                Console.WriteLine("A-dir");
            }
            else
            {
                Console.WriteLine("A-Deyil");
            }
        }
    }
}

