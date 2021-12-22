
namespace StoreMS
{
    partial class ViewSupplies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.SuppliesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::StoreMS.Properties.Resources.arrows_11__Converted_;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(11, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(33, 27);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Gray;
            this.companyLabel.Location = new System.Drawing.Point(25, 32);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(209, 31);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Company Name";
            this.companyLabel.Click += new System.EventHandler(this.companyLabel_Click);
            // 
            // SuppliesDataGridView
            // 
            this.SuppliesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SuppliesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SuppliesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliesDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.SuppliesDataGridView.Location = new System.Drawing.Point(31, 76);
            this.SuppliesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SuppliesDataGridView.Name = "SuppliesDataGridView";
            this.SuppliesDataGridView.RowHeadersWidth = 51;
            this.SuppliesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.SuppliesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.SuppliesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.SuppliesDataGridView.RowTemplate.Height = 24;
            this.SuppliesDataGridView.Size = new System.Drawing.Size(502, 297);
            this.SuppliesDataGridView.TabIndex = 2;
            this.SuppliesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliesDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.companyLabel);
            this.panel1.Controls.Add(this.SuppliesDataGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(80, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 395);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StoreMS.Properties.Resources.vector60_2623_01;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(475, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 62);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StoreMS.Properties.Resources.WhatsApp_Image_2021_09_30_at_10_16_33_PM;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(640, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 395);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 224);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check\r\nYour\r\nSupplies\r\nHere!";
            // 
            // ViewSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StoreMS.Properties.Resources.WhatsApp_Image_2021_09_30_at_10_16_33_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewSupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSupplies";
            this.Load += new System.EventHandler(this.ViewSupplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.DataGridView SuppliesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}