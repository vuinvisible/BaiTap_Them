﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace BT_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        QLNVDataContext db = new QLNVDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            load_Grid();
            load_Phong();
            load_ChucVu();
        }

        public void load_Grid()
        {
            Table<DSNV> dsnv = db.GetTable<DSNV>();
            db.Refresh(RefreshMode.OverwriteCurrentValues, db.DSNVs);
            gridQLNV.DataSource = dsnv;
            //gridQLNV.SelectionChanged += gridQLNV_SelectionChanged;
        }

        public void load_Phong()
        {
            var phong = from p in db.DMPHONGs
                        select new { TenPhong = p.TenPhong, MaPhong = p.MaPhong };
            cbbPhong.DataSource = phong.ToList();
            cbbPhong.DisplayMember = "TenPhong";
            cbbPhong.ValueMember = "MaPhong";
        }

        public void load_ChucVu()
        {
            var chucvu = from cv in db.CHUCVUs
                         select new {TenChucVu = cv.TenChucVu, MaChucVu = cv.MaChucVu };
            cbbChucVu.DataSource = chucvu.ToList();
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kq = from p in db.DSNVs
                     where p.MaPhong == cbbPhong.SelectedValue.ToString()
                     select p;
            gridQLNV.DataSource = kq.ToList();
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kq = from cv in db.DSNVs
                     where cv.MaChucVu == cbbChucVu.SelectedValue.ToString()
                     select cv;
            gridQLNV.DataSource = kq.ToList();
        }

        public bool checkMaNV(string manv)
        {
            //trả về true nếu tìm thấy bất kỳ bản ghi DSNV nào có MaNV giống với giá trị được truyền vào
            return db.DSNVs.Any(ma => ma.MaNV == manv);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (checkMaNV(tbxMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            Boolean gt;
            if (rdbNam.Checked == true)
                gt = true;
            else
                gt = false;

            if (string.IsNullOrEmpty(tbxMaNV.Text) || string.IsNullOrEmpty(tbxHoTen.Text) || string.IsNullOrEmpty(tbxHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DSNV nv = new DSNV();
            nv.MaNV = tbxMaNV.Text.Trim();
            nv.HoTen = tbxHoTen.Text.Trim();
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.GioiTinh = gt;
            nv.MaPhong = cbbPhong.SelectedValue.ToString();
            nv.HeSoLuong = Convert.ToDouble(tbxHSL.Text.Trim());
            nv.MaChucVu = cbbChucVu.SelectedValue.ToString();

            db.DSNVs.InsertOnSubmit(nv);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công!");
            load_Grid();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxHoTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên tìm kiếm!");
                return;
            }
            var kq = from tim in db.DSNVs
                     where tim.HoTen.Contains(tbxHoTen.Text.Trim())
                     select tim;
            gridQLNV.DataSource = kq.ToList();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string manv= tbxMaNV.Text.Trim();
            if (!checkMaNV(manv))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                DSNV nv = db.DSNVs.Where(p => p.MaNV.Equals(manv)).SingleOrDefault();
                db.DSNVs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Xoá thành công!");
                load_Grid();
            }
            else
                MessageBox.Show("Xoá thất bại!");
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string manv = tbxMaNV.Text.Trim();
            if (!checkMaNV(manv))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            Boolean gt;
            if (rdbNam.Checked == true)
                gt = true;
            else
                gt = false;
            if (string.IsNullOrEmpty(tbxMaNV.Text) || string.IsNullOrEmpty(tbxHoTen.Text) || string.IsNullOrEmpty(tbxHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DSNV nv = db.DSNVs.SingleOrDefault(p => p.MaNV == manv);
            if (nv != null)
            {
                nv.HoTen = tbxHoTen.Text.Trim();
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.GioiTinh = gt;
                nv.MaPhong = cbbPhong.SelectedValue.ToString();
                nv.HeSoLuong = Convert.ToDouble(tbxHSL.Text.Trim());
                nv.MaChucVu = cbbChucVu.SelectedValue.ToString();

                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!");
                load_Grid();
            }
        }

        private void gridQLNV_SelectionChanged(object sender, EventArgs e)
        {
            if (gridQLNV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridQLNV.SelectedRows[0];
                tbxMaNV.Text = row.Cells["MaNV"].Value.ToString();
                tbxHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)row.Cells["NgaySinh"].Value;
                if ((bool)row.Cells["GioiTinh"].Value == true)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                cbbPhong.SelectedValue = row.Cells["MaPhong"].Value.ToString();
                tbxHSL.Text = row.Cells["HeSoLuong"].Value.ToString();
                cbbChucVu.SelectedValue = row.Cells["MaChucVu"].Value.ToString();
            }
        }
    }
}
