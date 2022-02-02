using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorywork7Variant27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подкючение к классу Raz
            Raz Obj = new Raz();

            Obj.a = Convert.ToDouble(textBox1.Text);
            Obj.b = Convert.ToDouble(textBox2.Text);
            Obj.h = Convert.ToDouble(textBox3.Text);

            // Очистка listBox1
            listBox1.Items.Clear();

            // Использование метода Fx() класса Raz
            Obj.Fx(Obj.a, Obj.b, Obj.h, listBox1);
        }
    }
}
