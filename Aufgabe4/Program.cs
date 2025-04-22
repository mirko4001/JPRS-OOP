namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Kunde kunde1 = new Kunde("Yazan Hashoum", "0001");
            Kunde kunde2 = new Kunde("Alex Lalala", "4171", 100);

            Console.WriteLine(kunde1.ToString());
            Console.WriteLine();
            Console.WriteLine(kunde2.ToString());

            kunde1.GeldEinzahlen(7000);
            kunde1.GeldAbheben(500);
            kunde2.GeldAbheben(200);

            Console.WriteLine(kunde1.ToString());
            Console.WriteLine();
            Console.WriteLine(kunde2.ToString());
        }

    }
}