using System;

    
enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}


enum EtapyPrania
{
    WstepnePlukanie,
    Pranie,
    Plukanie,
    Wirowanie,
    Suszenie
}


enum Posilki
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}


enum BierkiSzachowe
{
    Pionek,
    Skoczek,
    Goniec,
    Wieza,
    Hetman,
    Krol
}

class Program
{
    static void Main()
    {
        DniTygodnia dzien = DniTygodnia.Wtorek;
        Console.WriteLine("Dzień tygodnia: " + dzien);

        EtapyPrania etap = EtapyPrania.Pranie;
        Console.WriteLine("Etap prania: " + etap);

        Posilki posilek = Posilki.Obiad;
        Console.WriteLine("Posiłek: " + posilek);

        BierkiSzachowe bierka = BierkiSzachowe.Skoczek;
        Console.WriteLine("Bierka szachowa: " + bierka);
    }
}