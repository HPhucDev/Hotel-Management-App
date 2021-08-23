
namespace Hotel_v1
{
    partial class BillPrint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lovelabel = new System.Windows.Forms.Label();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalpricedayLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.numberdayLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.checkinLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hotelLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lovelabel);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Controls.Add(this.totalTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.totalpricedayLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.numberdayLabel);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.checkoutLabel);
            this.panel1.Controls.Add(this.checkinLabel);
            this.panel1.Controls.Add(this.roomLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.hotelLabel);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 1045);
            this.panel1.TabIndex = 0;
            // 
            // lovelabel
            // 
            this.lovelabel.AutoSize = true;
            this.lovelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lovelabel.Location = new System.Drawing.Point(176, 962);
            this.lovelabel.Name = "lovelabel";
            this.lovelabel.Size = new System.Drawing.Size(550, 25);
            this.lovelabel.TabIndex = 28;
            this.lovelabel.Text = "WE HOPE YOU ENJOYED YOUR STAY WITH US ! ";
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.SystemColors.Menu;
            this.lsvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(12, 465);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(6);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(923, 275);
            this.lsvBill.TabIndex = 27;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 55;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.totalTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalTextBox.Location = new System.Drawing.Point(599, 761);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(286, 35);
            this.totalTextBox.TabIndex = 18;
            this.totalTextBox.Text = "0";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 761);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total :";
            // 
            // totalpricedayLabel
            // 
            this.totalpricedayLabel.AutoSize = true;
            this.totalpricedayLabel.Location = new System.Drawing.Point(764, 422);
            this.totalpricedayLabel.Name = "totalpricedayLabel";
            this.totalpricedayLabel.Size = new System.Drawing.Size(36, 25);
            this.totalpricedayLabel.TabIndex = 15;
            this.totalpricedayLabel.Text = "00";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(612, 422);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(84, 25);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "220000";
            // 
            // numberdayLabel
            // 
            this.numberdayLabel.AutoSize = true;
            this.numberdayLabel.Location = new System.Drawing.Point(473, 422);
            this.numberdayLabel.Name = "numberdayLabel";
            this.numberdayLabel.Size = new System.Drawing.Size(56, 25);
            this.numberdayLabel.TabIndex = 13;
            this.numberdayLabel.Text = "DAY";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 423);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(143, 25);
            this.label.TabIndex = 12;
            this.label.Text = "#Guest Room";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(749, 240);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(101, 25);
            this.checkoutLabel.TabIndex = 11;
            this.checkoutLabel.Text = "ARRIVAL";
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Location = new System.Drawing.Point(747, 197);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(101, 25);
            this.checkinLabel.TabIndex = 10;
            this.checkinLabel.Text = "ARRIVAL";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(745, 153);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(103, 25);
            this.roomLabel.TabIndex = 9;
            this.roomLabel.Text = "NUMBER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-95, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(961, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "                  Description                                                    " +
    "    Count                 Price                 Charges ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Page No :        1 of 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departure :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Arrival :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(608, 120);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ: 1 Võ Văn Ngân, Linh Chiểu, Thủ Đức, Thành phố Hồ Chí Minh.\r\nĐiện thoại: " +
    "(+84 - 028) 38968641 - (+84 -028) 38961333 \r\nFax: (+84 - 028) 38964922\r\nE-mail: " +
    "ptchc@hcmute.edu.vn\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMATION INVOICE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_v1.Properties.Resources.hotel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // hotelLabel
            // 
            this.hotelLabel.AutoSize = true;
            this.hotelLabel.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLabel.Location = new System.Drawing.Point(121, 18);
            this.hotelLabel.Name = "hotelLabel";
            this.hotelLabel.Size = new System.Drawing.Size(121, 64);
            this.hotelLabel.TabIndex = 0;
            this.hotelLabel.Text = "HCMUTE\r\nHotel ";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(128, 42);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // BillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1110);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.panel1);
            this.Name = "BillPrint";
            this.Text = "BillPrint";
            this.Load += new System.EventHandler(this.BillPrint_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillPrint_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hotelLabel;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label checkinLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalpricedayLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label numberdayLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lovelabel;
        private System.Windows.Forms.Button printButton;
    }
}