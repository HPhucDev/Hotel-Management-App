
namespace Hotel_v1
{
    partial class CheckInOut
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
            this.checkinButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkinButton
            // 
            this.checkinButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinButton.Location = new System.Drawing.Point(4, 4);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(420, 295);
            this.checkinButton.TabIndex = 0;
            this.checkinButton.Text = "Check In ";
            this.checkinButton.UseVisualStyleBackColor = false;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Salmon;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(430, 4);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(420, 295);
            this.checkoutButton.TabIndex = 1;
            this.checkoutButton.Text = "Check Out";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 299);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.checkinButton);
            this.Name = "CheckInOut";
            this.Text = "CheckInOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button checkoutButton;
    }
}