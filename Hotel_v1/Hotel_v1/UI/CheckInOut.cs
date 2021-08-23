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
    public partial class CheckInOut : Form
    {
        public CheckInOut()
        {
            InitializeComponent();
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            if (salary.CheckIn(Global.globalUserID) == true)
            {
                MessageBox.Show("CheckIn Successed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("You Must CheckOut ", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure CheckOut?", "notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Salary salary = new Salary();
                if (salary.CheckOut(Global.globalUserID) == true)
                {
                    MessageBox.Show("CheckOut Successed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You Must CheckIn ", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
    }
}
