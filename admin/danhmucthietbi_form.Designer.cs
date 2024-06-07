namespace EMS.admin
{
    partial class danhmucthietbi_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhmucthietbi_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.dstb_tim = new Guna.UI.WinForms.GunaButton();
            this.dstb_timID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dstb_themmoi = new Guna.UI.WinForms.GunaButton();
            this.dstb_lammoi = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dstb_xoa = new Guna.UI.WinForms.GunaButton();
            this.dstb_chinhsua = new Guna.UI.WinForms.GunaButton();
            this.ds_thietbi = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dstb_pl_tukhoa = new Guna.UI.WinForms.GunaTextBox();
            this.dstb_pl_huy = new Guna.UI.WinForms.GunaButton();
            this.dstb_phanloai = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dstb_pl = new Guna.UI.WinForms.GunaComboBox();
            this.dstb_qrtb = new Guna.UI.WinForms.GunaPictureBox();
            this.dstb_chitiet = new Guna.UI.WinForms.GunaButton();
            this.dstb_id = new System.Windows.Forms.TextBox();
            this.dstb_ten = new System.Windows.Forms.TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_thietbi)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstb_qrtb)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.dstb_tim);
            this.gunaPanel1.Controls.Add(this.dstb_timID);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1095, 55);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // dstb_tim
            // 
            this.dstb_tim.AnimationHoverSpeed = 0.07F;
            this.dstb_tim.AnimationSpeed = 0.03F;
            this.dstb_tim.BaseColor = System.Drawing.Color.Transparent;
            this.dstb_tim.BorderColor = System.Drawing.Color.Black;
            this.dstb_tim.BorderSize = 2;
            this.dstb_tim.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_tim.ForeColor = System.Drawing.Color.Black;
            this.dstb_tim.Image = ((System.Drawing.Image)(resources.GetObject("dstb_tim.Image")));
            this.dstb_tim.ImageSize = new System.Drawing.Size(20, 20);
            this.dstb_tim.Location = new System.Drawing.Point(1002, 6);
            this.dstb_tim.Name = "dstb_tim";
            this.dstb_tim.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_tim.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_tim.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_tim.OnHoverImage = null;
            this.dstb_tim.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_tim.Radius = 20;
            this.dstb_tim.Size = new System.Drawing.Size(75, 42);
            this.dstb_tim.TabIndex = 1;
            this.dstb_tim.Text = "Tìm";
            // 
            // dstb_timID
            // 
            this.dstb_timID.BackColor = System.Drawing.Color.Transparent;
            this.dstb_timID.BaseColor = System.Drawing.Color.Transparent;
            this.dstb_timID.BorderColor = System.Drawing.Color.LightGray;
            this.dstb_timID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dstb_timID.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.dstb_timID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dstb_timID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.dstb_timID.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_timID.ForeColor = System.Drawing.Color.Black;
            this.dstb_timID.Location = new System.Drawing.Point(714, 6);
            this.dstb_timID.Name = "dstb_timID";
            this.dstb_timID.PasswordChar = '\0';
            this.dstb_timID.Radius = 20;
            this.dstb_timID.Size = new System.Drawing.Size(282, 46);
            this.dstb_timID.TabIndex = 1;
            this.dstb_timID.Click += new System.EventHandler(this.gunaTextBox1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(284, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "DANH MỤC THIẾT BỊ";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // dstb_themmoi
            // 
            this.dstb_themmoi.AnimationHoverSpeed = 0.07F;
            this.dstb_themmoi.AnimationSpeed = 0.03F;
            this.dstb_themmoi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dstb_themmoi.BorderColor = System.Drawing.Color.Black;
            this.dstb_themmoi.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_themmoi.ForeColor = System.Drawing.Color.White;
            this.dstb_themmoi.Image = ((System.Drawing.Image)(resources.GetObject("dstb_themmoi.Image")));
            this.dstb_themmoi.ImageSize = new System.Drawing.Size(30, 30);
            this.dstb_themmoi.Location = new System.Drawing.Point(11, 46);
            this.dstb_themmoi.Name = "dstb_themmoi";
            this.dstb_themmoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_themmoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_themmoi.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_themmoi.OnHoverImage = null;
            this.dstb_themmoi.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_themmoi.Radius = 10;
            this.dstb_themmoi.Size = new System.Drawing.Size(181, 41);
            this.dstb_themmoi.TabIndex = 4;
            this.dstb_themmoi.Text = "Thêm mới";
            this.dstb_themmoi.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // dstb_lammoi
            // 
            this.dstb_lammoi.AnimationHoverSpeed = 0.07F;
            this.dstb_lammoi.AnimationSpeed = 0.03F;
            this.dstb_lammoi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dstb_lammoi.BorderColor = System.Drawing.Color.Black;
            this.dstb_lammoi.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_lammoi.ForeColor = System.Drawing.Color.White;
            this.dstb_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("dstb_lammoi.Image")));
            this.dstb_lammoi.ImageSize = new System.Drawing.Size(30, 30);
            this.dstb_lammoi.Location = new System.Drawing.Point(821, 160);
            this.dstb_lammoi.Name = "dstb_lammoi";
            this.dstb_lammoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_lammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_lammoi.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_lammoi.OnHoverImage = null;
            this.dstb_lammoi.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_lammoi.Radius = 10;
            this.dstb_lammoi.Size = new System.Drawing.Size(49, 31);
            this.dstb_lammoi.TabIndex = 5;
            this.dstb_lammoi.Text = "Làm mới";
            this.dstb_lammoi.Click += new System.EventHandler(this.dstb_lammoi_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dstb_xoa);
            this.gunaGroupBox2.Controls.Add(this.dstb_chinhsua);
            this.gunaGroupBox2.Controls.Add(this.dstb_themmoi);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(879, 317);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(204, 205);
            this.gunaGroupBox2.TabIndex = 6;
            this.gunaGroupBox2.Text = "Chức năng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dstb_xoa
            // 
            this.dstb_xoa.AnimationHoverSpeed = 0.07F;
            this.dstb_xoa.AnimationSpeed = 0.03F;
            this.dstb_xoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dstb_xoa.BorderColor = System.Drawing.Color.Black;
            this.dstb_xoa.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_xoa.ForeColor = System.Drawing.Color.White;
            this.dstb_xoa.Image = ((System.Drawing.Image)(resources.GetObject("dstb_xoa.Image")));
            this.dstb_xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.dstb_xoa.Location = new System.Drawing.Point(11, 140);
            this.dstb_xoa.Name = "dstb_xoa";
            this.dstb_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_xoa.OnHoverImage = null;
            this.dstb_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_xoa.Radius = 10;
            this.dstb_xoa.Size = new System.Drawing.Size(181, 41);
            this.dstb_xoa.TabIndex = 6;
            this.dstb_xoa.Text = "Xóa";
            this.dstb_xoa.Click += new System.EventHandler(this.dstb_xoa_Click);
            // 
            // dstb_chinhsua
            // 
            this.dstb_chinhsua.AnimationHoverSpeed = 0.07F;
            this.dstb_chinhsua.AnimationSpeed = 0.03F;
            this.dstb_chinhsua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dstb_chinhsua.BorderColor = System.Drawing.Color.Black;
            this.dstb_chinhsua.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_chinhsua.ForeColor = System.Drawing.Color.White;
            this.dstb_chinhsua.Image = ((System.Drawing.Image)(resources.GetObject("dstb_chinhsua.Image")));
            this.dstb_chinhsua.ImageSize = new System.Drawing.Size(30, 30);
            this.dstb_chinhsua.Location = new System.Drawing.Point(11, 93);
            this.dstb_chinhsua.Name = "dstb_chinhsua";
            this.dstb_chinhsua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_chinhsua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_chinhsua.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_chinhsua.OnHoverImage = null;
            this.dstb_chinhsua.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_chinhsua.Radius = 10;
            this.dstb_chinhsua.Size = new System.Drawing.Size(181, 41);
            this.dstb_chinhsua.TabIndex = 5;
            this.dstb_chinhsua.Text = "Chỉnh sửa";
            this.dstb_chinhsua.Click += new System.EventHandler(this.dstb_chinhsua_Click);
            // 
            // ds_thietbi
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ds_thietbi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ds_thietbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ds_thietbi.BackgroundColor = System.Drawing.Color.White;
            this.ds_thietbi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ds_thietbi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ds_thietbi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ds_thietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ds_thietbi.ColumnHeadersHeight = 4;
            this.ds_thietbi.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ds_thietbi.DefaultCellStyle = dataGridViewCellStyle6;
            this.ds_thietbi.EnableHeadersVisualStyles = false;
            this.ds_thietbi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ds_thietbi.Location = new System.Drawing.Point(19, 208);
            this.ds_thietbi.Name = "ds_thietbi";
            this.ds_thietbi.ReadOnly = true;
            this.ds_thietbi.RowHeadersVisible = false;
            this.ds_thietbi.RowHeadersWidth = 45;
            this.ds_thietbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ds_thietbi.Size = new System.Drawing.Size(854, 510);
            this.ds_thietbi.TabIndex = 7;
            this.ds_thietbi.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ds_thietbi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ds_thietbi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ds_thietbi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ds_thietbi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ds_thietbi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ds_thietbi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ds_thietbi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ds_thietbi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ds_thietbi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ds_thietbi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ds_thietbi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ds_thietbi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ds_thietbi.ThemeStyle.HeaderStyle.Height = 4;
            this.ds_thietbi.ThemeStyle.ReadOnly = true;
            this.ds_thietbi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ds_thietbi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ds_thietbi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ds_thietbi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ds_thietbi.ThemeStyle.RowsStyle.Height = 22;
            this.ds_thietbi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ds_thietbi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ds_thietbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ds_thietbi_CellContentClick);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 69);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(247, 37);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Danh sách thiết bị";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.dstb_pl_tukhoa);
            this.gunaGroupBox1.Controls.Add(this.dstb_pl_huy);
            this.gunaGroupBox1.Controls.Add(this.dstb_phanloai);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.dstb_pl);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(19, 106);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(648, 96);
            this.gunaGroupBox1.TabIndex = 8;
            this.gunaGroupBox1.Text = "Phân loại";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            this.gunaGroupBox1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // dstb_pl_tukhoa
            // 
            this.dstb_pl_tukhoa.BackColor = System.Drawing.Color.Transparent;
            this.dstb_pl_tukhoa.BaseColor = System.Drawing.Color.Transparent;
            this.dstb_pl_tukhoa.BorderColor = System.Drawing.Color.LightGray;
            this.dstb_pl_tukhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dstb_pl_tukhoa.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.dstb_pl_tukhoa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dstb_pl_tukhoa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.dstb_pl_tukhoa.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_pl_tukhoa.ForeColor = System.Drawing.Color.Black;
            this.dstb_pl_tukhoa.Location = new System.Drawing.Point(218, 39);
            this.dstb_pl_tukhoa.Name = "dstb_pl_tukhoa";
            this.dstb_pl_tukhoa.PasswordChar = '\0';
            this.dstb_pl_tukhoa.Radius = 20;
            this.dstb_pl_tukhoa.Size = new System.Drawing.Size(282, 46);
            this.dstb_pl_tukhoa.TabIndex = 2;
            // 
            // dstb_pl_huy
            // 
            this.dstb_pl_huy.AnimationHoverSpeed = 0.07F;
            this.dstb_pl_huy.AnimationSpeed = 0.03F;
            this.dstb_pl_huy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dstb_pl_huy.BorderColor = System.Drawing.Color.Black;
            this.dstb_pl_huy.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_pl_huy.ForeColor = System.Drawing.Color.White;
            this.dstb_pl_huy.Image = ((System.Drawing.Image)(resources.GetObject("dstb_pl_huy.Image")));
            this.dstb_pl_huy.ImageSize = new System.Drawing.Size(30, 30);
            this.dstb_pl_huy.Location = new System.Drawing.Point(587, 44);
            this.dstb_pl_huy.Name = "dstb_pl_huy";
            this.dstb_pl_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_pl_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_pl_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_pl_huy.OnHoverImage = null;
            this.dstb_pl_huy.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_pl_huy.Radius = 10;
            this.dstb_pl_huy.Size = new System.Drawing.Size(51, 41);
            this.dstb_pl_huy.TabIndex = 7;
            this.dstb_pl_huy.Text = "Hủy";
            this.dstb_pl_huy.Click += new System.EventHandler(this.dstb_pl_huy_Click);
            // 
            // dstb_phanloai
            // 
            this.dstb_phanloai.AnimationHoverSpeed = 0.07F;
            this.dstb_phanloai.AnimationSpeed = 0.03F;
            this.dstb_phanloai.BackColor = System.Drawing.Color.Transparent;
            this.dstb_phanloai.BaseColor = System.Drawing.Color.Transparent;
            this.dstb_phanloai.BorderColor = System.Drawing.Color.Black;
            this.dstb_phanloai.BorderSize = 2;
            this.dstb_phanloai.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_phanloai.ForeColor = System.Drawing.Color.Black;
            this.dstb_phanloai.Image = ((System.Drawing.Image)(resources.GetObject("dstb_phanloai.Image")));
            this.dstb_phanloai.ImageSize = new System.Drawing.Size(20, 20);
            this.dstb_phanloai.Location = new System.Drawing.Point(506, 44);
            this.dstb_phanloai.Name = "dstb_phanloai";
            this.dstb_phanloai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_phanloai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_phanloai.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_phanloai.OnHoverImage = null;
            this.dstb_phanloai.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_phanloai.Radius = 20;
            this.dstb_phanloai.Size = new System.Drawing.Size(75, 42);
            this.dstb_phanloai.TabIndex = 6;
            this.dstb_phanloai.Text = "Tìm";
            this.dstb_phanloai.Click += new System.EventHandler(this.dstb_phanloai_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(3, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(104, 19);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Phân loại theo :";
            // 
            // dstb_pl
            // 
            this.dstb_pl.BackColor = System.Drawing.Color.Transparent;
            this.dstb_pl.BaseColor = System.Drawing.Color.White;
            this.dstb_pl.BorderColor = System.Drawing.Color.Silver;
            this.dstb_pl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dstb_pl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dstb_pl.Font = new System.Drawing.Font("Segoe UI", 12.22642F);
            this.dstb_pl.ForeColor = System.Drawing.Color.Black;
            this.dstb_pl.FormattingEnabled = true;
            this.dstb_pl.Location = new System.Drawing.Point(3, 48);
            this.dstb_pl.Name = "dstb_pl";
            this.dstb_pl.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dstb_pl.OnHoverItemForeColor = System.Drawing.Color.White;
            this.dstb_pl.Size = new System.Drawing.Size(209, 32);
            this.dstb_pl.TabIndex = 0;
            // 
            // dstb_qrtb
            // 
            this.dstb_qrtb.BackColor = System.Drawing.Color.White;
            this.dstb_qrtb.BaseColor = System.Drawing.Color.White;
            this.dstb_qrtb.Location = new System.Drawing.Point(905, 61);
            this.dstb_qrtb.Name = "dstb_qrtb";
            this.dstb_qrtb.Size = new System.Drawing.Size(156, 117);
            this.dstb_qrtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dstb_qrtb.TabIndex = 9;
            this.dstb_qrtb.TabStop = false;
            // 
            // dstb_chitiet
            // 
            this.dstb_chitiet.AnimationHoverSpeed = 0.07F;
            this.dstb_chitiet.AnimationSpeed = 0.03F;
            this.dstb_chitiet.BaseColor = System.Drawing.Color.Navy;
            this.dstb_chitiet.BorderColor = System.Drawing.Color.Black;
            this.dstb_chitiet.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstb_chitiet.ForeColor = System.Drawing.Color.White;
            this.dstb_chitiet.Image = ((System.Drawing.Image)(resources.GetObject("dstb_chitiet.Image")));
            this.dstb_chitiet.ImageSize = new System.Drawing.Size(30, 30);
            this.dstb_chitiet.Location = new System.Drawing.Point(917, 256);
            this.dstb_chitiet.Name = "dstb_chitiet";
            this.dstb_chitiet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.dstb_chitiet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dstb_chitiet.OnHoverForeColor = System.Drawing.Color.White;
            this.dstb_chitiet.OnHoverImage = null;
            this.dstb_chitiet.OnPressedColor = System.Drawing.Color.Black;
            this.dstb_chitiet.Radius = 10;
            this.dstb_chitiet.Size = new System.Drawing.Size(160, 41);
            this.dstb_chitiet.TabIndex = 7;
            this.dstb_chitiet.Text = "Chi tiết";
            this.dstb_chitiet.Click += new System.EventHandler(this.dstb_chitiet_Click);
            // 
            // dstb_id
            // 
            this.dstb_id.Location = new System.Drawing.Point(905, 184);
            this.dstb_id.Multiline = true;
            this.dstb_id.Name = "dstb_id";
            this.dstb_id.Size = new System.Drawing.Size(156, 28);
            this.dstb_id.TabIndex = 10;
            this.dstb_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dstb_ten
            // 
            this.dstb_ten.Location = new System.Drawing.Point(890, 222);
            this.dstb_ten.Name = "dstb_ten";
            this.dstb_ten.Size = new System.Drawing.Size(187, 20);
            this.dstb_ten.TabIndex = 11;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 4.075472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(15, 58);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(42, 10);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Chức năng :";
            // 
            // danhmucthietbi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 730);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.dstb_ten);
            this.Controls.Add(this.dstb_id);
            this.Controls.Add(this.dstb_chitiet);
            this.Controls.Add(this.dstb_qrtb);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.ds_thietbi);
            this.Controls.Add(this.dstb_lammoi);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "danhmucthietbi_form";
            this.Text = "danhmucthietbi_form";
            this.Load += new System.EventHandler(this.danhmucthietbi_form_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_thietbi)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstb_qrtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox dstb_timID;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton dstb_tim;
        private Guna.UI.WinForms.GunaButton dstb_lammoi;
        private Guna.UI.WinForms.GunaButton dstb_themmoi;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView ds_thietbi;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton dstb_phanloai;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox dstb_pl;
        private Guna.UI.WinForms.GunaPictureBox dstb_qrtb;
        private Guna.UI.WinForms.GunaButton dstb_xoa;
        private Guna.UI.WinForms.GunaButton dstb_chinhsua;
        private Guna.UI.WinForms.GunaButton dstb_chitiet;
        private System.Windows.Forms.TextBox dstb_id;
        private System.Windows.Forms.TextBox dstb_ten;
        private Guna.UI.WinForms.GunaButton dstb_pl_huy;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox dstb_pl_tukhoa;
    }
}