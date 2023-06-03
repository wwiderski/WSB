using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h, bmi;
        Console.WriteLine("podaj wage:");
        w = inputValue();
        Console.WriteLine("podaj wzrost");
        h = inputValue();
        bmi = w / (h * h);
        Console.WriteLine("BMI wynosi");
        Console.WriteLine(bmi);
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
