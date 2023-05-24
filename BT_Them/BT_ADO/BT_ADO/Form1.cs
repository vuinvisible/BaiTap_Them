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
using System.Globalization;

namespace BT_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conn = "Server = LAB1-MAY11\\SQLEXPRESS; Database = QLNV; Trusted_Connection = true";
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        private void Form1_Load(object sender, EventArgs e)
        {
            load_Grid();
            load_CBPhong();
            load_CBChucVu();
        }
       
        public void load_CBPhong()
        {
            string sqlDMP = "select * from DMPHONG";
            da = new SqlDataAdapter(sqlDMP, conn);
            da.Fill(ds, "DMPHONG");
            cbbPhongBan.DataSource = ds.Tables["DMPHONG"];
            cbbPhongBan.DisplayMember = "TenPhong";
            cbbPhongBan.ValueMember = "MaPhong";
        }

        private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlDSNV = " select * from DSNV where MaPhong = N'"+ cbbPhongBan.SelectedValue.ToString()+"' ";
            da = new SqlDataAdapter(sqlDSNV, conn);
            //da.Fill(ds, "DSNV1");
            //gridDSNV.DataSource = ds.Tables["DSNV1"];
            da.Fill(dt);
            gridDSNV.DataSource = dt;
        }

        public void load_CBChucVu()
        {
            string sqlCV = "select * from CHUCVU";
            da = new SqlDataAdapter(sqlCV, conn);
            da.Fill(ds, "CHUCVU");
            cbbChucVu.DataSource = ds.Tables["CHUCVU"];
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlDSNV = " select * from DSNV where MaChucVu = N'" + cbbChucVu.SelectedValue.ToString() + "' ";
            da = new SqlDataAdapter(sqlDSNV, conn);
            //da.Fill(ds, "DSNV2");
            //gridDSNV.DataSource = ds.Tables["DSNV2"];
            da.Fill(dt);
            gridDSNV.DataSource = dt;
        }

        public void load_Grid()
        {
            DataTable dt = new DataTable();
            string sqlDSNV = "select * from DSNV";
            da = new SqlDataAdapter(sqlDSNV, conn);
            //da.Fill(ds, "DSNV");
            //gridDSNV.DataSource = ds.Tables["DSNV"];
            da.Fill(dt);
            gridDSNV.DataSource = dt;
        }

        public bool checkMaNV(string manv)
        {
            using (SqlConnection conn1 = new SqlConnection(conn))
            {
                string sqlCheck = "select * from DSNV where MaNV = @manv";
                using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn1))
                {
                    cmdCheck.Parameters.AddWithValue("@manv", manv.Trim());
                    conn1.Open();
                    SqlDataReader dr = cmdCheck.ExecuteReader();
                    return dr.HasRows;
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (checkMaNV(tbMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            using (SqlConnection conn1 = new SqlConnection(conn))
                {
                    string sql = "insert into DSNV(MaNV, HoTen, NgaySinh, GioiTinh, MaPhong, HeSoLuong, MaChucVu) " +
                                 "values (@manv, @ht, @ngs, @gt, @maphong, @hsl, @mcv)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn1))
                    {
                        Boolean gt;
                        if (rdbNam.Checked == true)
                            gt = true;
                        else
                            gt = false;

                        if(string.IsNullOrEmpty(tbMaNV.Text) || string.IsNullOrEmpty(tbHoTen.Text) || string.IsNullOrEmpty(tbHSL.Text))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                            return;
                        }

                        double hsl;
                        if (!double.TryParse(tbHSL.Text.Trim(), out hsl))
                        {
                            MessageBox.Show("Hệ số lương phải là một số!");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@ht", tbHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngs", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@gt", gt);
                        cmd.Parameters.AddWithValue("@maphong", cbbPhongBan.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@hsl", Convert.ToDouble(tbHSL.Text.Trim()));
                        cmd.Parameters.AddWithValue("@mcv", cbbChucVu.SelectedValue.ToString());

                        conn1.Open();
                             int result = cmd.ExecuteNonQuery();
                        
                        if(result > 0)
                            MessageBox.Show("Thêm thành công!");
                        else
                            MessageBox.Show("Thêm thất bại!");
                        load_Grid();
                    }
                }      
                       
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }
               
            string sql = "select * from DSNV where HoTen like N'%" + tbHoTen.Text + "%'";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            gridDSNV.DataSource = dt;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (!checkMaNV(tbMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            using (SqlConnection conn1 = new SqlConnection(conn))
            {
                string sqlUP = "update DSNV set HoTen = @ht, NgaySinh = @ngs, GioiTinh = @gt, MaPhong = @maphong, HeSoLuong = @hsl, MaChucVu = @mcv where MaNV = @manv";
                using (SqlCommand cmdUP = new SqlCommand(sqlUP, conn1))
                {

                    Boolean gt;
                    if (rdbNam.Checked == true)
                        gt = true;
                    else
                        gt = false;

                    if (string.IsNullOrEmpty(tbMaNV.Text) || string.IsNullOrEmpty(tbHoTen.Text) || string.IsNullOrEmpty(tbHSL.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }

                    double hsl;
                    if (!double.TryParse(tbHSL.Text.Trim(), out hsl))
                    {
                        MessageBox.Show("Hệ số lương phải là một số!");
                        return;
                    }

                    cmdUP.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@ht", tbHoTen.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@ngs", dtpNgaySinh.Value);
                    cmdUP.Parameters.AddWithValue("@gt", gt);
                    cmdUP.Parameters.AddWithValue("@maphong", cbbPhongBan.SelectedValue.ToString());
                    cmdUP.Parameters.AddWithValue("@hsl", Convert.ToDouble(tbHSL.Text.Trim()));
                    cmdUP.Parameters.AddWithValue("@mcv", cbbChucVu.SelectedValue.ToString());

                    conn1.Open();
                    int result = cmdUP.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Cập nhật thành công!"); 
                    else
                        MessageBox.Show("Cập nhật thất bại!");
                    load_Grid();
                }
                        
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!checkMaNV(tbMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            using (SqlConnection conn1 = new SqlConnection(conn))
            {
                string sqlDel = "delete from DSNV where MaNV = @manv";
                using(SqlCommand cmdDel = new SqlCommand(sqlDel, conn1))
                {

                    cmdDel.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn1.Open();
                        int result1 = cmdDel.ExecuteNonQuery();
 
                        if (result1 > 0)
                            MessageBox.Show("Xóa thành công!");
                        else
                            MessageBox.Show("Xóa thất bại!");
                        load_Grid();
                    }
                }
            }
        }


    }
}
