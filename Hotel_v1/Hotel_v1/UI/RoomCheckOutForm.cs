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

namespace Hotel_v1
{
    public partial class RoomCheckOut : Form
    {


        BillPrint bill = new BillPrint();
        public List<Menu> menu = new List<Menu>();
        float totalprice = 0;
        public RoomCheckOut()
        {
            InitializeComponent();
        }
        public void LoadRoom()
        {
            List<Room> listRoom = RoomDAO.Instance.LoadRoomList();
            roomComboBox.DataSource = listRoom;
            roomComboBox.DisplayMember = "name";
            roomComboBox.ValueMember = "id";
            roomComboBox.SelectedItem = null;
        }
        private void RoomCheckOut_Load(object sender, EventArgs e)
        {

            DateTime d = DateTime.Now;
            if (d.Hour >= 12)
            {
                d = DateTime.Now.AddDays(1);
            }
            string date = d.ToString("yyyy-MM-dd");
            string time = ("12:00:00");
            DateTime currentDate = DateTime.ParseExact(date + " " + time, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            txbCurrent.Text = currentDate.ToString("yyyy-MM-dd HH:mm:ss");
            LoadRoom();
            
        }
        void ShowBillRoom(int id)
        {
            DataTable data = CustomerDAO.Instance.GetCustomerByRoom(id);
            customerDataGridView.DataSource = data;
        }
        void ShowRoom(int id)
        {
            DataTable data = CustomerDAO.Instance.GetCustomer(id);
            customerDataGridView.DataSource = data;
        }
        public float ShowBill(int id)
        {
            if (lsvBill != null)
            {
                lsvBill.Items.Clear();
            }
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByRoom(id);
            menu = listBillInfo;
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
            return totalPrice;
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomComboBox.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(roomComboBox.SelectedValue.ToString(), out result))
                {
                    DataTable data = RoomDAO.Instance.CheckRoom(result);
                    if (data.Rows[0][0].ToString() == "Trống")
                    {
                        MessageBox.Show("This Room is Empty", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ShowBill(result);
                        ShowBillRoom(result);
                    }
                }

            }
        }
        private void checkoutButton_Click(object sender, EventArgs e)
        {

            if (roomComboBox.SelectedItem != null)
            {
                int result = 0;
                if (int.TryParse(roomComboBox.SelectedValue.ToString(), out result))
                {
                    DateTime d = DateTime.Now;
                    if (d.Hour >= 12)
                    {
                        d = DateTime.Now.AddDays(1);
                    }
                    string date = d.ToString("yyyy-MM-dd");
                    string time = ("12:00:00");
                    DateTime currentDate = DateTime.ParseExact(date + " " + time, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    txbCurrent.Text = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

                    CustomerDAO.Instance.checkoutCustomer(result, currentDate, 1);
                    RoomDAO.Instance.UpdateRoom(result, "Trống");
                    

                    string daycheckin = this.customerDataGridView.CurrentRow.Cells[2].Value.ToString();
                    DateTime checkin = DateTime.ParseExact(daycheckin, "M/dd/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime checkout = DateTime.ParseExact(txbCurrent.Text, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    TimeSpan span = checkout.Subtract(checkin);
                    if ((span.Days + 1) > 1)
                    {
                        dayLabel.Text = (span.Days +1).ToString() + " Days ";
                    }
                    else
                        dayLabel.Text = (span.Days +1).ToString() + " Day ";
                    CultureInfo culture = new CultureInfo("vi-VN");
                    float totalday = ( span.Days +1 ) * 220000;
                    totalroomTextBox.Text = totalday.ToString("c", culture);
                    float totalbill = ShowBill(result);
                    totalprice = totalday + totalbill;
                    totalpriceTextBox.Text = totalprice.ToString("c", culture);

                    BillDAO.Instance.CheckOut(BillDAO.Instance.GetMaxIDBill(), checkout, totalprice, 1);

                    bill.checkin = checkin.ToString("yyyy-MM-dd");
                    bill.checkout = checkout.ToString("yyyy-MM-dd");
                    bill.room = roomComboBox.Text;
                    bill.numberday = (span.Days + 1).ToString();
                    bill.totalpriceday = totalday.ToString();
                    bill.menu =menu ;
                    bill.total = totalprice.ToString();

                }
            }
        }
        private void thanhtoanButton_Click(object sender, EventArgs e)
        {
            bill.ShowDialog();
            this.Close();
        }
    }
}
