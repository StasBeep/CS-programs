using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork10Var24
{
    public partial class Form1 : Form
    {
        InpOutResCall pro = new InpOutResCall();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            ClientSize = new System.Drawing.Size(440,360);
            label3.Visible = true;
            label4.Visible = true;
            button3.Visible = true;
            groupBox1.Visible = true;
            pro.M = Convert.ToInt32(textBox3.Text);
            pro.N = Convert.ToInt32(textBox2.Text);
            pro.InputZ();
            pro.OutputTWO(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(535, 360);
            groupBox2.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            pro.EnterCall();
            pro.OutputONE(listBox2,textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            ClientSize = new System.Drawing.Size(440, 360);
            label3.Visible = true;
            label4.Visible = true;
            button3.Visible = true;
            groupBox1.Visible = true;
            pro.M = Convert.ToInt32(textBox3.Text);
            pro.N = Convert.ToInt32(textBox2.Text);
            pro.InputR();
            pro.OutputTWO(listBox1);
        }
    }
}
