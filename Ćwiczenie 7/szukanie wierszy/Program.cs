using System;

class Program
{
    static void Main()
    {
        int[,] tablica = {
            { 1, 2, 3, 4 },
            { 4, 2, 3, 1 },
            { 2, 3, 1, 4 },
            { 3, 1, 4, 2 }
        };

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);
        Console.WriteLine("Najbardziej zbliżone wiersze: {0} i {1}", najblizszeWiersze[0], najblizszeWiersze[1]);
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int liczbaWierszy = tablica.GetLength(0);
        int[,] roznicoweMiary = new int[liczbaWierszy, liczbaWierszy];

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                roznicoweMiary[i, j] = ObliczRoznicoweMiar(tablica, i, j);
            }
        }

        int najmniejszaRoznica = int.MaxValue;
        int[] najblizszeWiersze = new int[2];

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                if (roznicoweMiary[i, j] < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznicoweMiary[i, j];
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }

    static int ObliczRoznicoweMiar(int[,] tablica, int i, int j)
    {
        int liczbaKolumn = tablica.GetLength(1);
        int roznica = 0;

        for (int k = 0; k < liczbaKolumn; k++)
        {
            int aik = tablica[i, k];
            int ajk = tablica[j, k];
            roznica += (aik - ajk) * (aik - ajk);
        }

        return roznica;
    }
}