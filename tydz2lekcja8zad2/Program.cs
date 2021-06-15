using System;

namespace tydz2lekcja8zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 1000);
        }
    }
}
