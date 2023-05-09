using System;
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
            gridQLNV.DataSource = dsnv;
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
    }
}
