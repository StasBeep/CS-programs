using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba12Var24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = openFileDialog1.FileName;
                StreamReader yk = new StreamReader(data);
                string Onedata = yk.ReadToEnd();
                yk.Close();
                textBox2.Text = Onedata;
            }
        }
        StrInPOut pro = new StrInPOut();
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string DataRead = openFileDialog1.FileName;
                StreamReader yk = new StreamReader(DataRead);
                while (!yk.EndOfStream)
                {
                    pro.s = yk.ReadLine();
                    pro.CallPublMetod(pro.s);
                    pro.OutPut(listBox1);
                    listBox2.Items.Add(pro.s);
                }
                yk.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveText = new SaveFileDialog();
            if(SaveText.ShowDialog() == DialogResult.OK)
            {
                string str = SaveText.FileName;
                StreamWriter Wrt = new StreamWriter(str);
                for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                    Wrt.WriteLine(listBox1.Items[i]);
                Wrt.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
