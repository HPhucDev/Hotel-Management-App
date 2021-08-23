
namespace Hotel_v1
{
    partial class UpdateServiceForm
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
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.servicenameLabel = new System.Windows.Forms.Label();
            this.servicenamereplaceTextBox = new System.Windows.Forms.TextBox();
            this.namereplace = new System.Windows.Forms.Label();
            this.servicenameComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(230, 180);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(231, 31);
            this.priceTextBox.TabIndex = 11;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(230, 106);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(231, 33);
            this.categoryComboBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(33, 180);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 25);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price :";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(33, 106);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(111, 25);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Category :";
            // 
            // servicenameLabel
            // 
            this.servicenameLabel.AutoSize = true;
            this.servicenameLabel.Location = new System.Drawing.Point(28, 36);
            this.servicenameLabel.Name = "servicenameLabel";
            this.servicenameLabel.Size = new System.Drawing.Size(158, 25);
            this.servicenameLabel.TabIndex = 6;
            this.servicenameLabel.Text = "Service Name :";
            // 
            // servicenamereplaceTextBox
            // 
            this.servicenamereplaceTextBox.Location = new System.Drawing.Point(654, 39);
            this.servicenamereplaceTextBox.Name = "servicenamereplaceTextBox";
            this.servicenamereplaceTextBox.Size = new System.Drawing.Size(242, 31);
            this.servicenamereplaceTextBox.TabIndex = 9;
            // 
            // namereplace
            // 
            this.namereplace.AutoSize = true;
            this.namereplace.Location = new System.Drawing.Point(489, 42);
            this.namereplace.Name = "namereplace";
            this.namereplace.Size = new System.Drawing.Size(165, 25);
            this.namereplace.TabIndex = 12;
            this.namereplace.Text = "Name Replace :";
            // 
            // servicenameComboBox
            // 
            this.servicenameComboBox.FormattingEnabled = true;
            this.servicenameComboBox.Location = new System.Drawing.Point(230, 42);
            this.servicenameComboBox.Name = "servicenameComboBox";
            this.servicenameComboBox.Size = new System.Drawing.Size(231, 33);
            this.servicenameComboBox.TabIndex = 13;
            this.servicenameComboBox.SelectedIndexChanged += new System.EventHandler(this.servicenameComboBox_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(38, 244);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(423, 67);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(494, 244);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(423, 67);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(902, 42);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(27, 26);
            this.checkRadioButton.TabIndex = 16;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpdateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 347);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.servicenameComboBox);
            this.Controls.Add(this.namereplace);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.servicenamereplaceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.servicenameLabel);
            this.Name = "UpdateServiceForm";
            this.Text = "UpdateService";
            this.Load += new System.EventHandler(this.UpdateServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label servicenameLabel;
        private System.Windows.Forms.TextBox servicenamereplaceTextBox;
        private System.Windows.Forms.Label namereplace;
        private System.Windows.Forms.ComboBox servicenameComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
    }
}