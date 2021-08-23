
namespace Hotel_v1
{
    partial class ListCustomerForm
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
            this.listcustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listcustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listcustomerDataGridView
            // 
            this.listcustomerDataGridView.AllowUserToAddRows = false;
            this.listcustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listcustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listcustomerDataGridView.Location = new System.Drawing.Point(49, 126);
            this.listcustomerDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.listcustomerDataGridView.Name = "listcustomerDataGridView";
            this.listcustomerDataGridView.ReadOnly = true;
            this.listcustomerDataGridView.RowHeadersVisible = false;
            this.listcustomerDataGridView.RowHeadersWidth = 82;
            this.listcustomerDataGridView.Size = new System.Drawing.Size(1403, 705);
            this.listcustomerDataGridView.TabIndex = 89;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(265, 51);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(831, 62);
            this.txbSearch.TabIndex = 88;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(37, 55);
            this.labSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(213, 63);
            this.labSearch.TabIndex = 87;
            this.labSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1108, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 63);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ListCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 883);
            this.Controls.Add(this.listcustomerDataGridView);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "ListCustomerForm";
            this.Text = "ListCustomerForm";
            this.Load += new System.EventHandler(this.ListCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listcustomerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listcustomerDataGridView;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}