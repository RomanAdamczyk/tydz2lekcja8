using System;

namespace tydz2lekcja8zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile wyrazów ciągu wypisać");
            int num = Int32.Parse(Console.ReadLine());
            if (num < 1)
            {
                Console.WriteLine("za mała liczba");
            }
            else if (num == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                long a = 1;
                long b = 1;
                long c ;
                Console.WriteLine(1);
                Console.WriteLine(1);
                while (num > 2)
                {
                    c = a + b;
                    Console.WriteLine(c);
                    a = b;
                    b = c;
                    num--;
                }
            }
        }
    }
}
