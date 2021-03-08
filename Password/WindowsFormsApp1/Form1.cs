using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подсключение ссылки и конструктора
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            // Открытие новго Excel листа (Без заполнения содержимым)
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            // Активация листа
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            // Открытие документа
            //xla.GetOpenFilename();

            // Видимость Excel листа
            xla.Visible = true;

            ws.Cells[1, 1] = "First Name";
            ws.Cells[1, 2] = "Last Name";
            ws.Cells[1, 3] = "Address";
            ws.Cells[1, 4] = "City";
            ws.Cells[1, 5] = "Zip Code";
            ws.Cells[1, 6] = "State";

            ws.Cells[2, 1] = textBox1.Text;
            ws.Cells[2, 2] = textBox2.Text;
            ws.Cells[2, 3] = textBox3.Text;
            ws.Cells[2, 4] = textBox4.Text;
            ws.Cells[2, 5] = textBox5.Text;
            ws.Cells[2, 6] = textBox6.Text;


            // Постановка пароля на Excel файл:
            xla.Application.ActiveWorkbook.Password = "0000";
            // Сохранение файла:
            xla.Application.ActiveWorkbook.SaveAs("Exxel");
        }
    }
}
