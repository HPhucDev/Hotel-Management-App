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
    public partial class ArchiveForm : Form
    {
        public ArchiveForm()
        {
            InitializeComponent();
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            archiveDataGridView.DataSource = ServiceDAO.Instance.GetArchieve();

            categoryComboBox.DataSource = CategoryDAO.Instance.GetCategory();
            categoryComboBox.DisplayMember = "name";
            categoryComboBox.ValueMember = "id";
            categoryComboBox.SelectedItem = null;

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(categoryComboBox.SelectedValue.ToString(), out result))
                {
                    DataTable table = ServiceDAO.Instance.GetArchiveByIDCategory(result);
                    archiveDataGridView.DataSource = table;
                }
                else
                {
                    archiveDataGridView.DataSource = ServiceDAO.Instance.GetArchieve();
                }
            }
        }
    }
}
