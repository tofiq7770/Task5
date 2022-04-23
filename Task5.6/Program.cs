using System;
//6) Verilmish metnde { a}  simvolunun sol terefden ve sag terefden indexleri eydidirmi?
namespace Task5._6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("text Daxil Et:");
            string text = Console.ReadLine();

            string Newtext = "";

            int index = text.IndexOf('a');

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Newtext = Newtext + text[i];
            }

            int index2 = Newtext.IndexOf('a');


            if (index == index2)
            {
                Console.WriteLine("Indexler Iki Terefdende Eynidir");
            }
            else
            {
                Console.WriteLine("Indexler Iki Terefdende Eyni Deyildir");
            }
        }
    }
}
