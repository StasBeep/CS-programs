using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork11Var24
{
    public class Stroka
    {
        protected int dd;
        protected int mm;
        protected int yy;
        public int ForvardINT;
        private int[] MassMM;
        public int day;
        public int month;
        public int year;
        private void bissextile()
        {
            MassMM = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (yy % 4 == 0 && yy % 100 != 0)
                MassMM[1] = 29;
            if (yy % 100 == 0 && yy % 400 == 0)
                MassMM[1] = 29;
        }
        protected void MonthOperations()
        {
            bissextile();
            int differencedd = MassMM[mm - 1] - dd;
            if (ForvardINT > differencedd)
            {
                ForvardINT -= differencedd;
                mm++;
                dd = 1;
            }
            else
            {
                day = dd + ForvardINT;
                ForvardINT = 0;
                month = mm;
                year = yy;
            }
            while (ForvardINT >= 0)
            {
                if (mm > 12)
                {
                    mm = 1;
                    yy++;
                    bissextile();
                }
                if (MassMM[mm - 1] <= ForvardINT)
                {
                    ForvardINT -= MassMM[mm - 1];
                    mm++;
                }
                else
                {
                    day = dd + ForvardINT;
                    month = mm;
                    year = yy;
                    break;
                }
            }
        }
    }
    public class InputOutputCall:Stroka
    {
        public void CallPublMetod(string str)
        {
            dd = Convert.ToInt32(str.Substring(0, 2));
            mm = Convert.ToInt32(str.Substring(3, 2));
            yy = Convert.ToInt32(str.Substring(6, 4));
            MonthOperations();
        }
        public void Output(TextBox pro)
        {
            pro.Clear();
            string dayStr = day.ToString();
            string monthStr = month.ToString();
            if (day > 0 && day < 10)
                dayStr = "0" + day;
            if (month > 0 && month < 10)
                monthStr = "0" + month;
            pro.Text = dayStr + "." + monthStr + "." + year.ToString();
        }
    }
}
