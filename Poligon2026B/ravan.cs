using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026B
{
    internal class ravan
    {
        public static int SIS(vektor a, tacka B, tacka C)
        {
            vektor AB = new vektor(a.pocetak, B);
            vektor AC = new vektor(a.pocetak, C);
            double aAB = vektor.VP(a, AB);
            double aAC = vektor.VP(a, AC);
            if (aAC * aAB > 0) return 0; // sa iste
            if (aAC * aAB < 0) return -1; // razne strane
            return 1; // bar jedna tacka lezi na vektoru
        }
    }
}