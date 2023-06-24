using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int h = int.Parse(Console.ReadLine());

        int r = h * 2 - 1;
        int s = r / 2;
        int plus = 1;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < s; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < plus; j++)
            {
                Console.Write("+");
            }

            Console.WriteLine();

            s--;
            plus += 2;
        }
    }
}