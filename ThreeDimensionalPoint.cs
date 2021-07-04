using System;
using System.Collections.Generic;
using System.Text;
using PointLibrary;

namespace ConsoleTestApp
{
    class ThreeDimensionalPoint: Point
    {
        public double Z { get; set; }
        public ThreeDimensionalPoint(double X, double Y,double Z) :base(X,Y)
        {
            this.Z = Z;
        }
        public override string ToString() => $"Three Dimensional Point :({X};{Y};{Z})";
        public override double Product() => base.Product() * Z;
         
        

    }
}
