using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    internal class Geometrie
    {
        public static double BerechneKreisFläche(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public static double BerechneKreisUmfang(double r)
        {
            return r * 2 * Math.PI;
        }

        public static double BerechneDreieckFläche(double höhe, double seite)
        {
            return (höhe * seite)/2;
        }

        public static double BerechneDreieckUmfang(double s1, double s2, double s3)
        {
            return s1+s2+s3;
        }

        public static double BerechneRechteckFläche(double l, double b)
        {
            return l * b;
        }

        public static double BerechneRechteckUmfang(double l, double b)
        {
            return (l+b)*2;
        }


    }
}
