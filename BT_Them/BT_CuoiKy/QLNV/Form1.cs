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
using System.Data.SqlClient;

namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connStr = "Server = LAB1-MAY11\\SQLEXPRESS; Database = QLNV1; Trusted_Connection = true";
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        private void Form1_Load(object sender, EventArgs e)
        {
            load_Grid();
            load_Phong();
            load_ChucVu();
            tbxHSL.Text = "1";
            tbxLCB.Text = "0";
        }

        public void load_Grid()
        {
            DataTable dt = new DataTable();
            string sqlDSNV = "select * from DSNV";
            da = new SqlDataAdapter(sqlDSNV, connStr);
            da.Fill(dt);
            gridQLNV.DataSource = dt;
        }

        public void load_Phong()
        {
            string sqlPB = "select * from PHONGBAN";
            da = new SqlDataAdapter(sqlPB, connStr);
            da.Fill(ds, "PHONGBAN");
            cbbPhong.DataSource = ds.Tables["PHONGBAN"];
            cbbPhong.DisplayMember = "TenPhong";
            cbbPhong.ValueMember = "MaPhong";
        }

        //private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    string sqlDSNV = " select * from DSNV where MaPhong = N'" + cbbPhong.SelectedValue.ToString() + "' ";
        //    da = new SqlDataAdapter(sqlDSNV, connStr);
        //    da.Fill(dt);
        //    gridQLNV.DataSource = dt;
        //}

        public void load_ChucVu()
        {
            string sqlCV = "select * from CHUCVU";
            da = new SqlDataAdapter(sqlCV, connStr);
            da.Fill(ds, "CHUCVU");
            cbbChucVu.DataSource = ds.Tables["CHUCVU"];
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
        }

        //private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    string sqlDSNV = " select * from DSNV where MaChucVu = N'" + cbbChucVu.SelectedValue.ToString() + "' ";
        //    da = new SqlDataAdapter(sqlDSNV, connStr);
        //    da.Fill(dt);
        //    gridQLNV.DataSource = dt;
        //}

        public bool checkMaNV(string manv)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlCheck = "select * from DSNV where MaNV = @manv";
                using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@manv", manv.Trim());
                    conn.Open();
                    SqlDataReader dr = cmdCheck.ExecuteReader();
                    return dr.HasRows;
                }
            }
        }

        public bool checkTT() //Kiểm tra thông tin nhập vào co đủ hay không
        {
            //Nếu 1 trong các ô text box rỗng thì trả về false
            if (string.IsNullOrEmpty(tbxMaNV.Text.Trim()) || string.IsNullOrEmpty(tbxHoDem.Text.Trim()) || string.IsNullOrEmpty(tbxTen.Text.Trim()) || string.IsNullOrEmpty(tbxHSL.Text.Trim()) || string.IsNullOrEmpty(tbxLCB.Text.Trim()) || string.IsNullOrEmpty(tbxSDT.Text.Trim()) || string.IsNullOrEmpty(tbxDiaChi.Text.Trim()))
                return false;
            return true;
        }

        public bool checkLCBHSL(string lcb, string hsl) //Kiểm tra lương cơ bản và hệ số lương có phải là số thực hay không
        {
            double luongcoban, hesoluong;
            //Hàm double.TryParse để chuyển đổi giá trị chuỗi nhập vào thành số thực nếu thất bại thì trả về false
            if (!double.TryParse(lcb.Trim(), out luongcoban) || !double.TryParse(hsl.Trim(), out hesoluong))
                return false;
            return true;
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
                tbxLCB.Text = Row.Cells["LuongCoBan"].Value.ToString();
                tbxSDT.Text = Row.Cells["SoDienThoai"].Value.ToString();
                tbxDiaChi.Text = Row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (checkMaNV(tbxMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên '"+ tbxMaNV.Text +"' đã tồn tại!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "insert into DSNV(MaNV, HoDem, Ten, NgaySinh, GioiTinh, MaPhong, MaChucVu, HeSoLuong, LuongCoBan, SoDienThoai, DiaChi) " +
                             "values (@manv, @hd, @ten, @ngs, @gt, @maphong, @mcv, @hsl, @lcb, @sdt, @dc)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    Boolean gt;
                    if (rdbNam.Checked == true)
                        gt = true;
                    else
                        gt = false;

                    if (!checkTT())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }

                    if(!checkLCBHSL(tbxLCB.Text.Trim(), tbxHSL.Text.Trim()))
                    {
                        MessageBox.Show("Lương cơ bản và hệ số lương phải là 1 số!");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@manv", tbxMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@hd", tbxHoDem.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", tbxTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngs", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@gt", gt);
                    cmd.Parameters.AddWithValue("@maphong", cbbPhong.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@mcv", cbbChucVu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@hsl", Convert.ToDouble(tbxHSL.Text.Trim()));
                    cmd.Parameters.AddWithValue("@lcb", Convert.ToDouble(tbxLCB.Text.Trim()));
                    cmd.Parameters.AddWithValue("@sdt", tbxSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@dc", tbxDiaChi.Text.Trim());

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm mới nhân viên '" + tbxMaNV.Text + "' thành công!");
                        load_Grid();
                    }
                    else
                        MessageBox.Show("Thêm mới nhân viên '" + tbxMaNV.Text + "' thất bại!");
                }
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!checkMaNV(tbxMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên '" + tbxMaNV.Text + "' không tồn tại!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlDel = "delete from DSNV where MaNV = @manv";
                using (SqlCommand cmdDel = new SqlCommand(sqlDel, conn))
                {

                    cmdDel.Parameters.AddWithValue("@manv", tbxMaNV.Text.Trim());

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        int result1 = cmdDel.ExecuteNonQuery();

                        if (result1 > 0)
                        {
                            MessageBox.Show("Xoá nhân viên '" + tbxMaNV.Text + "' thành công!");
                            load_Grid();
                        }
                        else
                            MessageBox.Show("Xóa nhân viên '" + tbxMaNV.Text + "' thất bại!");
                    }
                }
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (!checkMaNV(tbxMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên '"+ tbxMaNV.Text +"' không tồn tại!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlUP = "update DSNV set HoDem = @hd, Ten = @ten, NgaySinh = @ngs, GioiTinh = @gt, MaPhong = @maphong, MaChucVu = @mcv, HeSoLuong = @hsl, LuongCoBan = @lcb, SoDienThoai = @sdt, DiaChi = @dc " +
                               "where MaNV = @manv";
                using (SqlCommand cmdUP = new SqlCommand(sqlUP, conn))
                {

                    Boolean gt;
                    if (rdbNam.Checked == true)
                        gt = true;
                    else
                        gt = false;

                    if (!checkTT())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }

                    if (!checkLCBHSL(tbxLCB.Text.Trim(), tbxHSL.Text.Trim()))
                    {
                        MessageBox.Show("Lương cơ bản và hệ số lương phải là 1 số!");
                        return;
                    }

                    cmdUP.Parameters.AddWithValue("@manv", tbxMaNV.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@hd", tbxHoDem.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@ten", tbxTen.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@ngs", dtpNgaySinh.Value);
                    cmdUP.Parameters.AddWithValue("@gt", gt);
                    cmdUP.Parameters.AddWithValue("@maphong", cbbPhong.SelectedValue.ToString());
                    cmdUP.Parameters.AddWithValue("@mcv", cbbChucVu.SelectedValue.ToString());
                    cmdUP.Parameters.AddWithValue("@hsl", Convert.ToDouble(tbxHSL.Text.Trim()));
                    cmdUP.Parameters.AddWithValue("@lcb", Convert.ToDouble(tbxLCB.Text.Trim()));
                    cmdUP.Parameters.AddWithValue("@sdt", tbxSDT.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@dc", tbxDiaChi.Text.Trim());

                    conn.Open();
                    int result2 = cmdUP.ExecuteNonQuery();

                    if (result2 > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên '" + tbxMaNV.Text + "' thành công!");
                        load_Grid();
                    }  
                    else
                        MessageBox.Show("Cập nhật thông tin nhân viên '" + tbxMaNV.Text + "' thất bại!");
                }

            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm kiếm!");
                return;
            }

            string sqlTim = "select * from DSNV where Ten like N'%" + tbxTen.Text + "%'";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sqlTim, connStr);
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
                gridQLNV.DataSource = dt;
            else
                MessageBox.Show("Không tìm thấy nhân viên có tên: '" + tbxTen.Text + "'");
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlLuong = "SELECT DSNV.MaNV, DSNV.LuongCoBan, DSNV.HeSoLuong, CHUCVU.PhuCapCV, " +
                                  "(DSNV.LuongCoBan * DSNV.HeSoLuong + CHUCVU.PhuCapCV) AS LuongThucNhan " +
                                  "FROM DSNV " +
                                  "INNER JOIN CHUCVU ON DSNV.MaChucVu = CHUCVU.MaChucVu " +
                                  "WHERE DSNV.MaNV = @manv";

                using (SqlCommand cmd = new SqlCommand(sqlLuong, conn))
                {
                    if (string.IsNullOrEmpty(tbxMaNV.Text.Trim()) || !checkMaNV(tbxMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Vui lòng nhập mã nhân viên để tính lương!");
                        return;
                    }

                    double luongThucNhan = 0;
                    if (checkLCBHSL(tbxLCB.Text.Trim(), tbxHSL.Text.Trim()))
                    {
                        cmd.Parameters.AddWithValue("@manv", tbxMaNV.Text.Trim());
                        
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                luongThucNhan = Convert.ToDouble(dr["LuongThucNhan"]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên với mã " + tbxMaNV.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lương cơ bản và hệ số lương phải là 1 số!");
                        return;
                    }

                    MessageBox.Show("Lương thực nhận của nhân viên có mã " + tbxMaNV.Text + " là: " + luongThucNhan.ToString("#,##0") + " VND.");
                }
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            tbxMaNV.Text = "";
            tbxHoDem.Text = "";
            tbxTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now; // gán ngày hiện tại
            rdbNam.Checked = true;
            cbbPhong.SelectedIndex = 0; // chọn item đầu tiên trong ComboBox
            cbbChucVu.SelectedIndex = 0; // chọn item đầu tiên trong ComboBox
            tbxHSL.Text = "1";
            tbxLCB.Text = "0";
            tbxSDT.Text = "";
            tbxDiaChi.Text = "";
        }

        private void btSapXep_Click(object sender, EventArgs e)
        {
            string sqlSX = "select * from DSNV order by Ten asc";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sqlSX, connStr);
            da.Fill(dt);
            gridQLNV.DataSource = dt;
        }

    }
}
