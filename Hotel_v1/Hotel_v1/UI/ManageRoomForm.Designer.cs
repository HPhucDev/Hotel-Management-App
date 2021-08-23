
namespace Hotel_v1
{
    partial class ManageRoomForm
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
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomListBox
            // 
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 25;
            this.roomListBox.Location = new System.Drawing.Point(12, 16);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(534, 654);
            this.roomListBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Location = new System.Drawing.Point(16, 697);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(529, 56);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 760);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.roomListBox);
            this.Name = "ManageRoom";
            this.Text = "ManageRoom";
            this.Load += new System.EventHandler(this.ManageRoom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Button deleteButton;
    }
}