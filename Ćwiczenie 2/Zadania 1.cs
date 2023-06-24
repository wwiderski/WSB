using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("podaj wartosc a:");
        a = inputValue();
        Console.WriteLine("podaj wartosc b:");
        b = inputValue();
        Console.WriteLine("podaj wartosc c:");
        c = inputValue();
        double sredniArytmetyczna;

        sredniArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("Srednia wynosi");
        Console.WriteLine(sredniArytmetyczna);
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
