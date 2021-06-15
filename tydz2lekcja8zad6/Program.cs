using System;

namespace tydz2lekcja8zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 1;
            double result = 0;
            while (i <= 20)
            {
                result += 1 / i;
                i++;
            }
            Console.WriteLine(result);
        }
    }
}
