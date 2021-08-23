using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Hotel_v1
{
    public partial class ProfitForm : Form
    {
        public ProfitForm()
        {
            InitializeComponent();
        }

        private void ProfitForm_Load(object sender, EventArgs e)
        {
            DataTable data = BillDAO.Instance.Static();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].DefaultCellStyle.Format = "M/dd/yyyy";
            staticChart.DataSource = data;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string temp = data.Rows[i][0].ToString();
                DateTime date = DateTime.ParseExact(temp, "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                staticChart.Series["Price"].Points.AddXY(date.ToString("M/dd/yyyy"), data.Rows[i][1].ToString());
            }
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                DataTable data = BillDAO.Instance.StaticByDay(dateTimePicker1.Value, dateTimePicker2.Value);
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].DefaultCellStyle.Format = "M/dd/yyyy";
                staticChart.Series.Clear();
                staticChart.DataSource = data;
                staticChart.Series.Add("Price");
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string temp = data.Rows[i][0].ToString();
                    DateTime date = DateTime.ParseExact(temp, "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    staticChart.Series["Price"].Points.AddXY(date.ToString("M/dd/yyyy"), data.Rows[i][1].ToString());
                }
            }
            else
            {
                DataTable data = BillDAO.Instance.Static();
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].DefaultCellStyle.Format = "M/dd/yyyy";
                staticChart.Series.Clear();
                staticChart.DataSource = data;
                staticChart.Series.Add("Price");
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string temp = data.Rows[i][0].ToString();
                    DateTime date = DateTime.ParseExact(temp, "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    staticChart.Series["Price"].Points.AddXY(date.ToString("M/dd/yyyy"), data.Rows[i][1].ToString());
                }
            }
        }
    }
}
