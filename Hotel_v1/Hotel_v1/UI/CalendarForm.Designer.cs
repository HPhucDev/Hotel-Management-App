namespace Hotel_v1
{
    partial class CalendarForm
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
            this.txbUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btn7day = new Guna.UI2.WinForms.Guna2Button();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUserID
            // 
            this.txbUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserID.DefaultText = "";
            this.txbUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUserID.DisabledState.Parent = this.txbUserID;
            this.txbUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUserID.Enabled = false;
            this.txbUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUserID.FocusedState.Parent = this.txbUserID;
            this.txbUserID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUserID.HoverState.Parent = this.txbUserID;
            this.txbUserID.Location = new System.Drawing.Point(1160, 113);
            this.txbUserID.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.PasswordChar = '\0';
            this.txbUserID.PlaceholderText = "";
            this.txbUserID.ReadOnly = true;
            this.txbUserID.SelectedText = "";
            this.txbUserID.ShadowDecoration.Parent = this.txbUserID;
            this.txbUserID.Size = new System.Drawing.Size(146, 54);
            this.txbUserID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbUserID.TabIndex = 78;
            // 
            // btnFind
            // 
            this.btnFind.BorderRadius = 16;
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(12)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(1155, 15);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(158, 81);
            this.btnFind.TabIndex = 77;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btn7day
            // 
            this.btn7day.BorderRadius = 16;
            this.btn7day.CheckedState.Parent = this.btn7day;
            this.btn7day.CustomImages.Parent = this.btn7day;
            this.btn7day.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7day.ForeColor = System.Drawing.Color.White;
            this.btn7day.HoverState.Parent = this.btn7day;
            this.btn7day.Location = new System.Drawing.Point(775, 15);
            this.btn7day.Margin = new System.Windows.Forms.Padding(6);
            this.btn7day.Name = "btn7day";
            this.btn7day.ShadowDecoration.Parent = this.btn7day;
            this.btn7day.Size = new System.Drawing.Size(368, 152);
            this.btn7day.TabIndex = 76;
            this.btn7day.Text = "7 days";
            this.btn7day.Click += new System.EventHandler(this.btn7day_Click);
            // 
            // btnToday
            // 
            this.btnToday.BorderRadius = 16;
            this.btnToday.CheckedState.Parent = this.btnToday;
            this.btnToday.CustomImages.Parent = this.btnToday;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.HoverState.Parent = this.btnToday;
            this.btnToday.Location = new System.Drawing.Point(395, 15);
            this.btnToday.Margin = new System.Windows.Forms.Padding(6);
            this.btnToday.Name = "btnToday";
            this.btnToday.ShadowDecoration.Parent = this.btnToday;
            this.btnToday.Size = new System.Drawing.Size(368, 152);
            this.btnToday.TabIndex = 75;
            this.btnToday.Text = "Today";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 16;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(15, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(368, 152);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1318, 690);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 995);
            this.Controls.Add(this.txbUserID);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btn7day);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalendarForm";
            this.Text = "frmCalendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.VisibleChanged += new System.EventHandler(this.CalendarForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txbUserID;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btn7day;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}