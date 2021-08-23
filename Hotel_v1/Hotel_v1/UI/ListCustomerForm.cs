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
    public partial class ListCustomerForm : Form
    {
        public ListCustomerForm()
        {
            InitializeComponent();
        }

        private void ListCustomerForm_Load(object sender, EventArgs e)
        {
            listcustomerDataGridView.DataSource = CustomerDAO.Instance.GetAllCustomer();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listcustomerDataGridView.DataSource = CustomerDAO.Instance.search(txbSearch.Text);
        }
    }
}
