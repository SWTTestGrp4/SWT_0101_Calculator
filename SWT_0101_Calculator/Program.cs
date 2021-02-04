using System;

namespace SWT_0101_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double a = 5;
            double b = 10;

            Console.WriteLine("{0} + {1} = " + calc.Add(a, b).ToString(), a.ToString(), b.ToString());
            Console.WriteLine("{0} - {1} = " + calc.Subtract(a, b).ToString(), a.ToString(), b.ToString());
            Console.WriteLine("{0} * {1} = " + calc.Multiply(a, b).ToString(), a.ToString(), b.ToString());
            Console.WriteLine("{1}^{0} = " + calc.Power(a, b).ToString(), a.ToString(), b.ToString());

        }
    }
}