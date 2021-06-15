using System;

namespace tydz2lekcja8zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę w systemie dziesiętnym");
            int dec = Int32.Parse(Console.ReadLine());
            string binRev = "";
            string bin = "";
            while (dec > 0)
            {
                binRev += dec % 2;
                dec /= 2;
            }
            for (int i = binRev.Length - 1; i >= 0; i--)
            {
                bin += binRev[i];
            }
            Console.WriteLine($"w systemie dwójkowym to:\n{bin}");
        }
    }
}
