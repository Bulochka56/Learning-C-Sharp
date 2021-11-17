using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_definite_integrals
{
    class Methods
    {
        public static double Average(double a, double b, int n, Func<double,double> fun)
        {
            double f = 0;
            double h = (b - a) / n;
            double x = a;
            for (int i = 0; i < n; i++)
            {
                f += fun(x + h / 2);
                x += h;
            }
            f *= h;
            return f;
        }
        public static double Left(double a, double b, int n, Func<double, double> fun)
        {
            double f = 0;
            double h = (b - a) / n;
            double x = a;
            for (int i = 0; i < n; i++)
            {
                f += fun(x);
                x += h;
            }
            f *= h;
            return f;
        }
        public static double Right(double a, double b, int n, Func<double, double> fun)
        {
            double f = 0;
            double h = (b - a) / n;
            double x = a+h;
            for (int i = 0; i <= n; i++)
            {
                f += fun(x);
                x += h;
            }
            f *= h;
            return f;
        }
        public static double Trapezoid(double a, double b, int n, Func<double, double> fun)
        {
            double f = 0;
            double h = (b - a) / n;
            f = (fun(a) + fun(a + h * n)) / 2; 
            double x = a+h;
            for (int i = 0; i < n-1; i++)
            {
                f += fun(x + h / 2);
                x += h;
            }
            f *= h;
            return f;
        }
        public static double Simpson(double a, double b, int n, Func<double, double> fun)
        {
            double f1 = 0;
            double f2 = 0;
            double f3 = 0;
            double h = (b - a) / (2*n);
            n *= 2;
            f1 = (fun(a) + fun(a + h * n));
            double x = a + h + h;
            for (int i = 2; i <= n - 2; i+=2)
            {
                f2 += fun(x);
                x += h + h;
            }
            f2 *= 2;
            x = a + h;
            for (int i = 1; i <= n - 1; i+=2)
            {
                f3 += fun(x);
                x += h + h;
            }
            f3 *= 4;
            return (f1+f2+f3)*h/3;
        }
    }
}
