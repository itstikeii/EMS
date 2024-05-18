namespace EMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.login_username = new Guna.UI.WinForms.GunaTextBox();
            this.login_password = new Guna.UI.WinForms.GunaTextBox();
            this.login_login = new Guna.UI.WinForms.GunaButton();
            this.login_forgotpass = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.login_hidepass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(504, 503);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // login_username
            // 
            this.login_username.BaseColor = System.Drawing.Color.White;
            this.login_username.BorderColor = System.Drawing.Color.Silver;
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.FocusedBaseColor = System.Drawing.Color.White;
            this.login_username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.login_username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.login_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_username.Location = new System.Drawing.Point(538, 250);
            this.login_username.Name = "login_username";
            this.login_username.PasswordChar = '\0';
            this.login_username.Size = new System.Drawing.Size(322, 38);
            this.login_username.TabIndex = 2;
            // 
            // login_password
            // 
            this.login_password.BaseColor = System.Drawing.Color.White;
            this.login_password.BorderColor = System.Drawing.Color.Silver;
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.FocusedBaseColor = System.Drawing.Color.White;
            this.login_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.login_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.login_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_password.Location = new System.Drawing.Point(538, 323);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '\0';
            this.login_password.Size = new System.Drawing.Size(270, 38);
            this.login_password.TabIndex = 3;
            // 
            // login_login
            // 
            this.login_login.AnimationHoverSpeed = 0.07F;
            this.login_login.AnimationSpeed = 0.03F;
            this.login_login.BaseColor = System.Drawing.Color.Navy;
            this.login_login.BorderColor = System.Drawing.Color.Black;
            this.login_login.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_login.ForeColor = System.Drawing.Color.White;
            this.login_login.Image = ((System.Drawing.Image)(resources.GetObject("login_login.Image")));
            this.login_login.ImageSize = new System.Drawing.Size(20, 20);
            this.login_login.Location = new System.Drawing.Point(538, 387);
            this.login_login.Name = "login_login";
            this.login_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.login_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_login.OnHoverForeColor = System.Drawing.Color.White;
            this.login_login.OnHoverImage = null;
            this.login_login.OnPressedColor = System.Drawing.Color.Black;
            this.login_login.Size = new System.Drawing.Size(175, 42);
            this.login_login.TabIndex = 4;
            this.login_login.Text = "ĐĂNG NHẬP";
            this.login_login.Click += new System.EventHandler(this.login_login_Click);
            // 
            // login_forgotpass
            // 
            this.login_forgotpass.AutoSize = true;
            this.login_forgotpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_forgotpass.Location = new System.Drawing.Point(755, 410);
            this.login_forgotpass.Name = "login_forgotpass";
            this.login_forgotpass.Size = new System.Drawing.Size(105, 19);
            this.login_forgotpass.TabIndex = 5;
            this.login_forgotpass.TabStop = true;
            this.login_forgotpass.Text = "Quên mật khẩu";
            this.login_forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(524, 464);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(234, 19);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Liên hệ nếu gặp sự cố : 0123456789\r\n";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(526, 70);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(201, 142);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "ĐĂNG \r\nNHẬP";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(689, 162);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(149, 37);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "HỆ THỐNG";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(534, 228);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(100, 19);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Tên đăng nhập";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(534, 301);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 19);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Mật khẩu";
            // 
            // login_hidepass
            // 
            this.login_hidepass.Appearance = System.Windows.Forms.Appearance.Button;
            this.login_hidepass.AutoSize = true;
            this.login_hidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_hidepass.Checked = true;
            this.login_hidepass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.login_hidepass.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_hidepass.Image = ((System.Drawing.Image)(resources.GetObject("login_hidepass.Image")));
            this.login_hidepass.Location = new System.Drawing.Point(814, 323);
            this.login_hidepass.Name = "login_hidepass";
            this.login_hidepass.Size = new System.Drawing.Size(36, 36);
            this.login_hidepass.TabIndex = 11;
            this.login_hidepass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 503);
            this.Controls.Add(this.login_hidepass);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.login_forgotpass);
            this.Controls.Add(this.login_login);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox login_username;
        private Guna.UI.WinForms.GunaTextBox login_password;
        private Guna.UI.WinForms.GunaButton login_login;
        private Guna.UI.WinForms.GunaLinkLabel login_forgotpass;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.CheckBox login_hidepass;
    }
}

