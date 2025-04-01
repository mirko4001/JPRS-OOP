namespace Aufgabe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kreis k = new Kreis(10);
            Dreieck d = new Dreieck(15, 10, 4, 8);
            Rechteck r = new Rechteck(2, 5);

            Console.WriteLine(Geometrie.BerechneKreisFläche(k.Radius));
            Console.WriteLine(Geometrie.BerechneKreisUmfang(k.Radius));

            Console.WriteLine(Geometrie.BerechneDreieckFläche(d.Höhe1, d.Seite1));
            Console.WriteLine(Geometrie.BerechneDreieckUmfang(d.Seite1, d.Seite2, d.Seite3));

            Console.WriteLine(Geometrie.BerechneRechteckFläche(r.Länge, r.Breite));
            Console.WriteLine(Geometrie.BerechneRechteckUmfang(r.Länge, r.Breite));
        }
    }
}