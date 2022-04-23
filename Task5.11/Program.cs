using System;
 //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz.
namespace Task5._11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string text = "Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz.";

            char a = 'a';
            char b = 'b';
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==a)
                {
                text = text.Insert(i,b.ToString());
                    i++;
                }
                else if (text[i]==b)
                {

                    text = text.Insert(i, a.ToString());
                    i++;
                }
            }
                Console.WriteLine(text);
        }
    }
}
