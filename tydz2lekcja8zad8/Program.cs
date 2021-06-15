using System;

namespace tydz2lekcja8zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst");
            string text = Console.ReadLine();
            Console.WriteLine("Po odwróceniu Twój tekst wygląda następująco");
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}
