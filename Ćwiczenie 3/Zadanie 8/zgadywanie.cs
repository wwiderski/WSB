using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wybierz liczbę z przedziału 1-20 i zapamiętaj ją.");

        int a = 1;
        int b = 20;
        int c;

        do
        {
            c = (a + b) / 2;

            Console.WriteLine("Czy Twoja liczba to " + c + "?");
            Console.WriteLine("wpisz 0, jeśli zgadłem.");

            int odpowiedz = Convert.ToInt32(Console.ReadLine());

            if (odpowiedz < 0)
            {
                a = c - 1;
            }
            else if (odpowiedz > 0)
            {
                b = c + 1;
            }
            else
            {
                Console.WriteLine("Hurra! Odgadłem Twoją liczbę.");
                break;
            }
        } while (true);
    }
}