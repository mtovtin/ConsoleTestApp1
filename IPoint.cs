using System;
using System.Collections.Generic;
using System.Text;

namespace PointLibrary
{
   public interface IPoint
    {
        double X { get; set; }
        double Y { get; set; }
        Point GetSymmetric(string ans, Point point1 = null);
        int QuadrantNumber();
    }
}
