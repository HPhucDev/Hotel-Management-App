using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Hotel_v1
{
    public partial class ManageNhanVien : Form
    {
        Nhanvien nhanvien = new Nhanvien();
        public ManageNhanVien()
        {
            InitializeComponent();
        }

        private void txbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbID.Text != "" && txbPassword.Text != "" && cbBoxType.SelectedItem != null && txbFname.Text != "" && txbLname.Text != "" && txbAddress.Text != "" && txbPhone.Text != "" && picBoxImage.Image != null)
                {
                    string id = txbID.Text;
                    string password = txbPassword.Text;
                    string type = cbBoxType.SelectedItem.ToString();
                    string fname = txbFname.Text;
                    string lname = txbLname.Text;
                    string address = txbAddress.Text;
                    string phone = txbPhone.Text;
                    MemoryStream picture = new MemoryStream();
                    picBoxImage.Image.Save(picture, picBoxImage.Image.RawFormat);
                    if (nhanvien.insertNhanvien(id, fname, lname, address, phone, picture, password, type))
                    {
                        MessageBox.Show("New Staff Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image(*.jpg;*.png;*.gif)|*.jpg;*.pgn;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("staff_" + txbFname.Text+"_"+txbLname.Text);
            if ((picBoxImage == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                picBoxImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbPassword.Text = "";
            cbBoxType.SelectedItem = null;
            txbAddress.Text = "";
            txbPhone.Text = "";
            txbFname.Text = "";
            txbLname.Text = "";
            picBoxImage.Image = null;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = nhanvien.getAllNhanvien();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "First Name";
            dataGridView1.Columns[3].HeaderText = "Last Name";
            dataGridView1.Columns[7].Visible = false;//password
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txbID.Text != "" && txbPassword.Text != "" && cbBoxType.SelectedItem != null && txbFname.Text != "" && txbLname.Text != "" && txbAddress.Text != "" && txbPhone.Text != "" && picBoxImage.Image != null)
                {
                    string id = txbID.Text;
                    string password = txbPassword.Text;
                    string type = cbBoxType.SelectedItem.ToString();
                    string fname = txbFname.Text;
                    string lname = txbLname.Text;
                    string address = txbAddress.Text;
                    string phone = txbPhone.Text;
                    MemoryStream picture = new MemoryStream();
                    picBoxImage.Image.Save(picture, picBoxImage.Image.RawFormat);
                    if (nhanvien.updateNhanvien(id, fname, lname, address, phone, picture, password, type))
                    {
                        MessageBox.Show("Staff Have Been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                txbID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txbPassword.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cbBoxType.SelectedItem = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txbAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txbPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txbFname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txbLname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                byte[] pic;
                pic = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
                MemoryStream picture = new MemoryStream(pic);
                picBoxImage.Image = Image.FromStream(picture);
            }
            catch(Exception ex)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien_Load(this, null);
            txbSearch.Text = "";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbID.Text != "")
                {
                    string id = txbID.Text;
            
                    if (nhanvien.deleteNhanvien(id))
                    {
                        MessageBox.Show("Staff Have Been Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyNhanVien_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("enter a ID", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.search(txbSearch.Text);
        }
    }
}
