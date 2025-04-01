using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Film
    {
        public string titel;
        public string genre;
        public double dauer;
        public double größe;

        public Film(string titel, string genre, double dauer, double größe)
        {
            this.titel = titel;
            this.genre = genre;
            this.dauer = dauer;
            this.größe = größe;
        }
    }
}
