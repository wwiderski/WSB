using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[4, 4];

        int a = 1;
        int b = 0;
        int c = 3;
        int d = 0;
        int e = 3;

        while (a <= 16)
        {
            for (int i = d; i <= e; i++)
            {
                tablica[b, i] = a;
                a++;
            }
            b++;

            for (int i = b; i <= c; i++)
            {
                tablica[i, e] = a;
                a++;
            }
            e--;

            for (int i = e; i >= d; i--)
            {
                tablica[c, i] = a;
                a++;
            }
            c--;

            for (int i = c; i >= b; i--)
            {
                tablica[i, d] = a;
                a++;
            }
            d++;
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}