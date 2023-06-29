using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę sekund od północy: ");
        int liczbaSekund = int.Parse(Console.ReadLine());

        string sformatowanyCzas = ZapiszCzas(liczbaSekund);
        Console.WriteLine(sformatowanyCzas);
    }

    static string ZapiszCzas(int liczbaSekund)
    {
        int godziny = liczbaSekund / 3600;
        int minuty = (liczbaSekund % 3600) / 60;
        int sekundy = liczbaSekund % 60;

        string sGodziny = $"{godziny:D2}";
        string sMinuty = $"{minuty:D2}";
        string sSekundy = $"{sekundy:D2}";

        string sformatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return sformatowanyCzas;
    }
}