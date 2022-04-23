using System;
 // 13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.
namespace Task5._13
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            string text = "Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et";
            for (int i = 0; i < text.Length ; i++)
            {
                if (i % 2 == 0)
                {
                    text = text.Insert(i , text[i].ToString().ToUpper());
                }
            }
            Console.WriteLine(text);
        }
    }
}
