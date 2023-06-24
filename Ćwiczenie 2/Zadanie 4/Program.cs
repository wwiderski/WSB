using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d, x, y;

        Console.WriteLine("podaj A");
        a = inputValue();
        Console.WriteLine("Podaj b");
        b = inputValue();
        Console.WriteLine("Podaj C");
        c = inputValue();
        Console.WriteLine("podaj D");
        d = inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("brak rozwiązań");
        }
        else
        {
            y = b * d;
            x = a * d + b * c;

            Console.WriteLine("Licznik: " + x);
            Console.WriteLine("mianownik: " + y);

        }
    }
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
