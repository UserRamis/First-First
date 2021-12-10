using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._12._2021
{
    class Rational
    {
        public int Numerator;
        public int Denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator <= 0)
            {
                throw new Exception("Does not valid denominator value.");
            }
            else
            {
                int factor = Maths.GreatestCommonFactor(numerator, denominator);
                Numerator = numerator / factor;
                Denominator = denominator / factor;
            }
        }

        public static bool operator ==(Rational x, Rational y)
        {
            return x.Numerator == y.Numerator && x.Denominator == y.Denominator;
        }

        public static bool operator !=(Rational x, Rational y)
        {
            return !(x.Numerator == y.Numerator && x.Denominator == y.Denominator);
        }

        public override bool Equals(object obj)
        {
            decimal number;
            if (decimal.TryParse(obj.ToString(), out number))
            {
                return Convert.ToDecimal(Numerator) / Denominator == number;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static bool operator <(Rational x, Rational y)
        {
            return x.Numerator * y.Denominator < x.Denominator * y.Numerator;
        }

        public static bool operator >(Rational x, Rational y)
        {
            return x.Numerator * y.Denominator > x.Denominator * y.Numerator;
        }

        public static bool operator <=(Rational x, Rational y)
        {
            return x.Numerator * y.Denominator <= x.Denominator * y.Numerator;
        }

        public static bool operator >=(Rational x, Rational y)
        {
            return x.Numerator * y.Denominator >= x.Denominator * y.Numerator;
        }

        public static Rational operator +(Rational x, Rational y)
        {
            return new Rational(x.Numerator * y.Denominator + x.Denominator * y.Numerator, x.Denominator * y.Denominator);
        }

        public static Rational operator -(Rational x, Rational y)
        {
            return new Rational(x.Numerator * y.Denominator - x.Denominator * y.Numerator, x.Denominator * y.Denominator);
        }

        public static Rational operator *(Rational x, Rational y)
        {
            return new Rational(x.Numerator * y.Numerator, x.Denominator * y.Denominator);
        }

        public static Rational operator /(Rational x, Rational y)
        {
            return new Rational(x.Numerator * y.Denominator, x.Denominator * y.Numerator);
        }

        public static Rational operator %(Rational x, Rational y)
        {
            return x - (Rational)(int)(x / y) * y;
        }

        public static Rational operator ++(Rational x)
        {
            return new Rational(x.Numerator + x.Denominator, x.Denominator);
        }

        public static Rational operator --(Rational x)
        {
            return new Rational(x.Numerator - x.Denominator, x.Denominator);
        }

        public static explicit operator Rational(float x)
        {
            int factor = (int)Math.Pow(10, Maths.GetDecimalDigitsCount(x));
            return new Rational(Convert.ToInt32(x * factor), factor);
        }

        public static explicit operator Rational(int x)
        {
            return new Rational(x, 1);
        }

        public static explicit operator float(Rational x)
        {
            return Convert.ToSingle(x.Numerator) / x.Denominator;
        }

        public static explicit operator int(Rational x)
        {
            return x.Numerator / x.Denominator;
        }
    }
}
