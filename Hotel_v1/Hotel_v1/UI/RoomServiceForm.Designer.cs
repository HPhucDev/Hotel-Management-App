
namespace Hotel_v1
{
    partial class RoomService
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
            this.roomlistComboBox = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // roomlistComboBox
            // 
            this.roomlistComboBox.FormattingEnabled = true;
            this.roomlistComboBox.Location = new System.Drawing.Point(141, 68);
            this.roomlistComboBox.Name = "roomlistComboBox";
            this.roomlistComboBox.Size = new System.Drawing.Size(205, 33);
            this.roomlistComboBox.TabIndex = 5;
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(26, 76);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(80, 25);
            this.roomLabel.TabIndex = 4;
            this.roomLabel.Text = "Room :";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ServiceLabel.Location = new System.Drawing.Point(441, 22);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(265, 79);
            this.ServiceLabel.TabIndex = 3;
            this.ServiceLabel.Text = "Service";
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 25;
            this.serviceListBox.Location = new System.Drawing.Point(47, 276);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(450, 479);
            this.serviceListBox.TabIndex = 6;
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "A->Z ",
            "Z->A",
            "Low to High"});
            this.sortComboBox.Location = new System.Drawing.Point(343, 228);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(154, 33);
            this.sortComboBox.TabIndex = 7;
            this.sortComboBox.Text = "Sort";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(47, 228);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(278, 33);
            this.categoryComboBox.TabIndex = 8;
            this.categoryComboBox.Tag = "";
            this.categoryComboBox.Text = "Category";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 798);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.serviceListBox);
            this.Controls.Add(this.roomlistComboBox);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.ServiceLabel);
            this.Name = "Service";
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roomlistComboBox;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}