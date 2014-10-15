using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public class Rectangle : Shape
    {
        public override double Area //Vi overridar för att vi redan skapat en Abstract "Area" och abstract kräver att man överskuggar.
        {
            get { return Length * Width; }
        }

        public override double Perimeter //Vi overridar för att vi redan skapat en Abstract "Area" och abstract kräver att man överskuggar.
        {
            get { return 2 * Length + 2 * Width; }
        }

        public Rectangle(double length, double width) :base(length, width)
        {
        }
    }
}
