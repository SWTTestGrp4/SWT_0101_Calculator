using System;

namespace SWT_0101_Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        static void Main(string[] args)
        {
            
        }
        public double Add(double a, double b)
        {
            var result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            var result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double a, double exp)
        {
            var result = Math.Pow(a,exp);
            Accumulator = result;
            return result;
        }
    }
}
