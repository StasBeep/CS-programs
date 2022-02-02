using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorywork4Variat27
{
    class Program
    {
        static void Main(string[] args)
        {
            // входные данные
            double x, y, a, b, c;
            // выходные данные
            bool p;

            Console.WriteLine("Введите сторону a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону отверстия x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону отверстия y: ");
            y = Convert.ToDouble(Console.ReadLine());

            // вызов метода hole (проверка проходит ли кирпич)
            p = hole(a, b, c, x, y);

            // вывод результата
            Console.WriteLine("Проходит ли кирпич? " + p);
            Console.ReadLine();
        }

        static bool hole(double a, double b, double c, double x, double y)
        {
            // начальное условие, что кирпич не пройдёт
            bool p = false;

            // условие прохождения кирпича через отверстие
            if((a <= x && b <= y) || (a <= y && b <= x))
            {
                p = true;
            }
            if((b <= x && c <= y) || (c <= x && b <= y))
            {
                p = true;
            }
            if((a <= x && c <= y) || (c <= x && a <= y))
            {
                p = true;
            }

            return p;
        }
    }
}
