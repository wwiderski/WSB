using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("podaj bok A");
        a = inputValue();
        Console.WriteLine("podaj bok B");
        b = inputValue();
        Console.WriteLine("podaj bok c");
        c = inputValue();
        if (a == b || a == c || b == c)
        {
            Console.WriteLine("trójkąt jest równoboczny");
        }
        else
        {
            Console.WriteLine("trójkąt nie jest równoboczny");
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
