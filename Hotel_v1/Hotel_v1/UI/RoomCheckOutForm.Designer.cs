
namespace Hotel_v1
{
    partial class RoomCheckOut
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
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.thanhtoanButton = new System.Windows.Forms.Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalserviceLabel = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.totalroomTextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.txbCurrent = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.totalpriceTextBox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.BackColor = System.Drawing.SystemColors.Control;
            this.checkoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkoutLabel.Location = new System.Drawing.Point(556, 20);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(359, 79);
            this.checkoutLabel.TabIndex = 1;
            this.checkoutLabel.Text = "Check Out";
            // 
            // thanhtoanButton
            // 
            this.thanhtoanButton.BackColor = System.Drawing.Color.PaleGreen;
            this.thanhtoanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhtoanButton.Location = new System.Drawing.Point(1185, 668);
            this.thanhtoanButton.Name = "thanhtoanButton";
            this.thanhtoanButton.Size = new System.Drawing.Size(318, 85);
            this.thanhtoanButton.TabIndex = 16;
            this.thanhtoanButton.Text = "Pay";
            this.thanhtoanButton.UseVisualStyleBackColor = false;
            this.thanhtoanButton.Click += new System.EventHandler(this.thanhtoanButton_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(872, 151);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(6);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(773, 249);
            this.lsvBill.TabIndex = 26;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Price";
            this.columnHeader4.Width = 50;
            // 
            // totalserviceLabel
            // 
            this.totalserviceLabel.AutoSize = true;
            this.totalserviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalserviceLabel.Location = new System.Drawing.Point(173, 23);
            this.totalserviceLabel.Name = "totalserviceLabel";
            this.totalserviceLabel.Size = new System.Drawing.Size(163, 42);
            this.totalserviceLabel.TabIndex = 8;
            this.totalserviceLabel.Text = "Service :";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbTotalPrice.Location = new System.Drawing.Point(371, 23);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(176, 42);
            this.txbTotalPrice.TabIndex = 7;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalserviceLabel);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Location = new System.Drawing.Point(872, 412);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 100);
            this.panel3.TabIndex = 27;
            // 
            // roomComboBox
            // 
            this.roomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(120, 95);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(219, 33);
            this.roomComboBox.TabIndex = 25;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(12, 103);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(80, 25);
            this.roomLabel.TabIndex = 24;
            this.roomLabel.Text = "Room :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.dayLabel);
            this.panel1.Controls.Add(this.totalroomTextBox);
            this.panel1.Location = new System.Drawing.Point(22, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 100);
            this.panel1.TabIndex = 28;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(354, 27);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(220, 42);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "* 220.000 = ";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(188, 27);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(105, 42);
            this.dayLabel.TabIndex = 8;
            this.dayLabel.Text = " Day ";
            // 
            // totalroomTextBox
            // 
            this.totalroomTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.totalroomTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalroomTextBox.Location = new System.Drawing.Point(574, 27);
            this.totalroomTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.totalroomTextBox.Name = "totalroomTextBox";
            this.totalroomTextBox.ReadOnly = true;
            this.totalroomTextBox.Size = new System.Drawing.Size(176, 42);
            this.totalroomTextBox.TabIndex = 7;
            this.totalroomTextBox.Text = "0";
            this.totalroomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(17, 151);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 82;
            this.customerDataGridView.RowTemplate.Height = 33;
            this.customerDataGridView.Size = new System.Drawing.Size(843, 252);
            this.customerDataGridView.TabIndex = 31;
            // 
            // txbCurrent
            // 
            this.txbCurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCurrent.DefaultText = "";
            this.txbCurrent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCurrent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCurrent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCurrent.DisabledState.Parent = this.txbCurrent;
            this.txbCurrent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCurrent.Enabled = false;
            this.txbCurrent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCurrent.FocusedState.Parent = this.txbCurrent;
            this.txbCurrent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCurrent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCurrent.HoverState.Parent = this.txbCurrent;
            this.txbCurrent.Location = new System.Drawing.Point(359, 764);
            this.txbCurrent.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txbCurrent.Name = "txbCurrent";
            this.txbCurrent.PasswordChar = '\0';
            this.txbCurrent.PlaceholderText = "";
            this.txbCurrent.ReadOnly = true;
            this.txbCurrent.SelectedText = "";
            this.txbCurrent.ShadowDecoration.Parent = this.txbCurrent;
            this.txbCurrent.Size = new System.Drawing.Size(340, 47);
            this.txbCurrent.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbCurrent.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 774);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 37);
            this.label4.TabIndex = 69;
            this.label4.Text = "Time Checkout Curent:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Yellow;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(22, 521);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(318, 85);
            this.checkoutButton.TabIndex = 71;
            this.checkoutButton.Text = "Check Out";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.AutoSize = true;
            this.totalpriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalpriceLabel.Location = new System.Drawing.Point(557, 547);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(210, 73);
            this.totalpriceLabel.TabIndex = 10;
            this.totalpriceLabel.Text = "Total :";
            // 
            // totalpriceTextBox
            // 
            this.totalpriceTextBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.totalpriceTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalpriceTextBox.Location = new System.Drawing.Point(776, 547);
            this.totalpriceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.totalpriceTextBox.Name = "totalpriceTextBox";
            this.totalpriceTextBox.ReadOnly = true;
            this.totalpriceTextBox.Size = new System.Drawing.Size(727, 81);
            this.totalpriceTextBox.TabIndex = 9;
            this.totalpriceTextBox.Text = "0";
            this.totalpriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RoomCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 844);
            this.Controls.Add(this.totalpriceLabel);
            this.Controls.Add(this.totalpriceTextBox);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.txbCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.thanhtoanButton);
            this.Controls.Add(this.checkoutLabel);
            this.Name = "RoomCheckOut";
            this.Text = "RoomCheckOut";
            this.Load += new System.EventHandler(this.RoomCheckOut_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Button thanhtoanButton;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label totalserviceLabel;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox totalroomTextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox txbCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.TextBox totalpriceTextBox;
    }
}