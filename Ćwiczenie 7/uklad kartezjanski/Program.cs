using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędne punktu początkowego:");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj współrzędne punktu końcowego:");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine(dlugoscOdcinka);
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        return dlugosc;
    }
}