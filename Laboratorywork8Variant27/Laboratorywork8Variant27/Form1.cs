using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorywork8Variant27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подключение класса Summ
            Summ Obj = new Summ();

            // Считывание данных с полей textbox
            Obj.x = Convert.ToDouble(textBox1.Text);
            Obj.eps = Convert.ToDouble(textBox2.Text);

            // Использование метода для расчёта суммы рядов
            Obj.S = Obj.SumForXE();

            // Вывод информации в поле textbox
            textBox3.Text = Convert.ToString(Obj.S) + "   " + Convert.ToString(Obj.k);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Подключение класса Summ
            Summ Obj = new Summ();

            // Считывание данных с полей textbox
            Obj.x = Convert.ToDouble(textBox1.Text);
            Obj.eps = Convert.ToDouble(textBox2.Text);

            // Использование метода для расчёта суммы рядов
            Obj.S = Obj.SumWhileXE();

            // Вывод информации в поле textbox
            textBox4.Text = Convert.ToString(Obj.S) + "   " + Convert.ToString(Obj.k);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Подключение класса Summ
            Summ Obj = new Summ();

            // Считывание данных с полей textbox
            Obj.x = Convert.ToDouble(textBox1.Text);
            Obj.eps = Convert.ToDouble(textBox2.Text);

            // Использование метода для расчёта суммы рядов
            Obj.S = Obj.SumDoWhileXE();

            // Вывод информации в поле textbox
            textBox5.Text = Convert.ToString(Obj.S) + "   " + Convert.ToString(Obj.k);
        }
    }
}
