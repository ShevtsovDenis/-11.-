using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_11.Структуры
{
    struct Line
    {
        double b;
        double k;

        public Line(double b, double k)
        {
         this.b = b;
         this.k = k;
        }

        public string Root()
        {
            double x = -b / k;
            if (k==0)
            {
                Console.WriteLine("коэффициент k не может быть равен 0");
            }
            return $"Решение - {x:f2}";
        }
    }
}
