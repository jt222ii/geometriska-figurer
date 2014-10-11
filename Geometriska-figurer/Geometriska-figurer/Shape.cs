using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public abstract class Shape
    {
        private double _length;
        private double _width;
        public abstract double Area
        {
            get;
        }
        public double Length
        {
            get {return _length;}
            set
            {
                if (value<0)
                {throw new ArgumentException();}
                _length = value;
            }
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
            get { return _width; }
            set 
            {
                if (value<0)
                {throw new ArgumentException();}
                _width = value;
            }

        }
        public override string ToString() //override skriver över ToString som redan finns
        {
            return string.Format("Längd   : {0,8}\nBredd   : {1,8}\nOmkrets : {2,8}\nArea    : {3,8}", Length, Width, Perimeter, Area);
        }
    }
}
