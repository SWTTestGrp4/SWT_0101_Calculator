using System;

namespace SWT_0101_Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public  double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
