using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public class Ellipse : Shape
    {
        public override double Area 
        {
            get {return Math.PI * (Length / 2) * (Width / 2); } //returnerar Area till shape
        }
        public override double Perimeter { 
            get { return Math.PI * Math.Sqrt(2 * Math.Pow((Length/2), 2)+ 2 * Math.Pow((Width/2), 2)); } //returnerar Perimeter till Shape
        }                       //om jag förstod rätt så ska Math.Pow(x, y) ge värdet x^y.

        public Ellipse(double length, double width): base(length, width) // Tom konstruktor som tar emot värden för length och width. Värdena skickas till basklassen shape genom :base.
        {                                                                
        }
    }
}
