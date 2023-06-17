using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę wyrazów:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");
        for (int i = 0; i < n; i++)
        {
            int fib = a(i);
            Console.WriteLine(fib);
        }
    }

    static int a(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return a(n - 1) + a(n - 2);
        }
    }
}