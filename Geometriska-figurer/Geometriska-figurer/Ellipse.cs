using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Ellipse : Shape
    {
        public double Area { get; }
        public double Perimeter { get; }

        public Ellipse(double length, double width): base(length, width)
        {

        }
    }
}
