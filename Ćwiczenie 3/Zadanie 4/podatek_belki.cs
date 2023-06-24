using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj kwotę początkową na koncie oszczędnościowym:");
        decimal kwota = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
        decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        decimal kwotaZarobiona = ObliczKwoteZarobiona(kwota, oprocentowanie, liczbaMiesiecy);
        Console.WriteLine("Kwota zarobiona: " + kwotaZarobiona);
    }

    static decimal ObliczKwoteZarobiona(decimal kwota, decimal oprocentowanie, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = (1 + oprocentowanie / 100) / 12;
        decimal kwotaZarobiona = kwota * (decimal)Math.Pow((double)oprocentowanieMiesieczne, liczbaMiesiecy);
        decimal podatekBelki = kwotaZarobiona * 0.19m; // 19% podatku Belki
        kwotaZarobiona -= podatekBelki;
        return kwotaZarobiona;
    }
}
