using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb o sumie " + n + ":");
        WypiszParyLiczb(n);
    }

    static void WypiszParyLiczb(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int drugaLiczba = n - i;
            Console.WriteLine(i + " + " + drugaLiczba);
        }
    }
}