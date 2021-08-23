using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Hotel_v1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int value;
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRoom();
            LoadUser();
            timer.Start();
            if (Global.globalUserType == "Labor")
            {
                quảnLíPhòngToolStripMenuItem.Visible = false;
                thêmXóaSửaNhânViênToolStripMenuItem.Visible = false;
                quảnLíKháchHàngToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                lịchLàmViệcToolStripMenuItem.Visible = false;
                flpRoom.Visible = false;
            }
            else if(Global.globalUserType== "Reception")
            {
                thêmPhòngToolStripMenuItem1.Visible = false;
                xóaPhòngToolStripMenuItem1.Visible = false;
                dịchVụToolStripMenuItem.Visible = false;
                thêmXóaSửaNhânViênToolStripMenuItem.Visible = false;
                lịchLàmViệcToolStripMenuItem.Visible = false;
            }
        }
        void LoadUser()
        {
            Nhanvien user = new Nhanvien();
            DataTable data = user.getUser(Global.globalUserID);
            if (data.Rows.Count > 0)
            {
                byte[] pic = (byte[])data.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                avatarPictureBox.Image = Image.FromStream(picture);
                nameLabel.Text = "" + data.Rows[0]["Fname"].ToString() + " " + data.Rows[0]["Lname"].ToString();
                typeLabel.Text = "( " + data.Rows[0]["Type"].ToString()+ " )";
            }
        }
        void LoadRoom()
        {
            flpRoom.Controls.Clear();

            List<Room> RoomList = RoomDAO.Instance.LoadRoomList();
            foreach (Room item in RoomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        btn.Click += btn_OpenCheckIn;
                        break;
                    default:
                        btn.BackColor = Color.PaleVioletRed;
                        btn.Click += btn_OpenCheckOut;
                        break;
                }
                flpRoom.Controls.Add(btn);
            }
        }
        void btn_OpenCheckIn(object sender, EventArgs e)
        {
            RoomCheckIn roomCheckIn = new RoomCheckIn();
            roomCheckIn.ShowDialog();
            LoadRoom();
        }
        void btn_OpenCheckOut(object sender, EventArgs e)
        {
            RoomCheckOut roomCheckOut = new RoomCheckOut();
            roomCheckOut.ShowDialog();
            LoadRoom();

        }
        private void lịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarForm frmCalendar = new CalendarForm();
            this.Hide();
            frmCalendar.ShowDialog();
            this.Show();
        }

        private void thêmXóaSửaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageNhanVien frmQLNV = new ManageNhanVien();
            this.Hide();
            frmQLNV.ShowDialog();
            this.Show();
        }
        private void thêmPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Room> RoomList = RoomDAO.Instance.LoadRoomList();
            string name = "Room " + (RoomList.Count + 1);
            string status = "Trống";
            RoomDAO.Instance.InsertRoom(name, status);
            LoadRoom();
        }

        private void xóaPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageRoomForm manageRoom = new ManageRoomForm();
            manageRoom.ShowDialog();
            LoadRoom();
        }

        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();
        }

        private void cậpNhậtDịchVỤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateServiceForm updateService = new UpdateServiceForm();
            updateService.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInOut checkInOut = new CheckInOut();
            checkInOut.ShowDialog();
        }


        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            secondLabel.Text = DateTime.Now.ToString("ss");
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchiveForm archive = new ArchiveForm();
            archive.Show();
        }

        private void danhSaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomerForm listCustomerForm = new ListCustomerForm();
            listCustomerForm.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.updateSalaryLabor();
            salary.updateSalaryReception();
            SalaryForDayForm salaryForDayForm = new SalaryForDayForm();
            salaryForDayForm.ShowDialog();
        }

        private void mycalenderLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyCalendar myCalendar = new MyCalendar();
            myCalendar.Show();
        }
        private void thuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProfitForm profitForm = new ProfitForm();
            profitForm.Show();
        }

        private void chiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisbursementForm disbursement = new DisbursementForm();
            disbursement.Show();
        }
    }
}
