
namespace StoreMS
{
    partial class ChangeAdminPassword
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
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.retypePasswordLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.newPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.retypePasswordTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.currentPasswordLabel.Location = new System.Drawing.Point(40, 94);
            this.currentPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(118, 13);
            this.currentPasswordLabel.TabIndex = 0;
            this.currentPasswordLabel.Text = "Enter Current Password";
            // 
            // currentPasswordTxtbox
            // 
            this.currentPasswordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPasswordTxtbox.Location = new System.Drawing.Point(43, 111);
            this.currentPasswordTxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.currentPasswordTxtbox.Name = "currentPasswordTxtbox";
            this.currentPasswordTxtbox.Size = new System.Drawing.Size(238, 20);
            this.currentPasswordTxtbox.TabIndex = 2;
            this.currentPasswordTxtbox.TextChanged += new System.EventHandler(this.currentPasswordTxtbox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.FlatAppearance.BorderSize = 2;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.okButton.Location = new System.Drawing.Point(208, 135);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(73, 24);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::StoreMS.Properties.Resources.arrows_11__Converted_;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(7, 6);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 27);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.newPasswordLabel.Location = new System.Drawing.Point(40, 172);
            this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "New Password";
            this.newPasswordLabel.Click += new System.EventHandler(this.newPasswordLabel_Click);
            // 
            // retypePasswordLabel
            // 
            this.retypePasswordLabel.AutoSize = true;
            this.retypePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.retypePasswordLabel.Location = new System.Drawing.Point(40, 232);
            this.retypePasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retypePasswordLabel.Name = "retypePasswordLabel";
            this.retypePasswordLabel.Size = new System.Drawing.Size(115, 13);
            this.retypePasswordLabel.TabIndex = 6;
            this.retypePasswordLabel.Text = "Retype New Password";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.changePasswordButton.FlatAppearance.BorderSize = 0;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(74, 303);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(165, 28);
            this.changePasswordButton.TabIndex = 7;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // newPasswordTxtBox
            // 
            this.newPasswordTxtBox.Location = new System.Drawing.Point(43, 190);
            this.newPasswordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPasswordTxtBox.Name = "newPasswordTxtBox";
            this.newPasswordTxtBox.Size = new System.Drawing.Size(238, 20);
            this.newPasswordTxtBox.TabIndex = 8;
            // 
            // retypePasswordTxtBox
            // 
            this.retypePasswordTxtBox.Location = new System.Drawing.Point(43, 250);
            this.retypePasswordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.retypePasswordTxtBox.Name = "retypePasswordTxtBox";
            this.retypePasswordTxtBox.Size = new System.Drawing.Size(238, 20);
            this.retypePasswordTxtBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newPasswordLabel);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.newPasswordTxtBox);
            this.panel1.Controls.Add(this.currentPasswordLabel);
            this.panel1.Controls.Add(this.currentPasswordTxtbox);
            this.panel1.Controls.Add(this.retypePasswordTxtBox);
            this.panel1.Controls.Add(this.retypePasswordLabel);
            this.panel1.Controls.Add(this.changePasswordButton);
            this.panel1.Location = new System.Drawing.Point(314, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 428);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change Your Password";
            // 
            // ChangeAdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StoreMS.Properties.Resources.WhatsApp_Image_2021_09_30_at_10_16_33_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeAdminPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeAdminPassword";
            this.Load += new System.EventHandler(this.ChangeAdminPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTxtbox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label retypePasswordLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox newPasswordTxtBox;
        private System.Windows.Forms.TextBox retypePasswordTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}