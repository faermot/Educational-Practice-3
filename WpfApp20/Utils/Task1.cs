using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task1
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double x = vars["x"];
            double a = vars["a"];
            double c = vars["c"];
            return Math.Sqrt(Math.Exp(x) - Math.Pow(Math.Cos(x * x * a * a), 4) + Math.Pow(Math.Atan(a - x * x), 4));
        }
    }
}
