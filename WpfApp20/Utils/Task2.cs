using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task2
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double d = vars["d"];
            double y = vars["y"];
            return Math.Log(d) + 3.5 * (Math.Pow(d, 2) + 1) / (Math.Cos(2 * y));
        }
    }
}
