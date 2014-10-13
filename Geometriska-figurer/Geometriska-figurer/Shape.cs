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
        public abstract double Area //hämtar värde från Rectangle eller Ellipse.cs 
        {
            get;
        }
        public double Length // När man vill ha värdet på _length så returnerar den _length vill man sätta värdet används set och kollar så att värdet man sätter inte är 0 eller mindre
        {
            get {return _length;}
            set
            {
                if (value<=0) //om värdet är mindre eller lika med 0 kastas ett undantag
                {throw new ArgumentException();}
                _length = value; //kastas inte undantaget sätts _length till sitt nya värde
            }
        }
        public abstract double Perimeter //hämtar värde från Rectangle.cs eller Ellipse.cs
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
    public enum ShapeType { Ellipse, Rectangle }
}
