using System;

struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}


struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public string Wykladowca;
    public int LiczbaGodzin;
}


struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string StopienNaukowy;
    public string Specjalizacja;
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.Kierunek = "Informatyka";

        Console.WriteLine("Student: {0} {1}", student.Imie, student.Nazwisko);
        Console.WriteLine("Numer indeksu: {0}", student.NumerIndeksu);
        Console.WriteLine("Kierunek: {0}", student.Kierunek);

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "INF101";
        przedmiot.Wykladowca = "dr. Nowak";
        przedmiot.LiczbaGodzin = 60;

        Console.WriteLine("Przedmiot: {0}", przedmiot.Nazwa);
        Console.WriteLine("Kod przedmiotu: {0}", przedmiot.Kod);
        Console.WriteLine("Wykładowca: {0}", przedmiot.Wykladowca);
        Console.WriteLine("Liczba godzin: {0}", przedmiot.LiczbaGodzin);

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.StopienNaukowy = "dr hab.";
        nauczyciel.Specjalizacja = "Inżynieria Oprogramowania";

        Console.WriteLine("Nauczyciel: {0} {1}", nauczyciel.Imie, nauczyciel.Nazwisko);
        Console.WriteLine("Stopień naukowy: {0}", nauczyciel.StopienNaukowy);
        Console.WriteLine("Specjalizacja: {0}", nauczyciel.Specjalizacja);
    }
}