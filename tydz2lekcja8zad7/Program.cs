using System;

namespace tydz2lekcja8zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość przekątnej diamentu");
            int len = Int32.Parse(Console.ReadLine());
            int kind;
            if (len % 2 == 0)
            {
                kind = 2;
            }
            else
            {
                kind = 1;
            }
            for (int i = 0; i <= (len - 1) / 2; i++)
            {
                for (int j = len/2; j<= len - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i + kind; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = (len - 1)/2 - 1; i >= 0; i--)
            {
                for (int j = len - i - 1; j >= len/2; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 2*i + kind - 1; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
