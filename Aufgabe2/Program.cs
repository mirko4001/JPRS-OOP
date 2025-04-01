namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BodyMassIndex bmi1 = new BodyMassIndex(1.76, 70);
            Console.WriteLine(Math.Round(bmi1.Berechnung(),2)) ;
        }
    }
}