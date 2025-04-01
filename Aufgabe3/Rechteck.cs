using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    internal class Rechteck
    {
        public double Länge { get; private set; }
        public double Breite { get; private set; }

        public Rechteck(double länge, double breite)
        {
            Länge = länge;
            Breite= breite;
        }
    }
}
