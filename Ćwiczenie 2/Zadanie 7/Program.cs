using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędną x punktu P:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędną y punktu P:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj promień koła:");
        double r = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(x * x + y * y);

        if (distance <= r)
        {
            Console.WriteLine("Punkt leży w obrębie koła o promieniu.", x, y, r);
        }
        else
        {
            Console.WriteLine("Punkt nie leży w obrębie koła o promieniu.", x, y, r);
        }
    }
}