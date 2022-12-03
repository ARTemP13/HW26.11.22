using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class RationalNumber
    {
        public int numerator { get; set; }  
        public int denominator { get; set; }
        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumber)
            {
                RationalNumber num = obj as RationalNumber;
                
                return num.numerator == numerator && num.denominator == denominator;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Знаменатель:{numerator}\nЧислитель: {denominator}";
        }
        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            if ((num1.numerator * num2.denominator) > (num2.numerator * num1.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            if ((num1.numerator * num2.denominator) < (num2.numerator * num1.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            if ((num1.numerator * num2.denominator) >= (num2.numerator * num1.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            if ((num1.numerator * num2.denominator) <= (num2.numerator * num1.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double operator +(RationalNumber num1, RationalNumber num2)
        {

            return (num1.numerator * num2.denominator) + (num2.numerator * num1.denominator) / (num1.denominator * num2.denominator);
        }
        public static double operator -(RationalNumber num1, RationalNumber num2)
        {

            return (num1.numerator * num2.denominator) - (num2.numerator * num1.denominator) / (num1.denominator * num2.denominator);
        }
        

    }
}
