using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3
{
    class Complex
    {
        public double Real;
        public double Imaginary;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            double x = Real, y = Imaginary;
            if (y == 0) return $"{x}";
            else if (y > 0) return $"{x} + {y}i";
            else return $"{x} - {-y}i";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            double number;
            if (obj is Complex)
            {
                return Real == (obj as Complex).Real && Imaginary == (obj as Complex).Imaginary;
            }
            else if (Imaginary == 0 && double.TryParse(obj.ToString(), out number))
            {
                return Real == number;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Complex x, Complex y)
        {
            return x.Real == y.Real && x.Imaginary == y.Imaginary;
        }

        public static bool operator !=(Complex x, Complex y)
        {
            return !(x.Real == y.Real && x.Imaginary == y.Imaginary);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(x.Real * y.Real - x.Imaginary * y.Imaginary,
                x.Real * y.Imaginary + x.Imaginary * y.Real);
        }
    }
}
