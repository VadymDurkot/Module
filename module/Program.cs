using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module
{
    public class Square
    {
        private double side;
        private const double comparsion_eps = 0.00001;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("square side must be non-negative");
                }
                side = value;
            }
        }
        public Square(double side)
        {
            Side = side;
        }
        public Square() : this(0)
        {

        }
        public Square(Square other)
        {
            Side = other.Side;
        }
        public void Input()
        {
            Console.Write("Square Side =");
            Side = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Square({Side})";
        }
        public double Area()
        {
            return Side * Side;
        }
        public double Perimeter()
        {
            return Side * 4;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return Math.Abs(s1.Side - s2.Side) <= comparsion_eps;
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        public static Square operator +(Square s1, Square s2)
        {
            return new Square(s1.Side + s2.Side);
        }
        public static Square operator -(Square s1, Square s2)
        {
            return new Square(s1.Side - s2.Side);
        }
        public static Square operator *(Square sq, double scalar)
        {
            return new Square(sq.Side * scalar);
        }
    }
}
    

