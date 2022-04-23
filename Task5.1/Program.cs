using System;
//Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?
namespace Task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            double counta = 0;
            double countb = 0;
            string text="Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?";
            char b = 'a';
            char c = 'b';
            foreach (var item in text)
            {
                if (item == b)
                {
                    counta++;
                }
            }
            Console.Write("a-sayi: ");
            Console.WriteLine(counta);
            foreach (var item in text)
            {
                if (item == c)
                {
                    countb++;
                }
            }
            Console.Write("b-sayi: ");
            Console.WriteLine(countb);
            Console.Write("a/b: ");
            Console.WriteLine(counta/countb);
        }
    }
}
