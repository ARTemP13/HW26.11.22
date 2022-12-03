using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class ComplexNumber
    {
        public int RealPath { get; set; }
        public int ImanginaryPath { get; set; }

        public ComplexNumber(int real, int imaginary)
        {
            RealPath = real;
            ImanginaryPath = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            int real1 = a.RealPath + b.RealPath;
            int img1 = a.ImanginaryPath + b.ImanginaryPath;
            return new ComplexNumber(real1, img1);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            int real1 = a.RealPath - b.RealPath;
            int img1 = a.ImanginaryPath - b.ImanginaryPath;
            return new ComplexNumber(real1, img1);
            
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            int real1 = (a.RealPath*b.RealPath) - (a.ImanginaryPath * b.ImanginaryPath);
            int img1 = a.ImanginaryPath * b.RealPath + b.ImanginaryPath * a.RealPath;
            return new ComplexNumber(real1, img1);
        }
        public override bool Equals(object obj)
        {
            ComplexNumber a = obj as ComplexNumber;
            if (a.RealPath == RealPath && a.ImanginaryPath == ImanginaryPath)
            {
                return true;
            }
            {
                return false;
            }
            
        }
        public override string ToString()
        {
            return $"Вещественная часть числа: {RealPath}\nКомплексная часть числа: {ImanginaryPath}";
        }
        
    }
}
