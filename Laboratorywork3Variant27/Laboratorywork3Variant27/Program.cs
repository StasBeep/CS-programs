using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorywork3Variant27
{
    class Program
    {
        static void Main(string[] args)
        {
            // входные данные
            double c, y, x, z;

            // выходные данные
            double l;

            // запрос входных данных
            Console.WriteLine("Введите с: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            z = Convert.ToDouble(Console.ReadLine());

            // вычисление результата через метод systemSolution
            l = systemSolution(c, y, x, z);

            // очистка консоли
            Console.Clear();

            // вывод результата на консоль
            Console.WriteLine("При с = " + c + " при y = " + y + " при x = " + x + " при z =" + z);
            Console.WriteLine("Система принимает результат: " + l);

            // задержка
            Console.ReadLine();
        }

        static double systemSolution(double c, double y, double x, double z) {
            // возвращаемое значение (третье условие выполняется автоматически)
            double l = 15;

            // Условия
            if( y * z > 0 && x > 0) {
                double max = Math.Sqrt(x);
                
                if(max < c * y) {
                    max = c * y;
                }

                double min = y;

                if(min > max) {
                    min = max;
                }
                if(min > z) {
                    min = z;
                }

                l = min;
            } else if(y * z < 0 && x > 0) {
                double min = Math.Tan(x);

                if(min > Math.Pow(z, 3)) {
                    min = Math.Pow(z, 3);
                }

                l = min;
            }

            return l;
        }
    }
}
