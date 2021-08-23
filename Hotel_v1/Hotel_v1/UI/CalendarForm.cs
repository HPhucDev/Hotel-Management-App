using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_v1
{
    public partial class CalendarForm : Form
    {
        Nhanvien employee = new Nhanvien();
        public CalendarForm()
        {
            InitializeComponent();
        }
        static int gcf(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int lcm(int a, int b)
        {
            return (a / gcf(a, b)) * b;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtMa, dtRe, dtLa = new DataTable();
            dtMa = employee.getManager();
            dtRe = employee.getReception();
            dtLa = employee.getLabor();
            string[] arrMa = dtMa.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            string[] arrRe = dtRe.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            string[] arrLa = dtLa.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            int lengthMa = arrMa.Length;
            int lengthRe = arrRe.Length;
            int lengthLa = arrLa.Length;
            int indexMa = 0;
            int indexRe = 0;
            int indexLa = 0;
            DateTime dayMa = DateTime.Now;
            DateTime dayRe = DateTime.Now;
            DateTime dayLa = DateTime.Now;
            int countMa = 0;
            int countRe = 0;
            int countLa = 0;
            //Manager
            while (countMa != lcm(lcm(lengthMa, lengthRe), lengthLa))
            {
                indexMa %= lengthMa;
                int temp = indexMa;
                int inc = 0;
                for (int i = 0; i < 2; i++)
                {
                    if (i >= 1)
                    {
                        employee.insertCalendar(Convert.ToInt32(arrMa[(temp + inc) % lengthMa]), "Afternoon", dayMa);
                    }
                    else
                    {
                        employee.insertCalendar(Convert.ToInt32(arrMa[(temp + inc) % lengthMa]), "Morning", dayMa);
                    }
                    inc++;
                }
                employee.insertCalendar(Convert.ToInt32(arrMa[temp]), "Night", dayMa);
                indexMa++;
                dayMa = dayMa.AddDays(1);
                countMa++;
            }
            //Reception
            while (countRe != lcm(lcm(lengthMa, lengthRe), lengthLa))
            {
                indexRe %= lengthRe;
                int temp = indexRe;
                int inc = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (i >= 2)
                    {
                        employee.insertCalendar(Convert.ToInt32(arrRe[(temp + inc) % lengthRe]), "Afternoon", dayRe);
                    }
                    else
                    {
                        employee.insertCalendar(Convert.ToInt32(arrRe[(temp + inc) % lengthRe]), "Morning", dayRe);
                    }
                    inc++;
                }
                employee.insertCalendar(Convert.ToInt32(arrRe[temp]), "Night", dayRe);
                indexRe++;
                dayRe = dayRe.AddDays(1);
                countRe++;
            }
            //Labor
            while (countLa != lcm(lcm(lengthMa, lengthRe), lengthLa))
            {
                indexLa %= lengthLa;
                int temp = indexLa;
                int inc = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (i >= 4)
                    {
                        employee.insertCalendar(Convert.ToInt32(arrLa[(temp + inc) % lengthLa]), "Afternoon", dayLa);
                    }
                    else
                    {
                        employee.insertCalendar(Convert.ToInt32(arrLa[(temp + inc) % lengthLa]), "Morning", dayLa);
                    }
                    inc++;
                }
                employee.insertCalendar(Convert.ToInt32(arrLa[temp]), "Night", dayLa);
                indexLa++;
                dayLa = dayLa.AddDays(1);
                countLa++;
            }
            dataGridView1.DataSource = employee.getCalendar();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employee.getTodayCalendar();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            dataGridView1.DataSource = employee.getTodayCalendar();
            if (dataGridView1.Rows.Count == 0)
            {
                btnAdd.Enabled = true;
            }
        }

        private void btn7day_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employee.get7dayCalendar();
        }

        private void CalendarForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                CalendarForm_Load(this, null);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txbUserID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txbUserID.Text != "")
            {
                dataGridView1.DataSource = employee.findCalendar(Convert.ToInt32(txbUserID.Text));
            }
        }
    }
}
