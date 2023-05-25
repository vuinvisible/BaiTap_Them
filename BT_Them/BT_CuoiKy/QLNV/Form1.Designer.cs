namespace QLNV
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
            this.gridQLNV = new System.Windows.Forms.DataGridView();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lbHSL = new System.Windows.Forms.Label();
            this.lbHoDem = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.tbxHoDem = new System.Windows.Forms.TextBox();
            this.tbxHSL = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.grbTTNV = new System.Windows.Forms.GroupBox();
            this.tbxLCB = new System.Windows.Forms.TextBox();
            this.lbLCB = new System.Windows.Forms.Label();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuong = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btSapXep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridQLNV)).BeginInit();
            this.grbTTNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridQLNV
            // 
            this.gridQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQLNV.Location = new System.Drawing.Point(4, 12);
            this.gridQLNV.Name = "gridQLNV";
            this.gridQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridQLNV.Size = new System.Drawing.Size(523, 493);
            this.gridQLNV.TabIndex = 0;
            this.gridQLNV.SelectionChanged += new System.EventHandler(this.gridQLNV_SelectionChanged);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(6, 50);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(72, 13);
            this.lbMaNV.TabIndex = 2;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(247, 97);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(247, 154);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(38, 13);
            this.lbPhong.TabIndex = 4;
            this.lbPhong.Text = "Phòng";
            // 
            // lbHSL
            // 
            this.lbHSL.AutoSize = true;
            this.lbHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHSL.Location = new System.Drawing.Point(247, 205);
            this.lbHSL.Name = "lbHSL";
            this.lbHSL.Size = new System.Drawing.Size(64, 13);
            this.lbHSL.TabIndex = 5;
            this.lbHSL.Text = "Hệ số lương";
            // 
            // lbHoDem
            // 
            this.lbHoDem.AutoSize = true;
            this.lbHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoDem.Location = new System.Drawing.Point(247, 50);
            this.lbHoDem.Name = "lbHoDem";
            this.lbHoDem.Size = new System.Drawing.Size(45, 13);
            this.lbHoDem.TabIndex = 6;
            this.lbHoDem.Text = "Họ đệm";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(6, 154);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioiTinh.TabIndex = 7;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Location = new System.Drawing.Point(6, 208);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(47, 13);
            this.lbChucVu.TabIndex = 8;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaNV.Location = new System.Drawing.Point(84, 47);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.Size = new System.Drawing.Size(149, 20);
            this.tbxMaNV.TabIndex = 9;
            // 
            // tbxHoDem
            // 
            this.tbxHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoDem.Location = new System.Drawing.Point(323, 47);
            this.tbxHoDem.Name = "tbxHoDem";
            this.tbxHoDem.Size = new System.Drawing.Size(159, 20);
            this.tbxHoDem.TabIndex = 10;
            // 
            // tbxHSL
            // 
            this.tbxHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHSL.Location = new System.Drawing.Point(323, 201);
            this.tbxHSL.Name = "tbxHSL";
            this.tbxHSL.Size = new System.Drawing.Size(149, 20);
            this.tbxHSL.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(307, 97);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(179, 20);
            this.dtpNgaySinh.TabIndex = 12;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(95, 152);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 13;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(171, 152);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 14;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // cbbPhong
            // 
            this.cbbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(323, 154);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(149, 21);
            this.cbbPhong.TabIndex = 15;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(84, 202);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(149, 21);
            this.cbbChucVu.TabIndex = 16;
            // 
            // grbTTNV
            // 
            this.grbTTNV.Controls.Add(this.tbxLCB);
            this.grbTTNV.Controls.Add(this.lbLCB);
            this.grbTTNV.Controls.Add(this.tbxTen);
            this.grbTTNV.Controls.Add(this.lbTen);
            this.grbTTNV.Controls.Add(this.tbxDiaChi);
            this.grbTTNV.Controls.Add(this.tbxSDT);
            this.grbTTNV.Controls.Add(this.lbDiaChi);
            this.grbTTNV.Controls.Add(this.lbSDT);
            this.grbTTNV.Controls.Add(this.tbxMaNV);
            this.grbTTNV.Controls.Add(this.cbbChucVu);
            this.grbTTNV.Controls.Add(this.lbMaNV);
            this.grbTTNV.Controls.Add(this.lbChucVu);
            this.grbTTNV.Controls.Add(this.rdbNu);
            this.grbTTNV.Controls.Add(this.tbxHoDem);
            this.grbTTNV.Controls.Add(this.rdbNam);
            this.grbTTNV.Controls.Add(this.lbNgaySinh);
            this.grbTTNV.Controls.Add(this.cbbPhong);
            this.grbTTNV.Controls.Add(this.lbGioiTinh);
            this.grbTTNV.Controls.Add(this.dtpNgaySinh);
            this.grbTTNV.Controls.Add(this.tbxHSL);
            this.grbTTNV.Controls.Add(this.lbPhong);
            this.grbTTNV.Controls.Add(this.lbHoDem);
            this.grbTTNV.Controls.Add(this.lbHSL);
            this.grbTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTNV.Location = new System.Drawing.Point(536, 25);
            this.grbTTNV.Name = "grbTTNV";
            this.grbTTNV.Size = new System.Drawing.Size(492, 366);
            this.grbTTNV.TabIndex = 17;
            this.grbTTNV.TabStop = false;
            this.grbTTNV.Text = "Thông tin nhân viên";
            // 
            // tbxLCB
            // 
            this.tbxLCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLCB.Location = new System.Drawing.Point(84, 262);
            this.tbxLCB.Name = "tbxLCB";
            this.tbxLCB.Size = new System.Drawing.Size(149, 20);
            this.tbxLCB.TabIndex = 24;
            // 
            // lbLCB
            // 
            this.lbLCB.AutoSize = true;
            this.lbLCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLCB.Location = new System.Drawing.Point(6, 265);
            this.lbLCB.Name = "lbLCB";
            this.lbLCB.Size = new System.Drawing.Size(73, 13);
            this.lbLCB.TabIndex = 23;
            this.lbLCB.Text = "Lương cơ bản";
            // 
            // tbxTen
            // 
            this.tbxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTen.Location = new System.Drawing.Point(84, 96);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(149, 20);
            this.tbxTen.TabIndex = 22;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(6, 100);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(26, 13);
            this.lbTen.TabIndex = 21;
            this.lbTen.Text = "Tên";
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiaChi.Location = new System.Drawing.Point(84, 320);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(149, 20);
            this.tbxDiaChi.TabIndex = 20;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSDT.Location = new System.Drawing.Point(323, 258);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(151, 20);
            this.tbxSDT.TabIndex = 19;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(6, 323);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbDiaChi.TabIndex = 18;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(247, 265);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(70, 13);
            this.lbSDT.TabIndex = 17;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(545, 397);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 18;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(681, 397);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(819, 397);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 20;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(947, 397);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 21;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(947, 446);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 22;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuong
            // 
            this.btLuong.Location = new System.Drawing.Point(545, 446);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(75, 23);
            this.btLuong.TabIndex = 23;
            this.btLuong.Text = "Lương";
            this.btLuong.UseVisualStyleBackColor = true;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(681, 446);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btLamMoi.TabIndex = 24;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btSapXep
            // 
            this.btSapXep.Location = new System.Drawing.Point(819, 446);
            this.btSapXep.Name = "btSapXep";
            this.btSapXep.Size = new System.Drawing.Size(75, 23);
            this.btSapXep.TabIndex = 25;
            this.btSapXep.Text = "Sắp xếp";
            this.btSapXep.UseVisualStyleBackColor = true;
            this.btSapXep.Click += new System.EventHandler(this.btSapXep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 517);
            this.Controls.Add(this.btSapXep);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btLuong);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.grbTTNV);
            this.Controls.Add(this.gridQLNV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridQLNV)).EndInit();
            this.grbTTNV.ResumeLayout(false);
            this.grbTTNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridQLNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbHSL;
        private System.Windows.Forms.Label lbHoDem;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.TextBox tbxHoDem;
        private System.Windows.Forms.TextBox tbxHSL;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.GroupBox grbTTNV;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox tbxLCB;
        private System.Windows.Forms.Label lbLCB;
        private System.Windows.Forms.Button btLuong;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btSapXep;
    }
}

