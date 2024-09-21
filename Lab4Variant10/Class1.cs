using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Variant10
{
    public class Class1
    {
        public static double[] method(double[] A, double C)
        {
            double count = 0;
            double p = 1;
            foreach(double a in A)
            {
                if(a < C)
                {
                    p *= a;
                    count++;
                }
            }

            return new double[] { p, count };
        }
    }
}
