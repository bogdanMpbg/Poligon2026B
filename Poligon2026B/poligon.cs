using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Poligon2026B
{
    internal class poligon
    {
        int br_temena;
        tacka[] teme;

        public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
        }

        public static poligon unos()
        {
            Console.Write("Unesite broj temena: ");
            int n = Convert.ToInt32(Console.ReadLine());
            poligon rez = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Teme({i+1}).x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Teme({i+1}).y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                rez.teme[i] = new tacka(x, y);
            }
            return rez;
        }

        public void stampa()
        {
            Console.WriteLine($"Poligon sa {br_temena} tacaka");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine($"x={teme[i].x}, y={teme[i].y}");
            }
        }

        public static poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            poligon rez = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(ulaz.ReadLine());
                double y = Convert.ToDouble(ulaz.ReadLine());
                rez.teme[i] = new tacka(x, y);
            }
            ulaz.Close();
            return rez;
        }

        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine($"{br_temena}");
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine($"{teme[i].x}");
                izlaz.WriteLine($"{teme[i].y}");
            }
            izlaz.Close();
        }

        public double obim()
        {
            double o = 0;
            for (int i = 0; i < br_temena - 1; i++)
            {
                vektor v1 = new vektor(teme[i], teme[i + 1]);
                o += v1.duzina();
            }
            vektor v2 = new vektor(teme[br_temena - 1], teme[0]);
            o += v2.duzina();
            return o;
        }
    }
}
