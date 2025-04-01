using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Fachbuch
    {
        public string titel;
        public string fach;
        public int seiten;
        public string autor;

        public Fachbuch(string titel, string fach, int seiten, string autor)
        {
            this.titel = titel;
            this.fach = fach;
            this.seiten = seiten;
            this.autor = autor;
        }

    }
}
