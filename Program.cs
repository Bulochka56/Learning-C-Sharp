using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_definite_integrals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double f;
            double a = 1.2;
            double b = 2.6;
            int n = 5000;
            Console.WriteLine($"Number of iterations = {n}");
            Console.WriteLine($"The first function:\n\n" +
                $"     1 + 0.3x^2\n" +
                $"{new string('-',21)}\n" +
                $"0,9 + √(1.2x^2 + 0.5)\n");
            Console.WriteLine($"The integral is within [{a};{b}]");
            
            f = Methods.Left(a, b, n, Function.fun1);
            Console.WriteLine($"Integral by Left Rectangle Method = {f:0.00000}");
            
            f = Methods.Right(a, b, n, Function.fun1);
            Console.WriteLine($"Integral by Right Rectangle Method = {f:0.00000}");
            
            f = Methods.Average(a, b, n, Function.fun1);
            Console.WriteLine($"Integral by Mean Rectangle Method = {f:0.00000}");
            
            f = Methods.Trapezoid(a, b, n, Function.fun1);
            Console.WriteLine($"Integral by trapezoidal method = {f:0.00000}");
            
            f = Methods.Simpson(a, b, n, Function.fun1);
            Console.WriteLine($"Integral by the Simpson method = {f:0.00000}");
            
            a = 0.8;
            b = 1.6;
            Console.WriteLine($"\nSecond function:\n\n" +
                $"lg(x^2 + 1)\n" +
                $"{new string('-', 11)}\n" +
                $"   x + 1\n");
            Console.WriteLine($"The integral is within [{a};{b}]");
            
            f = Methods.Left(a, b, n, Function.fun2);
            Console.WriteLine($"Integral by Left Rectangle Method = {f:0.00000}");
            
            f = Methods.Right(a, b, n, Function.fun2);
            Console.WriteLine($"Integral by Right Rectangle Method = {f:0.00000}");
            
            f = Methods.Average(a, b, n, Function.fun2);
            Console.WriteLine($"Integral by Mean Rectangle Method = {f:0.00000}");
            
            f = Methods.Trapezoid(a, b, n, Function.fun2);
            Console.WriteLine($"Integral by trapezoidal method = {f:0.00000}");
            
            f = Methods.Simpson(a, b, n, Function.fun2);
            Console.WriteLine($"Integral by the Simpson method = {f:0.00000}");
            Console.ReadKey();
        }
    }
}
