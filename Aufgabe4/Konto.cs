using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class Konto
    {
        private string kontoNr;
        private double kontostand;
        private Kunde inhaber;

        private static List<string> kontoNrListe = new List<string>();

        public Konto(string kontoNr, Kunde inhaber, double kontostand)
        {


            if (CheckAvailability(kontoNr))
            {
                kontoNrListe.Add(kontoNr);
                this.kontoNr = kontoNr;
                this.kontostand = kontostand;
                this.inhaber = inhaber;
            }
            else
            {
                throw new Exception("Konto Nummer bereits vergeben");
            }
        }

        private bool CheckAvailability(string kontoNr)
        {
            // return true if available, false if unavailable
            foreach (string item in kontoNrListe)
            {
                if (item == kontoNr) return false;
            }

            return true;
        }

        public void GeldEinzahlen(double menge)
        {
            kontostand += menge;
        }

        public void GeldAbheben(double menge)
        {
            if (kontostand - menge >= 0)
            {
                kontostand -= menge;
            }
            else
            {
                throw new Exception("Nicht genug Geld");
            }
        }

        public override string ToString()
        {
            return $"Konto-Nr.: {kontoNr}\n" +
                   $"Kontostand: {kontostand}€";
        }
    }
}
