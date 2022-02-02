using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorywork6Variant27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обращение к классу branching
            branching Obj = new branching();

            Obj.c = Convert.ToDouble(textBox1.Text);
            Obj.y = Convert.ToDouble(textBox2.Text);
            Obj.x = Convert.ToDouble(textBox3.Text);
            Obj.z = Convert.ToDouble(textBox4.Text);

            Obj.l = Obj.systemSolution(Obj.c, Obj.y, Obj.x, Obj.z);

            // Очистка блока listBox1
            listBox1.Items.Clear();
            listBox1.Items.Add(Obj.l);
        }
    }
}
