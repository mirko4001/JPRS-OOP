using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    internal class BodyMassIndex
    {
        private double groesse;
        private double gewicht;

        public BodyMassIndex(double groesse, double gewicht)
        {
            this.groesse = groesse;
            this.gewicht = gewicht;
        }

        public double Berechnung()
        {
            return gewicht / Math.Pow(groesse, 2);
        }
    }
}
