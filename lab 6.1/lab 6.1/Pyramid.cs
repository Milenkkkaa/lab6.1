using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._1
{
    internal class Pyramid : Solid
    {
        public double A { get; set; } 
        public double H { get; set; } 
        public Pyramid(double a, double h)
        {
            A = a;
            H = h;
        }
        public override double GetVolume()
        {
            return ((1.0 / 3) * (A * A)) * H;
        }
    }
}
