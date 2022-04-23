using System;
//9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
namespace Task5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?";
            string sub1 = text.Substring(0, 3);
            string sub2 = text.Substring(text.Length - 3, 3);
            char[] chars = sub2.ToCharArray();
            Array.Reverse(chars);
            string revsub2 = string.Join("", chars);
            if (revsub2 == sub1)
            {
                Console.WriteLine("eynidir");
            }
            else
            {
                Console.WriteLine("eyni deyil");
            }
        }
    }
}
