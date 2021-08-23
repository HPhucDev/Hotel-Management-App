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
    public partial class SalaryForDayForm : Form
    {
        Salary salary = new Salary();
        public SalaryForDayForm()
        {
            InitializeComponent();
        }
        private void SalaryForDayForm_Load(object sender, EventArgs e)
        {
            listsalaryDataGridView.DataSource = salary.showReport();
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            listsalaryDataGridView.DataSource = salary.showReport(date);
        }
    }
}
