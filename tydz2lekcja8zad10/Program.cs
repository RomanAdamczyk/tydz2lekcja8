using System;

namespace tydz2lekcja8zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int num2 = Int32.Parse(Console.ReadLine());
            int num1Tmp = num1;
            int num2Tmp = num2;
            while (num1Tmp != num2Tmp)
            {
                if (num1Tmp < num2Tmp)
                {
                    num1Tmp += num1;
                }
                else
                {
                    num2Tmp += num2;
                }
            }
            Console.WriteLine($"NWW({num1},{num2})={num2Tmp}");
        }

    }
}
