using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorywork2Variant27
{
    class Program
    {
        static void Main(string[] args)
        {
            // переменные которые нужны для ввода и вывода
            // переменные a и b  - пределы (нужно ввести)
            // переменная y - результат определённого интеграла (вывод)
            double a, b, y;
            
            // переменная i для меню - определение каким способом происходит
            // вычисления (через static double: 1, через static void: 2)
            int i;

            Console.WriteLine("Введите нижний предел a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите верхний предел b: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Введите через какой метод хотите решить?");
            Console.WriteLine("1. Через static double   2. Через static void");
            i = Convert.ToInt32(Console.ReadLine());

            // Очистка консоли
            Console.Clear();

            if(i == 1) {
                // применение метода integralSolution (static double)
                y = integralSolution(a, b);

                Console.WriteLine("Результат определённого интеграла static double: " + y);
            } else {
                // применение метода integralSolV (static void)
                integralSolV(a, b, out y);

                Console.WriteLine("Результат определённого интеграла static void: " + y);
            }

            // Задержка
            Console.ReadLine();
        }

        // возвращаемое значение типа double, принимет два параметра типа double (A, B)
        static double integralSolution(double A, double B) {
            
            // Вычисление функции f(x) = sqrt(2x+1) для а в методе funSolution()
            double Fa = funSolution(A);
            // Вычисление функции f(x) = sqrt(2x+1) для a и b в методе funSolution()
            double Fab = funSolution((A + B) / 6);
            // Вычисление функции f(x) = sqrt(2x+1) для b в методе funSolution()
            double Fb = funSolution(B);

            return (( B - A ) / 6) * (Fa + 4 * Fab + Fb); 
        }

        // принимет два параметра типа double (A, B), возвращает тип double Y
        static void integralSolV(double A, double B, out double Y) {
            
            // Вычисление функции f(x) = sqrt(2x+1) для а в методе funSolution()
            double Fa = funSolution(A);
            // Вычисление функции f(x) = sqrt(2x+1) для a и b в методе funSolution()
            double Fab = funSolution((A + B) / 6);
            // Вычисление функции f(x) = sqrt(2x+1) для b в методе funSolution()
            double Fb = funSolution(B);

            Y = (( B - A ) / 6) * (Fa + 4 * Fab + Fb); 
        }

        // метод возвращающий результат расчёта функции f(x) = sqrt(2x+1) для разных x
        static double funSolution(double x) {
            return Math.Sqrt(2 * x + 1);
        }
    }
}
