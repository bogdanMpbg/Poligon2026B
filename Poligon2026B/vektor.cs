using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026B
{
    internal class vektor
    {
        public tacka pocetak;
        public tacka kraj;

        public vektor(tacka pocetak, tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }

        public static double SP(vektor a, vektor b) 
        { 
            tacka at = a.centriraj();
            tacka bt = b.centriraj();
            return at.x * bt.x + at.y * bt.y;
        }

        public static double VP(vektor a, vektor b)
        {
            tacka at = a.centriraj();
            tacka bt = b.centriraj();
            return at.x * bt.y - at.y * bt.x;
        }

        public double duzina()
        {
            tacka druga = this.centriraj();
            return druga.d();
        }

        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        } 

        public bool sece(vektor b)
        {
            int x = ravan.SIS(this, b.pocetak, b.kraj);
            int y = ravan.SIS(b, this.pocetak, this.kraj);
            if (x * y != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void stampaj()
        {
            Console.WriteLine("Od x1={0}, y1={1} Do x2={2}, y2={3}", pocetak.x, pocetak.y, kraj.x, kraj.y);
        }
    }
}
