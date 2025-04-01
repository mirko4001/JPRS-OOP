namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fachbuch f1 = new Fachbuch("Mathe für Wissenschaftler", "Don Pollo", 350, "Lalalala");
            Freizeitbuch fz1 = new Freizeitbuch("Das magische Baumhaus", 130, true, "Johannes Broski", "Thriller");
            Film film1 = new Film("The Flash", "Action", 143, 8.3);
        }
    }
}