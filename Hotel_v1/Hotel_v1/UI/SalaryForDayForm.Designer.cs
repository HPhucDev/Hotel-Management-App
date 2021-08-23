
namespace Hotel_v1
{
    partial class SalaryForDayForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listsalaryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listsalaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(397, 31);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 22, 15, 26, 1, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listsalaryDataGridView
            // 
            this.listsalaryDataGridView.AllowUserToAddRows = false;
            this.listsalaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listsalaryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listsalaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listsalaryDataGridView.Location = new System.Drawing.Point(1, 34);
            this.listsalaryDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.listsalaryDataGridView.Name = "listsalaryDataGridView";
            this.listsalaryDataGridView.ReadOnly = true;
            this.listsalaryDataGridView.RowHeadersVisible = false;
            this.listsalaryDataGridView.RowHeadersWidth = 82;
            this.listsalaryDataGridView.Size = new System.Drawing.Size(942, 702);
            this.listsalaryDataGridView.TabIndex = 82;
            // 
            // SalaryForDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 792);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listsalaryDataGridView);
            this.Name = "SalaryForDayForm";
            this.Text = "SalaryForDayForm";
            this.Load += new System.EventHandler(this.SalaryForDayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listsalaryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView listsalaryDataGridView;
    }
}