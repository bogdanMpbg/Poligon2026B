using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026B
{
    internal class tacka
    {
        public double x;
        public double y;
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public tacka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
