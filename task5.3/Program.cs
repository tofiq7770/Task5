using System;
 //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}  -ye beraberdir.
namespace task5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}  -ye beraberdir.";
            char b = 'b';
            char[] ch = a.ToCharArray();
            int count = 0;
            for (int i = 1; i < ch.Length; i++)
            {
                if (i % 2 == 1)
                {
                    if (ch[i]==b)
                    {
                        Console.WriteLine($"{i}:{ch[i]}");
                        count++;
                    }
                    if (ch[i] != b)
                    {
                        Console.WriteLine($"{i} b deyil");
                    }
                }
            }
            Console.WriteLine($"{count} denesi b-dir");
        }
    }
}
