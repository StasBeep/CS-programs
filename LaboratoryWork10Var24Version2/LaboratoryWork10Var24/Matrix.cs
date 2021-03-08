using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork10Var24
{
    public class Matrix
    {
        // количество строк
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        
        // количество столбцов
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        // матрица
        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }

        // для вычисления Y
        protected double Y;
        // закрытый одномерный массив, для сохранения максимальных элементов в строках матрицы
        protected double[] MaxA;

        // закрытое поле для количества строк
        private int m;
        // закрытое поле для количества столбцов
        private int n;
        // закрытое поле для матрицы
        private double[,] a;
        
        // Нахождение максимального элемента в строке
        protected void MaxElement()
        {
            MaxA = new double[m];
            for(int i = 0; i < m; i++)
            {
                double max = a[i, 0];
                for(int j = 1; j < n; j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
                MaxA[i] = max;
            }
        }

        // Вычисление переменной Y по заданию
        protected double CalculateY()
        {
            for(int i =0;i<m;i++)
                Y += MaxA[i] * MaxA[m - i - 1];
            return Y;
        }
    }
    public class InpOutResCall:Matrix
    {
        // Метод заполнения матрицы целыми числами
        public void InputZ()
        {
            A = new double[M, N];
            Random rand = new Random();
            for(int i = 0;i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    A[i, j] = rand.Next(-30, 30);
                }
            }
        }

        // Метод заоплнения матрицы вещественными числами
        public void InputR()
        {
            A = new double[M, N];
            Random rand = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = Math.Round(rand.NextDouble()*100,2);
                }
            }
        }

        // Метод для вывода заполненой двумерной матрицы
        public void OutputTWO(ListBox pro)
        {
            pro.Items.Clear();
            for (int i = 0; i < M; i++)
            {
                string s = "";
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] >= 10)
                        s += " " + A[i, j].ToString() + "  ";
                    else if (A[i, j] > 0 && A[i, j] < 10)
                        s += "   " + A[i, j].ToString() + "  ";
                    else if (A[i, j] <= 0 && A[i, j] > -10)
                        s += "  " + A[i, j].ToString() + "  ";
                    else
                        s += A[i, j].ToString() + "  ";
                }
                pro.Items.Add(s);
            }
        }

        // Метод, который работает при нажатии "Вычислить"
        public void EnterCall()
        {
            MaxElement();
            Y = CalculateY();
        }

        // Метод, для вывода результата максимальных значений (одномерный
        // массив) и вывода ррезультата Y
        public void OutputONE(ListBox one, TextBox two)
        {
            one.Items.Clear();
            two.Clear();
            two.Text = Y.ToString();
            for(int i = 0; i < M; i++)
            {
                one.Items.Add(MaxA[i]);
            }
        }
    }
}
