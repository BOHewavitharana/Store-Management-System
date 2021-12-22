
namespace StoreMS
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.productLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesButton = new System.Windows.Forms.Button();
            this.suppliersButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.buttonpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(911, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 41);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesDataGridView.GridColor = System.Drawing.Color.Silver;
            this.salesDataGridView.Location = new System.Drawing.Point(283, 53);
            this.salesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.salesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.salesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(474, 409);
            this.salesDataGridView.TabIndex = 3;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.ForeColor = System.Drawing.Color.Gray;
            this.productLabel.Location = new System.Drawing.Point(22, 391);
            this.productLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 4;
            this.productLabel.Text = "Product";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.ForeColor = System.Drawing.Color.Gray;
            this.monthLabel.Location = new System.Drawing.Point(22, 87);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(77, 13);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Filter By Month";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // productComboBox
            // 
            this.productComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(75, 388);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(177, 21);
            this.productComboBox.TabIndex = 6;
            this.productComboBox.SelectionChangeCommitted += new System.EventHandler(this.productComboBox_SelectionChangeCommitted);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(75, 335);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(177, 21);
            this.categoryComboBox.TabIndex = 7;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.Color.Teal;
            this.monthCalendar1.Location = new System.Drawing.Point(25, 107);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.Color.Gray;
            this.categoryLabel.Location = new System.Drawing.Point(22, 338);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.salesDataGridView);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.productLabel);
            this.panel1.Controls.Add(this.productComboBox);
            this.panel1.Controls.Add(this.monthLabel);
            this.panel1.Location = new System.Drawing.Point(187, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 475);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(15, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 2);
            this.label3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(22, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter By Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sales Board";
            // 
            // employeesButton
            // 
            this.employeesButton.BackColor = System.Drawing.Color.Transparent;
            this.employeesButton.FlatAppearance.BorderSize = 0;
            this.employeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.ForeColor = System.Drawing.Color.White;
            this.employeesButton.Location = new System.Drawing.Point(0, 177);
            this.employeesButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(187, 63);
            this.employeesButton.TabIndex = 11;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = false;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // suppliersButton
            // 
            this.suppliersButton.BackColor = System.Drawing.Color.Transparent;
            this.suppliersButton.FlatAppearance.BorderSize = 0;
            this.suppliersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.suppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersButton.ForeColor = System.Drawing.Color.White;
            this.suppliersButton.Location = new System.Drawing.Point(0, 239);
            this.suppliersButton.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.Size = new System.Drawing.Size(187, 63);
            this.suppliersButton.TabIndex = 12;
            this.suppliersButton.Text = "Suppliers";
            this.suppliersButton.UseVisualStyleBackColor = false;
            this.suppliersButton.Click += new System.EventHandler(this.suppliersButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Transparent;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Location = new System.Drawing.Point(0, 114);
            this.salesButton.Margin = new System.Windows.Forms.Padding(2);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(187, 63);
            this.salesButton.TabIndex = 13;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.Transparent;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.Color.White;
            this.productsButton.Location = new System.Drawing.Point(0, 302);
            this.productsButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(187, 63);
            this.productsButton.TabIndex = 14;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Transparent;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(0, 366);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(187, 63);
            this.categoryButton.TabIndex = 15;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Indigo;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(760, 11);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(118, 24);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StoreMS.Properties.Resources.Logo__1_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(48, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 94);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Store Management System";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(38, 467);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(117, 39);
            this.changePasswordButton.TabIndex = 38;
            this.changePasswordButton.Text = "Change My \r\nPassword";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // buttonpanel
            // 
            this.buttonpanel.BackgroundImage = global::StoreMS.Properties.Resources.background_pink_yellow;
            this.buttonpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpanel.Location = new System.Drawing.Point(3, 114);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(12, 63);
            this.buttonpanel.TabIndex = 41;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StoreMS.Properties.Resources.WhatsApp_Image_2021_09_30_at_10_16_33_PM;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.buttonpanel);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.suppliersButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button suppliersButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Panel buttonpanel;
    }
}