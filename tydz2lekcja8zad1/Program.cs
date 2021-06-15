using System;

namespace tydz2lekcja8zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int div;
            for (int i = 2; i <= 100; i++)
            {
                div = 2;
                while (div < i && i % div != 0)
                {
                    div++;
                }
                if (i == div)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
