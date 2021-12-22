
namespace StoreMS
{
    partial class Batch
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
            this.productLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.unitsTxtBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.ForeColor = System.Drawing.Color.Gray;
            this.productLabel.Location = new System.Drawing.Point(34, 123);
            this.productLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Product";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.ForeColor = System.Drawing.Color.Gray;
            this.qtyLabel.Location = new System.Drawing.Point(35, 203);
            this.qtyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(31, 13);
            this.qtyLabel.TabIndex = 1;
            this.qtyLabel.Text = "Units";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.ForeColor = System.Drawing.Color.Gray;
            this.companyLabel.Location = new System.Drawing.Point(35, 281);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(45, 13);
            this.companyLabel.TabIndex = 2;
            this.companyLabel.Text = "Supplier";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(68, 345);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(194, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(112, 120);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(164, 21);
            this.productComboBox.TabIndex = 5;
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(112, 278);
            this.companyComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(164, 21);
            this.companyComboBox.TabIndex = 6;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // unitsTxtBox
            // 
            this.unitsTxtBox.Location = new System.Drawing.Point(112, 200);
            this.unitsTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitsTxtBox.Name = "unitsTxtBox";
            this.unitsTxtBox.Size = new System.Drawing.Size(164, 20);
            this.unitsTxtBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.Color.Gray;
            this.categoryLabel.Location = new System.Drawing.Point(35, 45);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(112, 42);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(164, 21);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::StoreMS.Properties.Resources.arrows_11__Converted_;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(11, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(33, 27);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.unitsTxtBox);
            this.panel1.Controls.Add(this.companyLabel);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.qtyLabel);
            this.panel1.Controls.Add(this.companyComboBox);
            this.panel1.Controls.Add(this.productComboBox);
            this.panel1.Controls.Add(this.productLabel);
            this.panel1.Location = new System.Drawing.Point(131, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 428);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StoreMS.Properties.Resources.WhatsApp_Image_2021_09_30_at_10_16_33_PM;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(451, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 428);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 308);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add \r\nNew \r\nBatch \r\nHere!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StoreMS.Properties.Resources.WhatsApp_Image_2021_09_30_at_10_16_33_PM;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewBatch";
            this.Load += new System.EventHandler(this.NewBatch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.TextBox unitsTxtBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}