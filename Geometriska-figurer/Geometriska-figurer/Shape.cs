using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    abstract class Shape
    {
        private double _length;
        private double _width;
        public abstract double Area
        {
            get;
        }
        public double Length
        {
            
        }
        public abstract double Perimeter
        {
            get;
        }
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Width
        {

        }
        public override string ToString()
        {

        }
    }
}
