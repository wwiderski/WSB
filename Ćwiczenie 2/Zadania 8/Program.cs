using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz numer działania: \n1. Dodawanie\n2. Odejmowanie\n3. Mnożenie\n4. Dzielenie");
        int numerDzialania = Convert.ToInt32(Console.ReadLine());

        double wynik = 0;

        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero. Wynik: {0}/0", liczba1);
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania.");
                return;
        }

        Console.WriteLine("Wynik: {0}", wynik);
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