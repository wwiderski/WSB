using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj podstawe:");
        int podstawa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wykladnik:");
        int wykladnik = Convert.ToInt32(Console.ReadLine());

        int wynik = Potegowanie(podstawa, wykladnik);
        Console.WriteLine("Wynik: " + wynik);
    }

    static int Potegowanie(int podstawa, int wykladnik)
    {
        int wynik = 1;
        for (int i = 0; i < wykladnik; i++)
        {
            wynik *= podstawa;
        }
        return wynik;
    }
}