using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public double SideOne { get; private set; }
        public double SideTwo { get; private set; }
        public int Angle { get; private set; }



        public Triangle(double _sideOne, double _sideTwo, int _angle)
        {
            SideOne = _sideOne;
            SideTwo = _sideTwo;
            Angle = _angle;

            if (Angle <= 0
                || Angle >= 179
                || SideOne <= 0
                || SideTwo <= 0)
            {
                throw new Exception("This Triangle does not exist!");
            }
        }



        public double SideThree
        {
            get
            {
                return Math.Sqrt(SideOne * SideOne + SideTwo * SideTwo - 2 * SideOne * SideTwo * Math.Cos(Angle));
            }

            set { }
        }


        public virtual double Perimetr()
        {
            double perimetr = SideOne + SideTwo + SideThree;
     //       Console.WriteLine($"Perimetr is: {perimetr} ");
            return perimetr;
        }



        public virtual double Area()
        {
            double TriangleArea = SideOne*SideTwo*Math.Sin(Angle);
            return TriangleArea;
        }

     
    }

    public class IsoscelesTriangle : Triangle   // рівнобедренний трикутник 
    {
        public override double Area()
        {
            return 0.5*SideOne*SideOne*Math.Sin(Angle);
        }

        public override double Perimetr()
        {
            double perimetr = SideOne*2 + SideThree; 
            return perimetr;
        }

        public IsoscelesTriangle(double _sideOne, double _sideTwo, int _angle) : base(_sideOne, _sideOne, _angle)
        {
        }
        
    }




   public class RightTriangle : Triangle   // прямокутний трикутник 
    {
        public override double Area()
        {
            return SideOne*SideTwo/2;
        }

        public override double Perimetr()
        {
            double perimetr = SideOne + SideTwo + SideThree;
            return perimetr;
        }

        public RightTriangle(double _sideOne, double _sideTwo, int _angle) : base(_sideOne, _sideTwo, _angle)
        {
        }

    }

    public class TriangleCreator
    {
        public static Triangle Type(double a, double b, int c)
        {
            Triangle tr;
            if (a == b)
            {
                tr = new IsoscelesTriangle(a, b, c);
                Console.WriteLine("You got the Isosceles Triangle ");
            }
            else if (c == 90)
            {
                tr = new RightTriangle(a, b, c);
                Console.WriteLine("You got the Right Triangle ");

            }
            else
            {
                tr = new Triangle(a, b, c);
                Console.WriteLine("You got the Simple Triangle ");

            }
            return tr;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            double a, b; int c;
            Console.WriteLine("Enter the length of the 1st side: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the 2nd side: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the angle between 2 sides: ");
            c = Convert.ToInt32(Console.ReadLine());

            Triangle tr = TriangleCreator.Type(a, b, c);
            Console.WriteLine(tr.Perimetr().ToString());
            Console.WriteLine(tr.Area().ToString());
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}