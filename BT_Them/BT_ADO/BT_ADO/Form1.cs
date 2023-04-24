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
            string sqlDSNV = "select * from DSNV";
            string sqlDMP = "select * from DMPHONG";
            da = new SqlDataAdapter(sqlDSNV, conn);
            da.Fill(ds, "DSNV");
            da = new SqlDataAdapter(sqlDMP, conn);
            da.Fill(ds, "DMPHONG");

            gridDSNV.DataSource = ds.Tables["DSNV"];

            cbbPhongBan.DataSource = ds.Tables["DMPHONG"];
            cbbPhongBan.DisplayMember = "TenPhong";
            cbbPhongBan.ValueMember = "MaPhong";
        }

        private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlDSNV = " select * from DSNV where MaPhong = N'"+ cbbPhongBan.SelectedValue.ToString()+"' ";
            da = new SqlDataAdapter(sqlDSNV, conn);
            da.Fill(ds, "DSNV1");
            gridDSNV.DataSource = ds.Tables["DSNV1"];
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into DSNV(MaNV, HoTen, NgaySinh, GioiTinh, MaPhong, HeSoLuong, MaChucVu) " +
                             "values (@manv, @ht, @ngs, @gt, @maphong, @hsl, @mcv)";

                //cmd.CommandText = "insert into DSNV(MaNV, HoTen, NgaySinh, GioiTinh, MaPhong, HeSoLuong, MaChucVu) " +
                //                  "values (@manv, @ht, @ngs, @gt, @maphong, @hsl, @mcv)";

                /*string sqlCheck = "select * from DSNV where MaNV = @manv";
                using (SqlConnection conn1 = new SqlConnection(conn))
                {
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn1))
                    {
                        cmdCheck.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());
                        conn1.Open();
                        SqlDataReader dr = cmdCheck.ExecuteReader();
                        if (dr.HasRows)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại!");
                            return;
                        }
                        conn1.Close();
                    }
                }*/

                // Kiểm tra định dạng ngày tháng
                DateTime ngaysinh;
                if (!DateTime.TryParseExact(tbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                {
                    MessageBox.Show("Định dạng ngày sinh không đúng (dd/MM/yyyy)!");
                    return;
                }

                using (SqlConnection conn1 = new SqlConnection(conn))
                {
                    using(SqlCommand cmd = new SqlCommand(sql, conn1))
                    {
                        cmd.Parameters.Add("@manv", SqlDbType.VarChar);
                        cmd.Parameters.Add("@ht", SqlDbType.NVarChar);
                        cmd.Parameters.Add("@ngs", SqlDbType.DateTime);
                        cmd.Parameters.Add("@gt", SqlDbType.Bit);
                        cmd.Parameters.Add("@maphong", SqlDbType.VarChar);
                        cmd.Parameters.Add("@hsl", SqlDbType.Float);
                        cmd.Parameters.Add("@mcv", SqlDbType.VarChar);

                        cmd.Parameters["@manv"].Value = tbMaNV.Text.Trim();
                        cmd.Parameters["@ht"].Value = tbHoTen.Text.Trim();
                        cmd.Parameters["@ngs"].Value = ngaysinh;
                        cmd.Parameters["@gt"].Value = tbGioiTinh.Text.Trim() == "1";
                        cmd.Parameters["@maphong"].Value = cbbPhongBan.SelectedValue.ToString();
                        cmd.Parameters["@hsl"].Value = Convert.ToDouble(tbHSL.Text.Trim());
                        cmd.Parameters["@mcv"].Value = tbChucVu.Text.Trim().ToUpper();

                        conn1.Open();
                        int rowAffected = cmd.ExecuteNonQuery();
                        conn1.Close();
                        if(rowAffected > 0)
                            MessageBox.Show("Thêm thành công!");
                        else
                            MessageBox.Show("Thêm thất bại!");
                    }
                }
                
            }
            catch (Exception)
            {
                string sqlCheck = "select * from DSNV where MaNV = @manv";
                using (SqlConnection conn1 = new SqlConnection(conn))
                {
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn1))
                    {
                        cmdCheck.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());
                        conn1.Open();
                        SqlDataReader dr = cmdCheck.ExecuteReader();
                        if (dr.HasRows)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại!");
                            return;
                        }
                        conn1.Close();
                    }
                }
      
                if (string.IsNullOrEmpty(tbMaNV.Text.Trim()) || string.IsNullOrEmpty(tbHoTen.Text.Trim()) ||
                    string.IsNullOrEmpty(tbNgaysinh.Text.Trim()) || string.IsNullOrEmpty(tbGioiTinh.Text.Trim()) ||
                    cbbPhongBan.SelectedIndex == -1 || string.IsNullOrEmpty(tbHSL.Text.Trim()) ||
                    string.IsNullOrEmpty(tbChucVu.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
