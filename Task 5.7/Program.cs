using System;
// 7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?
namespace Task_5._7
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Text Daxil Et(abc olsun):");
            string word = Console.ReadLine();

            int index1 = word.IndexOf('a');
            int index2 = word.IndexOf('b');
            int index3 = word.IndexOf('c');

            if (index1 < index2 && index2 < index3)
            {
                Console.WriteLine("A Simvolu B-den, B Simvolu Ise C-den Evvel Gelir");
            }
            else
            {
                Console.WriteLine("A Simvolu B-den, B Simvolu Ise C-den Evvel Gelmir");
            }
        }
    }
}
