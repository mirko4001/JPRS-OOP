using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    internal class Dreieck
    {
        public double Höhe1 { get; private set; }
        public double Seite1 { get; private set; }
        public double Seite2 { get; private set; }
        public double Seite3 { get; private set; }

        public Dreieck(double höhe1, double seite1, double seite2, double seite3)
        {
            Höhe1 = höhe1;
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }
    }
}
