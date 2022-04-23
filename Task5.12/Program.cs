using System;
// 12) Verilmish metinde en ilk ve en son { a} simvolundan  bashqa yerde qalan butun { a}  simvollarini yox et.
namespace Task5._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Verilmish metinde en ilk ve en son {a} simvolundan  bashqa yerde qalan butun {a}  simvollarini yox et.";
            char a ='a';
            int first = text.IndexOf('a');
            int last = text.LastIndexOf('a');
            string s=string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == a && i != last && i != first) { 
                
                    continue;
                }
                    s += text[i];
                }
                Console.WriteLine(s);
            
        }
    }
}
