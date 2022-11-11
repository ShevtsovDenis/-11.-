using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_11.Структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение коеффициентов b и k. Для решения линейного уравнения  0=kx+b");
            double b_ = Convert.ToDouble(Console.ReadLine());
            double k_ = Convert.ToDouble(Console.ReadLine());
            //экземпляр структуры
            Line line = new Line(b_, k_);
            Console.WriteLine(line.Root());
            Console.ReadKey();
        }
    }
}
