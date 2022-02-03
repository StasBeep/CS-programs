using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Подключение для работы с Forms
using System.Windows.Forms;

namespace Laboratorywork9Variant27
{
    // Класс родитель
    public class Operations
    {
        // входные и выходные данные
        public double[] a;
        public double[] b;
        public double S;
        public int n;

        // метод вычисления суммы элементов с
        // нечётными номерами
        protected double SumElement()
        {
            // начальное значение суммы равно 0
            this.S = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 1)
                    S += a[i];
            }
            return this.S;
        }

        // метод вычисляющий количество положительных
        // элементов массива
        private int NumberEl()
        {
            this.n = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                    n++;
            }
            return this.n;
        }

        // формирование массива из индексов положительных
        // элементов исходного массива
        protected double[] ArrayIndex()
        {
            this.n = NumberEl();
            b = new double[this.n];
            int k = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] >= 0)
                {
                    b[k] = i + 1;
                    k++;
                }

            }
            return b;
        }
    }

    // Класс наследник (наследник от класса Operations)
    public class enter:Operations
    {
        // метод вызова методов выполняющих поставленную задачу
        public void demand()
        {
            this.S = SumElement();
            this.b = ArrayIndex();
        }

        // метод заполнения массива исходными данными
        // возвращается массив a типа double
        public double[] Input(TextBox TxBx)
        {
            // определение количества строк в textbox (TxBx)
            this.n = TxBx.Lines.Count();
            // объявление нового одномерного массива a []
            a = new double[n];
            // заполнение массива а данными из textbox
            for (int i = 0; i < a.Length; i++)
                a[i] = double.Parse(TxBx.Lines[i]);
            return b;
        }

        // метод вывода массива с результатом
        public void Output(ListBox LB, double[] array)
        {
            // Очистка полей listbox
            LB.Items.Clear();
            for (int i = 0; i < array.Length; i++)
                LB.Items.Add(array[i]);
        }
    }
}
