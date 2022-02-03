using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorywork10Variant27
{
    public partial class Form1 : Form
    {
        // подключение класса operations для всех точек
        ResInpOut Obj = new ResInpOut();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Obj.N = Convert.ToInt32(textBox1.Text);
            Obj.A = Obj.InpMatrix(listBox1);
            Obj.B = Obj.InpMatrix(listBox2);
            Obj.C = Obj.InpMatrix(listBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obj.purpose(Obj.A, Obj.B ,Obj.C, listBox4);
        }
    }
}
