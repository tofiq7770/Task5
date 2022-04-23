using System;

namespace test
{
    internal class Program
    {
        static string Main(string[] args)
        {
            string text = "youtube";

            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        //text = text.Replace("c", string.Empty);
        //                    Console.WriteLine(text);
    }
}
