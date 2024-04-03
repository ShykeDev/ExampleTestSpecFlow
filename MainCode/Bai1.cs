using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.MainCode
{
    public class Bai1
    {
        public static int Chia2SoNguyen(int a, int b)
        {
            if (b == 0)
            {
                throw new ArithmeticException();
            }
            return a / b;
        }
    }
}
