using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar;

        while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar < 1)
        {
            Console.WriteLine("Niepoprawny rozmiar tablicy. Podaj liczbę dodatnią.");
            Console.Write("Podaj rozmiar tablicy: ");
        }

        int[,] tablica = new int[rozmiar, rozmiar];

        int liczba = 1;
        int dol = 0;
        int gora = rozmiar - 1;
        int lewo = 0;
        int prawo = rozmiar - 1;

        while (liczba <= rozmiar * rozmiar)
        {
            for (int i = lewo; i <= prawo; i++)
            {
                tablica[dol, i] = liczba;
                liczba++;
            }
            dol++;

            for (int i = dol; i <= gora; i++)
            {
                tablica[i, prawo] = liczba;
                liczba++;
            }
            prawo--;

            for (int i = prawo; i >= lewo; i--)
            {
                tablica[gora, i] = liczba;
                liczba++;
            }
            gora--;

            for (int i = gora; i >= dol; i--)
            {
                tablica[i, lewo] = liczba;
                liczba++;
            }
            lewo++;
        }

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}