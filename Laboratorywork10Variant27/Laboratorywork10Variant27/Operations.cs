using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// подключение элементов формы
using System.Windows.Forms;

namespace Laboratorywork10Variant27
{
    public class Operations
    {
        // количество строк и столбцов n*n
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }

        public double[,] B
        {
            get { return b; }
            set { b = value; }
        }

        public double[,] C
        {
            get { return c; }
            set { c = value; }
        }

        public double[,] X
        {
            get { return x; }
            set { x = value; }
        }

        // количество строк и столбцов (private)
        private int n;

        // матрицы
        private double[,] a;
        private double[,] b;
        private double[,] c;
        private double[,] x;

        // метод вычисления наибольшего значения элемента из матриц
        protected double[,] MaxElement(double[,] a,double[,] b,double[,] c)
        {
            x = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    double max = a[i, j];
                    if (max < b[i, j])
                        max = b[i, j];
                    if (max < c[i, j])
                        max = c[i, j];
                    x[i, j] = max;
                }
            }

            return this.x;
        }
    }

    public class ResInpOut : Operations
    {
        // конструктор для рандома 
        Random rand = new Random();
        
        // метод заполнения матриц
        public double[,] InpMatrix(ListBox lb)
        {
            double[,] array = new double[N, N];
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    array[i, j] = Math.Round(rand.NextDouble() * 100, 2);
                }
            }

            OutMatrix(array, lb);

            return array;
        }

        // Метод вывода двумерной матрицы
        private void OutMatrix(double[,] array, ListBox lb)
        {
            lb.Items.Clear();
            for(int i = 0; i < N; i++)
            {
                string s = "";
                for(int j = 0; j < N; j++)
                {
                    s += array[i, j].ToString() + "  ";
                }
                lb.Items.Add(s);
            }

        }

        public void purpose(double[,] a, double[,] b, double[,] c, ListBox lb)
        {
            this.X = MaxElement(a, b, c);
            OutMatrix(this.X, lb);
        }
    }
}
