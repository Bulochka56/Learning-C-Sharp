using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_definite_integrals
{
    class Function
    {
        public static double fun1(double x)
        {
            return (1 + 0.3 * x * x) / (0.9 + Math.Sqrt(1.2 * x * x + 0.5));
        }
        public static double fun2(double x)
        {
            return Math.Log10(x * x + 1) / (x + 1);
        }
    }
}
