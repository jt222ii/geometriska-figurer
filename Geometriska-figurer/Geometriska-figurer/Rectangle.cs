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
            get { return Length * Width; } //returnerar Area till Shape
        }

        public override double Perimeter //Vi overridar för att vi redan skapat en Abstract "Area" och abstract kräver att man överskuggar.
        {
            get { return 2 * Length + 2 * Width; }//returnerar Perimeter till Shape
        }

        public Rectangle(double length, double width) :base(length, width) // Tom konstruktor som tar emot värden för length och width. Värdena skickas till basklassen shape genom :base.
        {
        }
    }
}
