namespace Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.grbDsSinhNhat = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lstDsSinhNhat = new System.Windows.Forms.ListBox();
            this.btThangNay = new System.Windows.Forms.Button();
            this.btThangToi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNgSinh = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.grbDanhSach.SuspendLayout();
            this.grbDsSinhNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ lót:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.lstDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(33, 202);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(238, 193);
            this.grbDanhSach.TabIndex = 3;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách";
            // 
            // grbDsSinhNhat
            // 
            this.grbDsSinhNhat.Controls.Add(this.lstDsSinhNhat);
            this.grbDsSinhNhat.Location = new System.Drawing.Point(439, 202);
            this.grbDsSinhNhat.Name = "grbDsSinhNhat";
            this.grbDsSinhNhat.Size = new System.Drawing.Size(241, 193);
            this.grbDsSinhNhat.TabIndex = 4;
            this.grbDsSinhNhat.TabStop = false;
            this.grbDsSinhNhat.Text = "Danh sách sinh nhật";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(18, 19);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(206, 160);
            this.lstDanhSach.TabIndex = 0;
            // 
            // lstDsSinhNhat
            // 
            this.lstDsSinhNhat.FormattingEnabled = true;
            this.lstDsSinhNhat.Location = new System.Drawing.Point(23, 19);
            this.lstDsSinhNhat.Name = "lstDsSinhNhat";
            this.lstDsSinhNhat.Size = new System.Drawing.Size(206, 160);
            this.lstDsSinhNhat.TabIndex = 1;
            // 
            // btThangNay
            // 
            this.btThangNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThangNay.Location = new System.Drawing.Point(311, 221);
            this.btThangNay.Name = "btThangNay";
            this.btThangNay.Size = new System.Drawing.Size(99, 35);
            this.btThangNay.TabIndex = 5;
            this.btThangNay.Text = "Tháng này";
            this.btThangNay.UseVisualStyleBackColor = true;
            this.btThangNay.Click += new System.EventHandler(this.btThangNay_Click);
            // 
            // btThangToi
            // 
            this.btThangToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThangToi.Location = new System.Drawing.Point(311, 288);
            this.btThangToi.Name = "btThangToi";
            this.btThangToi.Size = new System.Drawing.Size(99, 33);
            this.btThangToi.TabIndex = 6;
            this.btThangToi.Text = "Tháng tới";
            this.btThangToi.UseVisualStyleBackColor = true;
            this.btThangToi.Click += new System.EventHandler(this.btThangToi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(311, 352);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(99, 29);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(127, 33);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(158, 20);
            this.txtHoLot.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(127, 93);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(158, 20);
            this.txtTen.TabIndex = 9;
            // 
            // txtNgSinh
            // 
            this.txtNgSinh.Location = new System.Drawing.Point(127, 148);
            this.txtNgSinh.Name = "txtNgSinh";
            this.txtNgSinh.Size = new System.Drawing.Size(158, 20);
            this.txtNgSinh.TabIndex = 10;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(335, 27);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 30);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtNgSinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThangToi);
            this.Controls.Add(this.btThangNay);
            this.Controls.Add(this.grbDsSinhNhat);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai tap 1";
            this.grbDanhSach.ResumeLayout(false);
            this.grbDsSinhNhat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.GroupBox grbDsSinhNhat;
        private System.Windows.Forms.ListBox lstDsSinhNhat;
        private System.Windows.Forms.Button btThangNay;
        private System.Windows.Forms.Button btThangToi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNgSinh;
        private System.Windows.Forms.Button btThem;
    }
}

