using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Hotel_v1
{
    public partial class RoomCheckIn : Form
    {
        public RoomCheckIn()
        {
            InitializeComponent();
        }
        private void RoomCheckIn_Load(object sender, EventArgs e)
        {
            //Get Checkin DateTime (alway 14:00:00)
            DateTime d = DateTime.Now;
            if (d.Hour <= 14)
            {
                d = DateTime.Now.AddDays(-1);
            }
            string date = d.ToString("yyyy-MM-dd");
            string time = ("14:00:00");
            DateTime currentDate = DateTime.ParseExact(date + " " + time, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            txbCurrent.Text = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

            LoadRoom();
            customerGroupBox.Show();
            customerGroupBox2.Hide();

            LoadCategory();
        }
        public void LoadRoom()
        {
            DataTable data1 = RoomDAO.Instance.GetAllRoom();
            roomlistComboBox.DataSource = data1;
            roomlistComboBox.DisplayMember = "name";
            roomlistComboBox.ValueMember = "id";
        }
        private void bookButton_Click(object sender, EventArgs e)
        {
          
                int idroom = int.Parse(roomlistComboBox.SelectedValue.ToString());
                string fname = firstnameTextBox.Text;
                string lname = lastnameTextBox.Text;
                string cmnd = cmndTextBox.Text;
                string sex = sexComboBox.Text;
                string phone = phoneTextBox.Text;
                string address = addressTextBox.Text;
                DateTime currentDate = DateTime.ParseExact(txbCurrent.Text, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                MemoryStream picture = new MemoryStream();
                pictureBox.Image.Save(picture, pictureBox.Image.RawFormat);
                CustomerDAO.Instance.InsertCustomerCheckIn(idroom, BillDAO.Instance.GetMaxIDBill(), fname, lname, cmnd, sex, phone, address, picture, currentDate, 0);
                if (memberComboBox.Text == "2")
                {
                    string fname2 = firstnameTextBox2.Text;
                    string lname2 = lastnameTextBox2.Text;
                    string cmnd2 = cmndTextBox2.Text;
                    string sex2 = sexComboBox2.Text;
                    string phone2 = phoneTextBox2.Text;
                    string address2 = addressTextBox2.Text;
                    MemoryStream picture2 = new MemoryStream();
                    pictureBox2.Image.Save(picture2, pictureBox2.Image.RawFormat);
                    CustomerDAO.Instance.InsertCustomerCheckIn(idroom, BillDAO.Instance.GetMaxIDBill(), fname2, lname2, cmnd2, sex2, phone2, address2, picture2, currentDate, 0);
                }
                string status = "Đầy";
                RoomDAO.Instance.UpdateRoom(idroom, status);
                MessageBox.Show("Booked", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

          
        }
        private void memberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberComboBox.Text == "1")
                customerGroupBox2.Hide();
            if (memberComboBox.Text == "2")
            {
                customerGroupBox2.Show();
            }
        }
        void LoadCategory()
        {
            DataTable listCategory = CategoryDAO.Instance.GetAllCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
            cbCategory.ValueMember = "id";
            cbCategory.SelectedItem = null;
        }
        void LoadServiceListByCategoryID(int id)
        {
            DataTable listService = ServiceDAO.Instance.GetServiceByCategory(id);
            cbService.DataSource = listService;
            cbService.DisplayMember = "name";
            cbService.ValueMember = "id";
            cbService.SelectedItem = null;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCategory.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(cbCategory.SelectedValue.ToString(), out result))
                {
                    LoadServiceListByCategoryID(result);
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int room = int.Parse(roomlistComboBox.SelectedValue.ToString());
            int idBill = BillDAO.Instance.GetUncheckBillIDByRoomID(room);
            int serviceID = int.Parse(cbService.SelectedValue.ToString());
            int count = (int)nmserviceCount.Value;

            ServiceDAO.Instance.decAmount(serviceID, count);
           
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(room);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), serviceID, count);

            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, serviceID, count);
            }
            ShowBill(room);
        }           
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByRoom(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image(*.jpg;*.png;*.gif)|*.jpg;*.pgn;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image(*.jpg;*.png;*.gif)|*.jpg;*.pgn;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("staff_" + firstnameTextBox.Text + "_" + lastnameTextBox.Text);
            if ((pictureBox == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("staff_" + firstnameTextBox2.Text + "_" + lastnameTextBox2.Text);
            if ((pictureBox2 == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox2.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void nmserviceCount_ValueChanged(object sender, EventArgs e)
        {
            if (nmserviceCount.Value > nmserviceCount.Maximum)
            {
                nmserviceCount.Value = nmserviceCount.Maximum;
            }
        }
        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbService.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(cbService.SelectedValue.ToString(), out result))
                {
                    DataTable table = ServiceDAO.Instance.GetServiceID(result);
                    nmserviceCount.Maximum = Convert.ToDecimal(table.Rows[0]["count"].ToString());
                }
            }
        }
        private void roomlistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomlistComboBox.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(roomlistComboBox.SelectedValue.ToString(), out result))
                {
                    DataTable data = RoomDAO.Instance.CheckRoom(result);
                    if (data.Rows[0]["status"].ToString() == "Đầy")
                    {
                        MessageBox.Show("This Room is Full", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
