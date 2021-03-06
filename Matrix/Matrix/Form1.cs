using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class2 xcv = new Class2();

        private void button1_Click(object sender, EventArgs e)
        {
            xcv.n = Convert.ToInt32(textBox1.Text);
            xcv.InpZ();
            xcv.OutP(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xcv.n = Convert.ToInt32(textBox1.Text);
            xcv.InpD();
            xcv.OutP(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xcv.metod();
            xcv.OutP(listBox2);
        }
    }
}
