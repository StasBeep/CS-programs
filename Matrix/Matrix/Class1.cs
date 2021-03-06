using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public class Class1
    {
        public int n;
        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }
        private double[,] a;
        private int x, y;
        private double[] st;

        protected void permutation()
        {
            MaxMatr();
            int l = 0;
            if (x != 0)
            {
                while (x != 0)
                {
                    while (y != 0)
                    {
                        if (l == n)
                            l = 0;
                        a = PerStolb(l);
                        MaxMatr();
                        l++;
                    }
                    if (l == n)
                        l = 0;
                    a = PerStroka(l);
                    MaxMatr();
                    l++;
                }
            }
            else
            {
                while (y != 0)
                {
                    if (l == n)
                        l = 0;
                    a = PerStolb(l);
                    MaxMatr();
                    l++;
                }
            }
        }

        private double[,] PerStroka(int l)
        {
            st = new double[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                st[k] = a[l, i];
                k++;
            }
            if (l + 1 == n)
            {
                for (int i = 0; i < n; i++)
                {
                    a[l, i] = a[0, i];
                    a[0, i] = st[i];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    a[l, i] = a[l + 1, i];
                    a[l + 1, i] = st[i];
                }
            }
            return a;
        }
        private double[,] PerStolb(int l)
        {
            st = new double[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                st[k] = a[i, l];
                k++;
            }
            if (l + 1 == n)
            {
                for (int i = 0; i < n; i++)
                {
                    a[i, l] = a[i, 0];
                    a[i, 0] = st[i];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    a[i, l] = a[i, l + 1];
                    a[i, l + 1] = st[i];
                }
            }
            return a;
        }

        private void MaxMatr()
        {
            x = 0;
            y = 0;
            double max = a[0, 0];
            for (int i= 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
        }
    }

    public class Class2 : Class1
    {
        public void metod()
        {
           permutation();
        }

        public double[,] InpZ()
        {
            A = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(0, 50);
                }
            }
            return A;
        }

        public double[,] InpD()
        {
            A = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
                }
            }
            return A;
        }

        public void OutP(ListBox li)
        {
            li.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                string s = "";
                for (int j = 0; j < n; j++)
                {
                    s += A[i, j].ToString() + "  ";
                }
                li.Items.Add(s);
            }
        }
    }
}
