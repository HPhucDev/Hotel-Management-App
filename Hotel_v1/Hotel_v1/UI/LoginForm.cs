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

namespace Hotel_v1
{
    public partial class LoginForm : Form
    {
        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public LoginForm()
        {
            InitializeComponent();

            ToolTip usernameToolTip = new ToolTip() { IsBalloon = true };
            usernameToolTip.ToolTipIcon = ToolTipIcon.Info;
            usernameToolTip.ToolTipTitle = "Nhap tai khoan dang nhap ";
            usernameToolTip.SetToolTip(usernameloginTextBox, "Hay nhap ten tai khoan ! ");

            ToolTip passwordToolTip = new ToolTip() { IsBalloon = true };
            passwordToolTip.ToolTipIcon = ToolTipIcon.Info;
            passwordToolTip.ToolTipTitle = "Nhap mat khau ";
            passwordToolTip.SetToolTip(passwordloginTextBox, "Hay nhap mat khau ! ");

        }
        #region Login 
        private void usernameloginTextBox_FILL(string username)
        {
            usernameloginTextBox.Text = username;
            usernameloginTextBox.ForeColor = Color.Black;
        }
        private void passwordloginTextBox_FILL(string password)
        {
            passwordloginTextBox.Text = password;
            passwordloginTextBox.UseSystemPasswordChar = true;
            passwordloginTextBox.ForeColor = Color.Black;
        }
        private void usernameloginTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameloginTextBox.Text == "Username")
            {
                usernameloginTextBox.Text = "";
                usernameloginTextBox.ForeColor = Color.Black;
            }
        }
        private void usernameloginTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameloginTextBox.Text == "")
            {
                usernameloginTextBox.Text = "Username";
                usernameloginTextBox.ForeColor = Color.Silver;
            }
        }
        private void usernameloginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                passwordloginTextBox.Focus();
            }
        }
        private void passwordloginTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordloginTextBox.Text == "Password")
            {
                passwordloginTextBox.Text = "";
                passwordloginTextBox.ForeColor = Color.Black;
                passwordloginTextBox.UseSystemPasswordChar = true;
            }
        }
        private void passwordloginTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordloginTextBox.Text == "")
            {
                passwordloginTextBox.Text = "Password";
                passwordloginTextBox.ForeColor = Color.Silver;
                passwordloginTextBox.UseSystemPasswordChar = false;
            }
        }
        private void passwordloginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                loginButton_Click(sender, e);
            }
        }
        private void showpasswordPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            passwordloginTextBox.UseSystemPasswordChar = false;
        }
        private void showpasswordPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            passwordloginTextBox.UseSystemPasswordChar = true;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Base db = new Data_Base();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Account WHERE Username = @User AND Password = @Pass   ", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = usernameloginTextBox.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = passwordloginTextBox.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Type = table.Rows[0]["Type"].ToString();
                    Global.setGlobalUserID(int.Parse(table.Rows[0]["UserID"].ToString()));
                    Global.setGlobalUserType(this.Type);
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password ! ", "Notice");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice ");
            }
        }

        #endregion
       /* #region Signin
        private void idsigninTextBox_Enter(object sender, EventArgs e)
        {
            if (idsigninTextBox.Text == "ID")
            {
                idsigninTextBox.Text = "";
                idsigninTextBox.ForeColor = Color.Black;
            }
        }
        private void idsigninTextBox_Leave(object sender, EventArgs e)
        {
            if (idsigninTextBox.Text == "")
            {
                idsigninTextBox.Text = "ID";
                idsigninTextBox.ForeColor = Color.Silver;
            }
        }
        private void idsigninTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                displaynamesigninTextBox.Focus();
            }
        }
        private void displaynamesigninTextBox_Enter(object sender, EventArgs e)
        {
            if (displaynamesigninTextBox.Text == "Name")
            {
                displaynamesigninTextBox.Text = "";
                displaynamesigninTextBox.ForeColor = Color.Black;
            }
        }
        private void displaynamesigninTextBox_Leave(object sender, EventArgs e)
        {
            if (displaynamesigninTextBox.Text == "")
            {
                displaynamesigninTextBox.Text = "Name";
                displaynamesigninTextBox.ForeColor = Color.Silver;
            }
        }
        private void displaynamesigninTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                usernamesigninTextBox.Focus();
            }
        }
        private void usernamesigninTextBox_Enter(object sender, EventArgs e)
        {
            if (usernamesigninTextBox.Text == "Username")
            {
                usernamesigninTextBox.Text = "";
                usernamesigninTextBox.ForeColor = Color.Black;
            }
        }
        private void usernamesigninTextBox_Leave(object sender, EventArgs e)
        {
            if (usernamesigninTextBox.Text == "")
            {
                usernamesigninTextBox.Text = "Username";
                usernamesigninTextBox.ForeColor = Color.Silver;
            }
        }
        private void usernamesigninTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                passwordsigninTextBox.Focus();
            }
        }
        private void passwordsigninTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordsigninTextBox.Text == "Password")
            {
                passwordsigninTextBox.Text = "";
                passwordsigninTextBox.ForeColor = Color.Black;
            }
        }
        private void passwordsigninTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordsigninTextBox.Text == "")
            {
                passwordsigninTextBox.Text = "Password";
                passwordsigninTextBox.ForeColor = Color.Silver;
            }
        }
        private void passwordsigninTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                codesigninTextBox.Focus();
            }
        }
        private void codesigninTextBox_Enter(object sender, EventArgs e)
        {
            if (codesigninTextBox.Text == "Code")
            {
                codesigninTextBox.Text = "";
                codesigninTextBox.ForeColor = Color.Black;
            }
        }
        private void codesigninTextBox_Leave(object sender, EventArgs e)
        {
            if (codesigninTextBox.Text == "")
            {
                codesigninTextBox.Text = "Code";
                codesigninTextBox.ForeColor = Color.Silver;
            }
        }
        private void codesigninTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                signinButton_Click(sender, e);
            }
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            Nhanvien staff = new Nhanvien();
            int id = int.Parse(idsigninTextBox.Text);
            string username = usernamesigninTextBox.Text;
            string displayname = displaynamesigninTextBox.Text;
            string password = passwordsigninTextBox.Text;
            string code = codesigninTextBox.Text;
            string type;
            if (code == "22032001")
                type = "admin";
            else
                if (code == "19110052")
                type = "manager";
            else
                    if (code == "19110399")
                type = "receptionist";
            else
                type = "laborer";
            if (verif())
            {
                if (true)
                {
                    DialogResult result = MessageBox.Show("You Have Signed Up Successfully ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        usernameloginTextBox_FILL(username);
                        passwordloginTextBox_FILL(password);
                        idsigninTextBox.Text = "ID";
                        idsigninTextBox.ForeColor = Color.Silver;
                        displaynamesigninTextBox.Text = "Name";
                        displaynamesigninTextBox.ForeColor = Color.Silver;
                        usernamesigninTextBox.Text = "Username";
                        usernamesigninTextBox.ForeColor = Color.Silver;
                        passwordsigninTextBox.Text = "Password";
                        passwordsigninTextBox.ForeColor = Color.Silver;
                        codesigninTextBox.Text = "Code";
                        codesigninTextBox.ForeColor = Color.Silver;
                    }
                }
                else
                {
                    MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                MessageBox.Show("Empty Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        bool verif()
        {
            if (usernamesigninTextBox.Text.Trim() == "" || passwordsigninTextBox.Text.Trim() == "" || displaynamesigninTextBox.Text.Trim() == "")
                return false;
            else
                return true;
        }
        #endregion*/
    }

}
