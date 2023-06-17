using System;

class Program
{
    static void Main(string[] args)
    {
        int n, k;

        do
        {
            Console.WriteLine("Podaj liczbę n (większą od 5):");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.WriteLine("Podaj liczbę k (większa od 5):");
            k = Convert.ToInt32(Console.ReadLine());
        } while (k < 5);

        int m = ObliczWartosc(n, k);
        Console.WriteLine("Wynik: " + m);
    }

    static int ObliczWartosc(int n, int k)
    {
        int nSilnia = Silnia(n);
        int kSilnia = Silnia(k);
        int wynik = (nSilnia - kSilnia) / kSilnia;
        return wynik;
    }

    static int Silnia(int x)
    {
        int wynik = 1;
        for (int i = 2; i <= x; i++)
        {
            wynik *= i;
        }
        return wynik;
    }
}