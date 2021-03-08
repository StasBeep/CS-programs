using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork11Var24
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
            InputOutputCall pro = new InputOutputCall();
            string s = textBox1.Text;
            pro.ForvardINT = Convert.ToInt32(textBox2.Text);
            pro.CallPublMetod(s);
            pro.Output(textBox3);
        }
    }
}
