using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_11.Структуры
{
    struct Line
    {//Поля
        double b;
        double k;
        //конструктор
        public Line(double b, double k)
        {
            this.b = b;
            this.k = k;
        }
        //метод
        public string Root()
        {
            double x = -b / k;
            if (k == 0 && b == 0)
                return "Неверные значения коэффициентов. Деление 0 на 0";
            else if (k == 0)
                return "Коэффициент k не может быть равен 0";
            else
                return $"Решение - {x:f2}";
        }
    }
}
