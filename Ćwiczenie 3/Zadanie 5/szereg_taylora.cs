using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wartość x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wyrazów:");
        int n = Convert.ToInt32(Console.ReadLine());

        double wynik = ObliczWartoscEksponenty(x, n);
        Console.WriteLine("Wynik: " + wynik);
    }

    static double ObliczWartoscEksponenty(double x, int n)
    {
        double wynik = 1.0;
        double wyraz = 1.0;

        for (int i = 1; i <= n; i++)
        {
            wyraz *= x / i;
            wynik += wyraz;
        }

        return wynik;
    }
}