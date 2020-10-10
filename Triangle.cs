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
        public double SideThree { get; private set; }

        public double FirstAngle
        {
            get
            {
                return Math.Acos((SideOne * SideOne + SideTwo * SideTwo - SideThree * SideThree) / (2 * SideOne * SideTwo)) * 180 / Math.PI;
            }

            set { }
        }

        public double SecondAngle
        {
            get
            {
                return Math.Acos((SideThree * SideThree + SideTwo * SideTwo - SideOne * SideOne) / (2 * SideThree * SideTwo)) * 180 / Math.PI;
            }

            set { }
        }

        public double ThirdAngle
        {
            get
            {
                return Math.Acos((SideOne * SideOne + SideThree * SideThree - SideTwo * SideTwo) / (2 * SideOne * SideThree)) * 180 / Math.PI;
            }

            set { }
        }

        /// <summary>
        /// расчет периметра
        /// </summary>
        /// <returns></returns>
        public double Perimetr()
        {
            double perimetr = SideOne + SideTwo + SideThree;
            return perimetr;
        }

        public Triangle(double _sideOne, double _sideTwo, double _sideThree)
        {
            SideOne = _sideOne;
            SideTwo = _sideTwo;
            SideThree = _sideThree;

            if (SideOne + SideTwo <= SideThree
                || SideOne + SideTwo <= SideThree
                || SideTwo + SideThree <= SideOne
                || SideOne <= 0
                || SideTwo <= 0
                || SideThree <= 0)
            {
                throw new Exception("This Triangle does not exist!");
            }
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public double Area()
        {
            double halfPerimetr = Perimetr() / 2;
            return Math.Sqrt((halfPerimetr * (halfPerimetr - SideOne)
                * (halfPerimetr - SideTwo) * (halfPerimetr - SideThree)));
        }

        public EquilateralTriangle(double _sideOne) : base(_sideOne, _sideOne, _sideOne)
        {
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            Console.WriteLine("Enter the length of the 1st side: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the 2nd side: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the 3d side: ");
            c = Convert.ToDouble(Console.ReadLine());
            Triangle tr = new Triangle(a,b,c);
            Console.WriteLine("The perimetr of your triangle is: "+tr.Perimetr());
            Console.WriteLine("The angles of your triangle are: ");
            Console.WriteLine(tr.FirstAngle);
            Console.WriteLine(tr.SecondAngle);
            Console.WriteLine(tr.ThirdAngle);


            Console.ReadKey();
        }
    }
}