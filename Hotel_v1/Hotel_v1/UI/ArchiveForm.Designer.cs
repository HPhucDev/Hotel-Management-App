
namespace Hotel_v1
{
    partial class ArchiveForm
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
            this.archiveDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // archiveDataGridView
            // 
            this.archiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGridView.Location = new System.Drawing.Point(12, 137);
            this.archiveDataGridView.Name = "archiveDataGridView";
            this.archiveDataGridView.RowHeadersVisible = false;
            this.archiveDataGridView.RowHeadersWidth = 82;
            this.archiveDataGridView.RowTemplate.Height = 33;
            this.archiveDataGridView.Size = new System.Drawing.Size(1026, 714);
            this.archiveDataGridView.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(159, 89);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(318, 33);
            this.categoryComboBox.TabIndex = 46;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 45;
            this.label1.Text = "Category ";
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 863);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.archiveDataGridView);
            this.Name = "ArchiveForm";
            this.Text = "ArchiveForm";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView archiveDataGridView;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
    }
}