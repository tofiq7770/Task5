using System;
using System.Linq;
/* 15)*Verilmish metinde ilk ve son simvol eynidirse, ve metn daxilinde yanashi gelen { a} simvolu varsa,
ve metn daxilinde { b} simvolu yoxdursa o zaman bu metnde butun { c} simvollari yox et ve
neticede alinan metn zerkalni olub olmadigini yoxla.*/

namespace _Task5._15
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "saaccccccccclaas";
            char a = 'a';
            char b = 'b';
            int indexc = text.IndexOf('c');
            string first = text.Substring(0, 1);
            string last= text.Substring(text.Length-1);
            string empty = "";
            string text1 = "";
            if (first == last)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == a && text[i + 1] == a && text[i] != b)
                    {
                        text1 = text.Replace("c", string.Empty);
                        Console.WriteLine(text);
                        for (int j = text1.Length - 1; j >= 0; j--)
                        {
                            empty = empty + text[i];
                        }

                        if (text1 == empty)
                        {
                            Console.WriteLine("Zerkalni");
                        }
                        else
                        {
                            Console.WriteLine("Zerkalni deyil");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ilk ve son simvol eyni deyil");
            }
        }
        
       
    }
}
