using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        int a;
        int b = 0;
        int c = 0;

        Console.Write("Wylosowane liczby parzyste (wersja 2): ");

        while (c < n)
        {
            a = random.Next(-4, 5) * 2;

            Console.Write(a);

            c++;
            b++;

            if (c < n)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ilość rzeczywistych losowań: " + b);
    }
}