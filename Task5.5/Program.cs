using System;
// 5) Verilmish metnde sol terefden saydiqda { a},{ b},{ c}  simollarindan hansi birinci gelir?
namespace Task5._5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string word = " Verilmish metnde sol terefden saydiqda { a},{ b},{ c}  simollarindan hansi birinci gelir?";

            char[] herf = {'a', 'b', 'c'};

            int index = word.IndexOfAny(herf);

            Console.WriteLine($"Ilk gelen Simvol:{word[index]}");
            Console.WriteLine($"Indexi:{index + 1}");
        }
    }
}
