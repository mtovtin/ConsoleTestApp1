using System;
using PointLibrary;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(1, 2);
            var b = new Point();
            Console.WriteLine($"Point a = {a}");
            Console.WriteLine($"Point b = {b}");
            a.ToString();
            Console.WriteLine($"Point a is in the {a.QuadrantNumber()}-th quadrant.");
            Console.WriteLine($"Return 0 if point b is in every quadrant  {b.QuadrantNumber()}");
            Console.WriteLine($"Symmetric point to the point a relative to the axis x is {a.GetSymmetric( "x")}");
            Console.WriteLine($"Symmetric point to the point a relative to the axis y is {a.GetSymmetric("y")}");
            Console.WriteLine($"Symmetric point to the point a relative to the point (5;8) is {a.GetSymmetric("point", new Point(5, 8))}");
            Console.WriteLine($"Distance between point a and b equals {Point.Distance(a,b)}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"b - a = {b - a}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"is a on axes? {a.OnAxes}");
            Console.WriteLine($"is b on axes? {b.OnAxes}");
            Console.WriteLine($"is point (0,0) on axes? {b.OnAxes}");
            var c = (Point)a.Clone();
            a.X = 8;
            Console.WriteLine($"Point a now equals {a}");
            Console.WriteLine($"Whereas point c still equals {c}");
            var g = a;
            Console.WriteLine($"Is a equal to g? {a.Equals(g)}");
            Console.WriteLine($"Is a equal to b? {a.Equals(b)}");
            Console.WriteLine($"Is a equal to null? {a.Equals(null)}");
            Console.WriteLine($"If a is equal to g return 0: {a.CompareTo(g)}");
            Console.WriteLine($"If a is bigger than b return 1: {a.CompareTo(b)}");
            Console.WriteLine($"If b is less than b return -1: {b.CompareTo(a)}");
            // var points = new List<Point> { a, b, c, g };
            // var formatter = new BinaryFormatter();
            //using(var stream = new FileStream("C:/Users/Lenovo/Desktop/points.dat", FileMode.Create))
            //{
            //  formatter.Serialize(stream, points);
            //}

            // var points = new List<Point> { a, b, c, g };
            // var writer= new StreamWriter("C:/Users/Lenovo/Desktop/points.dat");
            //XmlSerializer  serializer=new (typeof(List<Point>));
            //serializer.Serialize(writer,points);

            // var points = new List<Point> { a, b, c, g };
            // var reader= new StreamReader("C:/Users/Lenovo/Desktop/points.dat");
            //XmlSerializer  serializer=new (typeof(List<Point>));
            //serializer.Serialize(writer,points);

           // var formatter = new BinaryFormatter();
            //using(var stream = new FileStream("C:/Users/Lenovo/Desktop/points.dat", FileMode.Open))
            //{
             // var points =(List<Point>)formatter.Deserialize(stream);
               // foreach (Point i in points){
                 //   Console.Write(i+" ");
                //}
            //}

            var d = new ThreeDimensionalPoint(11, 12, 13);
            Console.WriteLine();
            Console.WriteLine(d);
            var f = new Point(11, 12);
            Console.WriteLine($"Multiplication of coordinates of 3-d point d equals {d.Product()}");
            Console.WriteLine($"Half point of point a is { a.HalfPoint()}");
            //  Console.WriteLine($"Is d equal to f? {f.Equals(d)}");
            // var points = new List<Point> { a, b, c, g };
            //var writer = new FileStream("C:/Users/Lenovo/Desktop/pointsNew.dat", FileMode.Create);
            //var serializer = new DataContractSerializer(points.GetType());
            //serializer.WriteObject(writer, points);
            
            var reader = new FileStream("C:/Users/Lenovo/Desktop/pointsNew.dat", FileMode.Open);
            var serializer = new DataContractSerializer(typeof(List<Point>));
            var points = (List<Point>)serializer.ReadObject(reader);
            foreach (Point i in points)
            {
                   Console.Write(i+" ");
                }

            }
        }
}
