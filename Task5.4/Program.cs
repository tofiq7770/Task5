using System;
//4) Verilmish metnde sol terefden ilk rast gelinen { a} simvolunun yeri tek ededdi yoxsa cut ?
namespace Task5._4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string word = "Verilmish metnde sol terefden ilk rast gelinen { a} simvolunun yeri tek ededdi yoxsa cut ?";
            word = word.ToLower();
            int text = word.IndexOf('v');
            Console.WriteLine($"A simvolunun Yeri: {text+1}");

            if (text % 2 == 1)
            {
                Console.WriteLine("A-nin yeri Cut-dur");
            }
            else
            {
                Console.WriteLine("A-nin yeri Tek-dir");
            }
        }
    }
}
