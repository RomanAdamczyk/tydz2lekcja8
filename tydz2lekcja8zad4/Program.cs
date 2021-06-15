using System;

namespace tydz2lekcja8zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ile liczb chcesz wyświetlić?");
            int num = Int32.Parse(Console.ReadLine());
            int row = 1;
            int col = 1;
            int i = 1;
            while(num > 0)
            {
                while (col <= row && num > 0)
                {
                    Console.Write($"{i} ");
                    i++;
                    num--;
                    col++;
                }
                col = 1;
                row++;
                Console.WriteLine();
            }
        }
    }
}
