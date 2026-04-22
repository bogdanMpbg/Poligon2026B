using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bogdan Markovic

            /*
            tacka A = new tacka(2, 3);
            tacka B = new tacka(4, 5);
            tacka C = new tacka(6, 7);
            tacka D = new tacka(8, 9);
            vektor AB = new vektor(A, B);
            AB.stampaj();
            */

            /*
            poligon P = poligon.unos();
            P.stampa();
            P.snimi();
            poligon P2 = poligon.ucitaj();
            P2.stampa();
            */

            /*
            tacka A = new tacka(1, 1);
            tacka B = new tacka(5, 1);
            tacka C = new tacka(2, 0.1);
            tacka D = new tacka(2, 0);
            vektor AB = new vektor(A, B);
            vektor CD = new vektor(C, D);
            Console.WriteLine(AB.sece(CD));
            */

            /*
            poligon p = poligon.unos();
            Console.WriteLine(p.povrsina());
            Console.ReadKey();
            */

            poligon p = new poligon(4);
            p.teme[0] = new tacka(1, 3);
            p.teme[1] = new tacka(1, 1);
            p.teme[2] = new tacka(4, 0);
            p.teme[3] = new tacka(3, 3);

            if (p.kvadrat())
            {
                Console.WriteLine("jeste kvadrat");
            } else
            {
                Console.WriteLine("nije kvadrat");
            }

            if (p.pravougaonik())
            {
                Console.WriteLine("jeste pravougaonik");
            }
            else
            {
                Console.WriteLine("nije pravougaonik");
            }

            if (p.deltoid())
            {
                Console.WriteLine("jeste deltoid");
            }
            else
            {
                Console.WriteLine("nije deltoid");
            }
        }
    }
}
