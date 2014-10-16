using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public abstract class Shape //abstrakta klasser kan aldrig instansieras direkt och måste ärvas av en subklass
    {
        private double _length; //fält
        private double _width;
        public abstract double Area //hämtar värde från Rectangle eller Ellipse.cs. Abstract kan inte initieras och kräver att man ska överskugga den. 
        {
            get;
        }
        public abstract double Perimeter //hämtar värde från Rectangle.cs eller Ellipse.cs. Abstract kan inte initieras och kräver att man ska överskugga den. 
        {
            get;
        }
        public double Length // När man vill ha värdet på fältet _length så returnerar den _length vill man sätta värdet används set och kollar så att värdet man sätter inte är 0 eller mindre
        {
            get {return _length;}
            set
            {
                if (value<=0) //om värdet är mindre eller lika med 0 kastas ett undantag
                {throw new ArgumentException();}
                _length = value; //kastas inte undantaget sätts _length till sitt nya värde
            }
        }
        protected Shape(double length, double width) //ger Length och Width de värden som kommit från tidigare konstrukor efter att man skrivit in värdena för längd och bredd
        {
            Length = length;
            Width = width;
        }
        public double Width //samma som egenskapen Length ovan fast för bredd istället
        {
            get { return _width; }
            set 
            {
                if (value<0)
                {throw new ArgumentException();}
                _width = value;
            }

        }
        public override string ToString() //override skriver över ToString som redan finns i object
        {
            return string.Format("Längd   : {0,8}\nBredd   : {1,8}\nOmkrets : {2,8}\nArea    : {3,8}", Length, Width, Perimeter, Area);
        }
    }
    public enum ShapeType { Ellipse, Rectangle } //Enum innehåller ett antal namnivna konstanter som kallas enumerators. 
}                                                //På detta sättet kan man göra en tydligare och lättare att läsa kod istället för att använda konstanta integers. 
                                                 //De namngivna konstanterna har värdena 0, 1.
