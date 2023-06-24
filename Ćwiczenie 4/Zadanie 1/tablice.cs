using System;

class Program
{
    static void Main()
    {
        int rozmiar_tablicy = 10;
        int[] tablica = new int[rozmiar_tablicy];
        Random random = new Random();

      
        for (int i = 0; i < rozmiar_tablicy; i++)
        {
            tablica[i] = random.Next(100); 
        }

       
        for (int i = rozmiar_tablicy - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }


        int najmniejszy = tablica[0];
        int największy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }

            if (tablica[i] > największy)
            {
                największy = tablica[i];
            }
        }

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + największy);




        int n = tablica.Length;
        bool zamiana;
        do
        {
            zamiana = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    int temp = tablica[i];
                    tablica[i] = tablica[i + 1];
                    tablica[i + 1] = temp;
                    zamiana = true;
                }
            }

            n--;
        } while (zamiana);

        Console.WriteLine("Posortowana tablica:");

        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine(tablica[i]);
        }
    }


}

