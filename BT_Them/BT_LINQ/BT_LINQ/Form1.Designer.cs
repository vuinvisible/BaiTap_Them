namespace BT_LINQ
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
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.gridQLNV = new System.Windows.Forms.DataGridView();
            this.btTim = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lbChVu = new System.Windows.Forms.Label();
            this.lbHSL = new System.Windows.Forms.Label();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.tbxHSL = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridQLNV)).BeginInit();
            this.grbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(656, 31);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(656, 81);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // gridQLNV
            // 
            this.gridQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQLNV.Location = new System.Drawing.Point(12, 226);
            this.gridQLNV.Name = "gridQLNV";
            this.gridQLNV.Size = new System.Drawing.Size(776, 212);
            this.gridQLNV.TabIndex = 2;
            this.gridQLNV.SelectionChanged += new System.EventHandler(this.gridQLNV_SelectionChanged);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(656, 184);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(656, 133);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 4;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(31, 31);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(72, 13);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(322, 28);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(39, 13);
            this.lbHoTen.TabIndex = 6;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(31, 80);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 7;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(31, 133);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(38, 13);
            this.lbPhong.TabIndex = 9;
            this.lbPhong.Text = "Phòng";
            // 
            // lbChVu
            // 
            this.lbChVu.AutoSize = true;
            this.lbChVu.Location = new System.Drawing.Point(322, 189);
            this.lbChVu.Name = "lbChVu";
            this.lbChVu.Size = new System.Drawing.Size(47, 13);
            this.lbChVu.TabIndex = 10;
            this.lbChVu.Text = "Chức vụ";
            // 
            // lbHSL
            // 
            this.lbHSL.AutoSize = true;
            this.lbHSL.Location = new System.Drawing.Point(31, 189);
            this.lbHSL.Name = "lbHSL";
            this.lbHSL.Size = new System.Drawing.Size(64, 13);
            this.lbHSL.TabIndex = 11;
            this.lbHSL.Text = "Hệ số lương";
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.rdbNu);
            this.grbGioiTinh.Controls.Add(this.rdbNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(325, 80);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(270, 66);
            this.grbGioiTinh.TabIndex = 12;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(156, 31);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(27, 31);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Location = new System.Drawing.Point(109, 28);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.Size = new System.Drawing.Size(128, 20);
            this.tbxMaNV.TabIndex = 13;
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Location = new System.Drawing.Point(390, 28);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(145, 20);
            this.tbxHoTen.TabIndex = 14;
            // 
            // tbxHSL
            // 
            this.tbxHSL.Location = new System.Drawing.Point(109, 189);
            this.tbxHSL.Name = "tbxHSL";
            this.tbxHSL.Size = new System.Drawing.Size(128, 20);
            this.tbxHSL.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 80);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(202, 20);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(109, 130);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(128, 21);
            this.cbbPhong.TabIndex = 17;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(399, 186);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(136, 21);
            this.cbbChucVu.TabIndex = 18;
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.tbxHSL);
            this.Controls.Add(this.tbxHoTen);
            this.Controls.Add(this.tbxMaNV);
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.lbHSL);
            this.Controls.Add(this.lbChVu);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.gridQLNV);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridQLNV)).EndInit();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView gridQLNV;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbChVu;
        private System.Windows.Forms.Label lbHSL;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.TextBox tbxHSL;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.ComboBox cbbChucVu;
    }
}

