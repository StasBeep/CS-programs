using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Подключение Form к классу Raz
using System.Windows.Forms;

namespace Laboratorywork7Variant27
{
    class Raz
    {
        // Входные данные
        public double a, b, h, y;

        /* Метод вычисления значения функции одного аргумента в
         * одной точке (используется private - закрытый доступ,
         * работа только внутри класса)
         * @param {double} X - перменная (одна точка)
         * @return {double} - возврат значения функции 
         * P.S. 1.0/3.0 - обязательно прописывать через ".", так
         * как тип степени double, если использовать int, то
         * резултат будет считаться не правильно
         */
        private double OnePoint(double X)
        {
            if(X - 1 < 0)
            {
                return X * (-1) * Math.Pow(Math.Abs(X - 1), (1.0 / 3.0));
            }else if(X == 1)
            {
                return 0;
            } else
            {
                return X * Math.Pow((X - 1), (1.0 / 3.0));
            }
        }

        // Метод запуска и вывода результата функции в ListBox
        public void Fx (double a, double b, double h, ListBox LBx1)
        {
            // цикл do...while()
            do
            {
                // использование метода OnePoint
                y = OnePoint(a);
                // вывод значений в ListBox
                LBx1.Items.Add("f( " + a + " )  = " + y);
                // изменение шага цикла
                a += h;
            } while (a <= b);
        }
    }
}
