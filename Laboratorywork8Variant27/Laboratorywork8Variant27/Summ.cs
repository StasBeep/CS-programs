using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorywork8Variant27
{
    class Summ
    {
        // входные переменные
        public double x { get; set; }
        public double eps { get; set; }

        // Переменные вывода суммы и количества элементов
        public double S { get; set; }
        public double k { get; set; }

        // метод вычисления суммы через for
        public double SumForXE()
        {
            // первое значение ряда
            double a = (-1 * Math.Pow(x, 2)) / 6;
            this.S = a;
            // Цикл начинается с 1, так как 1 элемент ряда уже в
            // сумме, а i не может быть равно 0, так как на 0 делить
            // нельзя
            for(int i = 1; Math.Abs(a) > eps; i++)
            {
                // Вычисление последующего элемента ряда
                a = (a * (-1) * Math.Pow(x, 2) * i) / (i + 3);
                // добавление к сумме  элемента ряда
                this.S += a;
                // обновление счётчика количества элементов
                this.k = i;
            }

            return this.S;
        }

        // метод вычисления суммы через while
        public double SumWhileXE()
        {
            this.k = 1;
            double a = (-1 * Math.Pow(x, 2)) / 6;
            this.S = a;
            while (Math.Abs(a) > eps)
            {
                a = (a * (-1) * Math.Pow(x, 2) * k) / (k + 3);
                this.S += a;
                this.k++;
            }

            return this.S;
        }

        // метод вычисления суммы через do...while
        public double SumDoWhileXE()
        {
            this.k = 1;
            double a = (-1 * Math.Pow(x, 2)) / 6;
            this.S = a;
            do
            {
                a = (a * (-1) * Math.Pow(x, 2) * k) / (k + 3);
                this.S += a;
                this.k++;
            } while (Math.Abs(a) > eps);

            return this.S;
        }
    }
}
