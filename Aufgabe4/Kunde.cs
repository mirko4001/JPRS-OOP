using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class Kunde
    {
        private int kundenNr;
        private string name;
        private Konto konto;

        private static int counter;
        public Kunde(string name, string kontoNr, double kontostand = 0)
        {
            counter++;

            this.kundenNr = counter;
            this.name = name;
            this.konto = new Konto(kontoNr, this, kontostand);
        }

        public Kunde() { }

        public void GeldEinzahlen(double menge)
        {
            konto.GeldEinzahlen(menge);
        }

        public void GeldAbheben(double menge)
        {
            konto.GeldAbheben(menge);
        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                   $"Kunden-Nr.: {kundenNr}\n" +
                   $"---------------\n" +
                   $"{konto.ToString()}";
        }

    }
}
