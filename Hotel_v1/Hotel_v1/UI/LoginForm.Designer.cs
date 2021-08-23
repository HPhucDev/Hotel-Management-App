
namespace Hotel_v1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotusernameLabel = new System.Windows.Forms.Label();
            this.usernameloginTextBox = new System.Windows.Forms.TextBox();
            this.hotelLabel = new System.Windows.Forms.Label();
            this.passwordloginTextBox = new System.Windows.Forms.TextBox();
            this.showpasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.loginTabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showpasswordPictureBox)).BeginInit();
            this.loginTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel_v1.Properties.Resources.blurred_double_bed_with_furnitures;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1441, 953);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // loginTabPage
            // 
            this.loginTabPage.Controls.Add(this.showpasswordPictureBox);
            this.loginTabPage.Controls.Add(this.passwordloginTextBox);
            this.loginTabPage.Controls.Add(this.usernameloginTextBox);
            this.loginTabPage.Controls.Add(this.hotelLabel);
            this.loginTabPage.Controls.Add(this.forgotusernameLabel);
            this.loginTabPage.Controls.Add(this.loginButton);
            this.loginTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTabPage.Location = new System.Drawing.Point(8, 39);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(968, 676);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "LOG IN";
            this.loginTabPage.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(194, 434);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(548, 84);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = " LOG IN";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotusernameLabel
            // 
            this.forgotusernameLabel.AutoSize = true;
            this.forgotusernameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.forgotusernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotusernameLabel.Location = new System.Drawing.Point(189, 558);
            this.forgotusernameLabel.Name = "forgotusernameLabel";
            this.forgotusernameLabel.Size = new System.Drawing.Size(0, 29);
            this.forgotusernameLabel.TabIndex = 4;
            // 
            // usernameloginTextBox
            // 
            this.usernameloginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameloginTextBox.ForeColor = System.Drawing.Color.Silver;
            this.usernameloginTextBox.Location = new System.Drawing.Point(194, 191);
            this.usernameloginTextBox.Name = "usernameloginTextBox";
            this.usernameloginTextBox.Size = new System.Drawing.Size(548, 56);
            this.usernameloginTextBox.TabIndex = 1;
            this.usernameloginTextBox.Text = "Username";
            this.usernameloginTextBox.Enter += new System.EventHandler(this.usernameloginTextBox_Enter);
            this.usernameloginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameloginTextBox_KeyPress);
            this.usernameloginTextBox.Leave += new System.EventHandler(this.usernameloginTextBox_Leave);
            // 
            // hotelLabel
            // 
            this.hotelLabel.AutoSize = true;
            this.hotelLabel.Font = new System.Drawing.Font("Segoe Script", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLabel.Location = new System.Drawing.Point(332, 48);
            this.hotelLabel.Name = "hotelLabel";
            this.hotelLabel.Size = new System.Drawing.Size(284, 119);
            this.hotelLabel.TabIndex = 6;
            this.hotelLabel.Text = "Hotel ";
            // 
            // passwordloginTextBox
            // 
            this.passwordloginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordloginTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordloginTextBox.Location = new System.Drawing.Point(194, 300);
            this.passwordloginTextBox.Name = "passwordloginTextBox";
            this.passwordloginTextBox.Size = new System.Drawing.Size(548, 56);
            this.passwordloginTextBox.TabIndex = 7;
            this.passwordloginTextBox.Text = "Password";
            this.passwordloginTextBox.Enter += new System.EventHandler(this.passwordloginTextBox_Enter);
            this.passwordloginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordloginTextBox_KeyPress);
            this.passwordloginTextBox.Leave += new System.EventHandler(this.passwordloginTextBox_Leave);
            // 
            // showpasswordPictureBox
            // 
            this.showpasswordPictureBox.Image = global::Hotel_v1.Properties.Resources._65000;
            this.showpasswordPictureBox.Location = new System.Drawing.Point(691, 307);
            this.showpasswordPictureBox.Name = "showpasswordPictureBox";
            this.showpasswordPictureBox.Size = new System.Drawing.Size(45, 49);
            this.showpasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showpasswordPictureBox.TabIndex = 9;
            this.showpasswordPictureBox.TabStop = false;
            this.showpasswordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showpasswordPictureBox_MouseDown);
            this.showpasswordPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showpasswordPictureBox_MouseUp);
            // 
            // loginTabControl
            // 
            this.loginTabControl.Controls.Add(this.loginTabPage);
            this.loginTabControl.Location = new System.Drawing.Point(55, 177);
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 0;
            this.loginTabControl.Size = new System.Drawing.Size(984, 723);
            this.loginTabControl.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 953);
            this.Controls.Add(this.loginTabControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showpasswordPictureBox)).EndInit();
            this.loginTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage loginTabPage;
        private System.Windows.Forms.PictureBox showpasswordPictureBox;
        private System.Windows.Forms.TextBox passwordloginTextBox;
        private System.Windows.Forms.TextBox usernameloginTextBox;
        private System.Windows.Forms.Label hotelLabel;
        private System.Windows.Forms.Label forgotusernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TabControl loginTabControl;
    }
}