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
    public partial class UpdateServiceForm : Form
    {
        public UpdateServiceForm()
        {
            InitializeComponent();
        }

        private void UpdateServiceForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadService();
            servicenamereplaceTextBox.Text = null;
        }
        public void LoadService()
        {
            servicenameComboBox.DataSource = ServiceDAO.Instance.GetService();
            servicenameComboBox.DisplayMember = "name";
            servicenameComboBox.ValueMember = "id";
            servicenameComboBox.SelectedItem = null;
        } 
        public void LoadCategory()
        {
            categoryComboBox.DataSource = CategoryDAO.Instance.GetCategory();
            categoryComboBox.DisplayMember = "name";
            categoryComboBox.ValueMember = "id";
            categoryComboBox.SelectedItem = null;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string servicenamereplace = servicenamereplaceTextBox.Text.Trim();
            string servicename = servicenameComboBox.Text;
            int idname = int.Parse(servicenameComboBox.SelectedValue.ToString());
            int idcategory = int.Parse(categoryComboBox.SelectedValue.ToString());
            float price =float.Parse(priceTextBox.Text.ToString());
            if (checkRadioButton.Checked==false)
            {
                ServiceDAO.Instance.UpdateService(idname, servicename, idcategory, price);
                MessageBox.Show("Đã Cập nhật Dịch Vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadService();
            }
            else
            {
                ServiceDAO.Instance.UpdateService(idname, servicenamereplace, idcategory, price);
                MessageBox.Show("Đã Cập nhật Dịch Vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadService();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chứ  ? ", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                int idname = int.Parse(servicenameComboBox.SelectedValue.ToString());
                ServiceDAO.Instance.DeleteService(idname);
                MessageBox.Show("Đã Xóa Dịch Vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadService();
            }  
        }

        private void servicenameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (servicenameComboBox.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(servicenameComboBox.SelectedValue.ToString(), out result))
                {
                    DataTable table = ServiceDAO.Instance.GetServiceID(result);
                    categoryComboBox.Text = table.Rows[0]["category"].ToString();
                    priceTextBox.Text = table.Rows[0]["price"].ToString();

                }
            }
        }
    }
}
