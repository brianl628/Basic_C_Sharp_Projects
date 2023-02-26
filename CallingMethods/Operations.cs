using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Operation
    {
        public int Addition(int Num)
        {
            Num3 = Num + 10;
            return Num3;
        }

        public int Division(int Num)
        {
            Num4 = Num / 10;
            return Num4;
        }

        public int Multiplication(int Num)
        {
            Num5 = Num * 10;
            return Num5;
        }
        int Num3 { get; set; }
        int Num4 { get; set; }
        int Num5 { get; set; }
    }
}