namespace BT_ADO
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
            this.lbMaNV = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbHSL = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbPhongBan = new System.Windows.Forms.Label();
            this.lbHSL = new System.Windows.Forms.Label();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.gridDSNV = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.tbNgaysinh = new System.Windows.Forms.TextBox();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.tbChucVu = new System.Windows.Forms.TextBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(35, 28);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(116, 25);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(172, 20);
            this.tbMaNV.TabIndex = 1;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(407, 29);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(172, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // tbHSL
            // 
            this.tbHSL.Location = new System.Drawing.Point(116, 164);
            this.tbHSL.Name = "tbHSL";
            this.tbHSL.Size = new System.Drawing.Size(172, 20);
            this.tbHSL.TabIndex = 4;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(354, 32);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(39, 13);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbPhongBan
            // 
            this.lbPhongBan.AutoSize = true;
            this.lbPhongBan.Location = new System.Drawing.Point(35, 115);
            this.lbPhongBan.Name = "lbPhongBan";
            this.lbPhongBan.Size = new System.Drawing.Size(59, 13);
            this.lbPhongBan.TabIndex = 7;
            this.lbPhongBan.Text = "Phòng ban";
            // 
            // lbHSL
            // 
            this.lbHSL.AutoSize = true;
            this.lbHSL.Location = new System.Drawing.Point(35, 164);
            this.lbHSL.Name = "lbHSL";
            this.lbHSL.Size = new System.Drawing.Size(64, 13);
            this.lbHSL.TabIndex = 8;
            this.lbHSL.Text = "Hệ số lương";
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(116, 112);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(172, 21);
            this.cbbPhongBan.TabIndex = 9;
            this.cbbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbbPhongBan_SelectedIndexChanged);
            // 
            // gridDSNV
            // 
            this.gridDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSNV.Location = new System.Drawing.Point(38, 213);
            this.gridDSNV.Name = "gridDSNV";
            this.gridDSNV.Size = new System.Drawing.Size(721, 213);
            this.gridDSNV.TabIndex = 10;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(670, 32);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 11;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(670, 74);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(35, 70);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 13;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // tbNgaysinh
            // 
            this.tbNgaysinh.Location = new System.Drawing.Point(116, 67);
            this.tbNgaysinh.Name = "tbNgaysinh";
            this.tbNgaysinh.Size = new System.Drawing.Size(172, 20);
            this.tbNgaysinh.TabIndex = 14;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(354, 74);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioiTinh.TabIndex = 15;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(407, 67);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(172, 20);
            this.tbGioiTinh.TabIndex = 16;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(354, 115);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(47, 13);
            this.lbChucVu.TabIndex = 17;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // tbChucVu
            // 
            this.tbChucVu.Location = new System.Drawing.Point(413, 113);
            this.tbChucVu.Name = "tbChucVu";
            this.tbChucVu.Size = new System.Drawing.Size(166, 20);
            this.tbChucVu.TabIndex = 18;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(670, 115);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 19;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(670, 159);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.tbChucVu);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.tbNgaysinh);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.gridDSNV);
            this.Controls.Add(this.cbbPhongBan);
            this.Controls.Add(this.lbHSL);
            this.Controls.Add(this.lbPhongBan);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.tbHSL);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.lbMaNV);
            this.Name = "Form1";
            this.Text = "Demo QLNS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbHSL;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbPhongBan;
        private System.Windows.Forms.Label lbHSL;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.DataGridView gridDSNV;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox tbNgaysinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.TextBox tbChucVu;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
    }
}

