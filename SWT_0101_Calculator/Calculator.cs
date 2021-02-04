using System;

namespace SWT_0101_Calculator
{
    public class Calculator
    {
       
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
