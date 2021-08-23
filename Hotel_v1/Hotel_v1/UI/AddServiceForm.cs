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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            txbServiceName.Text = "";
            nbrAmount.Value = 1;
            nbrPrice.Value = 10000;
            cbxServiceName.DataSource = ServiceDAO.Instance.GetListService();
            cbxServiceName.DisplayMember = "name";
            cbxServiceName.ValueMember = "id";
            cbxServiceName.SelectedItem = null;

            categoryComboBox.DataSource = CategoryDAO.Instance.GetCategory();
            categoryComboBox.DisplayMember = "name";
            categoryComboBox.ValueMember = "id";
            categoryComboBox.SelectedItem = null;

            txbCurrentAmount.Text = "";
            nbrAddAmount.Value = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbServiceName.Text != "" && nbrAmount.Value != 0 && nbrPrice.Value != 0)
            {
                    ServiceDAO.Instance.InsertService(txbServiceName.Text,int.Parse(categoryComboBox.SelectedValue.ToString()), Convert.ToInt32(nbrPrice.Value), Convert.ToInt32(nbrAmount.Value));
                    MessageBox.Show("Add Service success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddService_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddAmount_Click(object sender, EventArgs e)
        {

            if (cbxServiceName.SelectedItem != null && txbCurrentAmount.Text != "")
            {
                int result = 0;
                if (int.TryParse(cbxServiceName.SelectedValue.ToString(), out result))
                {
                    ServiceDAO.Instance.incAmount(result, Convert.ToInt32(nbrAddAmount.Value));
                    MessageBox.Show("Increase Service success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddService_Load(this, null);
                }

            }
        }

        private void cbxServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxServiceName.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(cbxServiceName.SelectedValue.ToString(), out result))
                {
                    DataTable table = ServiceDAO.Instance.GetServiceID(result);
                    txbCurrentAmount.Text = table.Rows[0]["count"].ToString();
                }
            }
        }

    }
}
