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
    public partial class ManageRoomForm : Form
    {
        public ManageRoomForm()
        {
            InitializeComponent();

        }

        public void LoadRoom()
        {
            roomListBox.DataSource = RoomDAO.Instance.GetAllRoom();
            roomListBox.DisplayMember = "name";
            roomListBox.ValueMember = "name";
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chứ  ? ", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string name = roomListBox.SelectedValue.ToString();
                RoomDAO.Instance.DeleteRoom(name);
                MessageBox.Show("Đã Xóa "+name, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoom();
            }
           
        }

        private void ManageRoom_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }
    }
}
