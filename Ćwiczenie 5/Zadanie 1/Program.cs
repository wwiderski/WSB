using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int liczba = 2; // Startujemy od pierwszej liczby pierwszej

        while (n > 0)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                n--;
            }
            liczba++;
        }
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}