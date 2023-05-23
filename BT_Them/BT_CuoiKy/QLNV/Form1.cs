using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace QLNV
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
        }

        public void load_Phong()
        {
            var phong = from ph in db.PHONGBANs
                        select new { TenPhong = ph.TenPhong, MaPhong = ph.MaPhong };
            cbbPhong.DataSource = phong.ToList();
            cbbPhong.DisplayMember = "TenPhong";
            cbbPhong.ValueMember = "MaPhong";
        }

        public void load_ChucVu()
        {
            var chucvu = from cv in db.CHUCVUs
                         select new { TenChucVu = cv.TenChucVu, MaChucVu = cv.MaChucVu };
            cbbChucVu.DataSource = chucvu.ToList();
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
        }

        public bool checkMaNV(string manv)
        {
            //trả về true nếu tìm thấy bất kỳ bản ghi DSNV nào có MaNV giống với giá trị được truyền vào
            return db.DSNVs.Any(ma => ma.MaNV == manv);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridQLNV_SelectionChanged(object sender, EventArgs e)
        {
            if (gridQLNV.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = gridQLNV.SelectedRows[0];
                tbxMaNV.Text = Row.Cells["MaNV"].Value.ToString();
                tbxHoDem.Text = Row.Cells["HoDem"].Value.ToString();
                tbxTen.Text = Row.Cells["Ten"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(Row.Cells["NgaySinh"].Value);
                if ((bool)Row.Cells["GioiTinh"].Value == true)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                cbbPhong.SelectedValue = Row.Cells["MaPhong"].Value;
                cbbChucVu.SelectedValue = Row.Cells["MaChucVu"].Value;
                tbxHSL.Text = Row.Cells["HeSoLuong"].Value.ToString();
                tbxSDT.Text = Row.Cells["SoDienThoai"].Value.ToString();
                tbxDiaChi.Text = Row.Cells["DiaChi"].Value.ToString();
            }
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

            if (string.IsNullOrEmpty(tbxMaNV.Text) || string.IsNullOrEmpty(tbxHoDem.Text) || string.IsNullOrEmpty(tbxTen.Text) || string.IsNullOrEmpty(tbxHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DSNV nv = new DSNV();
            nv.MaNV = tbxMaNV.Text.Trim();
            nv.HoDem = tbxHoDem.Text.Trim();
            nv.Ten = tbxTen.Text.Trim();
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.GioiTinh = gt;
            nv.MaPhong = cbbPhong.SelectedValue.ToString();
            nv.MaChucVu = cbbChucVu.SelectedValue.ToString();
            nv.HeSoLuong = Convert.ToDouble(tbxHSL.Text);
            nv.SoDienThoai = tbxSDT.Text.Trim();
            nv.DiaChi = tbxDiaChi.Text.Trim();

            db.DSNVs.InsertOnSubmit(nv);
            db.SubmitChanges();

            load_Grid();

            MessageBox.Show("Thêm nhân viên mới thành công!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!checkMaNV(tbxMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                DSNV nv = db.DSNVs.Where(p => p.MaNV.Equals(tbxMaNV.Text.Trim())).SingleOrDefault();
                db.DSNVs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                load_Grid();
                MessageBox.Show("Xoá nhân viên thành công!");
            }
            else
                MessageBox.Show("Xoá nhân viên thất bại!");
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (!checkMaNV(tbxMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            Boolean gt;
            if (rdbNam.Checked == true)
                gt = true;
            else
                gt = false;

            if (string.IsNullOrEmpty(tbxMaNV.Text) || string.IsNullOrEmpty(tbxHoDem.Text) || string.IsNullOrEmpty(tbxTen.Text) || string.IsNullOrEmpty(tbxHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DSNV nv = db.DSNVs.Where(p => p.MaNV.Equals(tbxMaNV.Text.Trim())).SingleOrDefault();
            if (nv != null)
            {
                nv.HoDem = tbxHoDem.Text.Trim();
                nv.Ten = tbxTen.Text.Trim();
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.GioiTinh = gt;
                nv.MaPhong = cbbPhong.SelectedValue.ToString();
                nv.MaChucVu = cbbChucVu.SelectedValue.ToString();
                nv.HeSoLuong = Convert.ToDouble(tbxHSL.Text);
                nv.SoDienThoai = tbxSDT.Text.Trim();
                nv.DiaChi = tbxDiaChi.Text.Trim();

                db.SubmitChanges();
                load_Grid();
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
            }
            else
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên tìm kiếm!");
                return;
            }

            var kq = from tim in db.DSNVs
                     where tim.Ten.Contains(tbxTen.Text.Trim())
                     select tim;
            gridQLNV.DataSource = kq.ToList();
        }
    }
}
