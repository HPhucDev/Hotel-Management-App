
namespace Hotel_v1
{
    partial class MyCalendar
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
            this.calendarDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarDataGridView
            // 
            this.calendarDataGridView.AllowUserToAddRows = false;
            this.calendarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendarDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.calendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDataGridView.Location = new System.Drawing.Point(3, 15);
            this.calendarDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.calendarDataGridView.Name = "calendarDataGridView";
            this.calendarDataGridView.ReadOnly = true;
            this.calendarDataGridView.RowHeadersWidth = 82;
            this.calendarDataGridView.Size = new System.Drawing.Size(1116, 878);
            this.calendarDataGridView.TabIndex = 49;
            // 
            // MyCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 898);
            this.Controls.Add(this.calendarDataGridView);
            this.Name = "MyCalendar";
            this.Text = "MyCalendar";
            this.Load += new System.EventHandler(this.MyCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarDataGridView;
    }
}