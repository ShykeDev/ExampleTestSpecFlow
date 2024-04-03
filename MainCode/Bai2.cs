using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.MainCode
{
    public class Caculator
    {
        public static double Nhan2So(double x, double y)
        {
            return x * y;
        }

        public static double Chia2So(double x, double y)
        {
            if (y == 0)
            {
                throw new ArithmeticException();
            }
            return x/y;
        }
    }
}
