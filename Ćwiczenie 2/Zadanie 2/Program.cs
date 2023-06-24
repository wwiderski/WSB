using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double o, p, r;
        var pi = Math.PI;
        Console.WriteLine("podaj pole kola:");
        p = inputValue();
        r = Math.Sqrt(p / pi);
        o = 2 * pi * r;
        Console.WriteLine("obwod kola wynosi:");
        Console.WriteLine(o);
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

