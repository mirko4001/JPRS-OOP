using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Freizeitbuch
    {
        public string titel;
        public int seiten;
        public bool gelesen;
        public string autor;
        public string genre;

        public Freizeitbuch(string titel, int seiten, bool gelesen, string autor, string genre)
        {
            this.titel = titel;
            this.seiten = seiten;
            this.gelesen = gelesen;
            this.autor = autor;
            this.genre = genre;
        }

        public Freizeitbuch(string titel, int seiten, string autor, string genre)
        {
            this.titel = titel;
            this.seiten = seiten;
            this.gelesen = false;
            this.autor = autor;
            this.genre = genre;
        }
    }
}
