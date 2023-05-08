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
            string sqlDSNV = " select * from DSNV where MaPhong = N'"+ cbbPhongBan.SelectedValue.ToString()+"' ";
            da = new SqlDataAdapter(sqlDSNV, conn);
            da.Fill(ds, "DSNV1");
            gridDSNV.DataSource = ds.Tables["DSNV1"];
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn1 = new SqlConnection(conn))
                {
                    string sql = "insert into DSNV(MaNV, HoTen, NgaySinh, GioiTinh, MaPhong, HeSoLuong, MaChucVu) " +
                                 "values (@manv, @ht, @ngs, @gt, @maphong, @hsl, @mcv)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn1))
                    {
                        cmd.Parameters.Add("@manv", SqlDbType.VarChar);
                        cmd.Parameters.Add("@ht", SqlDbType.NVarChar);
                        cmd.Parameters.Add("@ngs", SqlDbType.DateTime);
                        cmd.Parameters.Add("@gt", SqlDbType.Bit);
                        cmd.Parameters.Add("@maphong", SqlDbType.VarChar);
                        cmd.Parameters.Add("@hsl", SqlDbType.Float);
                        cmd.Parameters.Add("@mcv", SqlDbType.VarChar);

                        if (checkMaNV(tbMaNV.Text.Trim()))
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại!");
                            return;
                        }

                        Boolean gt;
                        if (rdbNam.Checked == true)
                            gt = true;
                        else
                            gt = false;

                         cmd.Parameters["@manv"].Value = tbMaNV.Text.Trim();
                         cmd.Parameters["@ht"].Value = tbHoTen.Text.Trim();
                         cmd.Parameters["@ngs"].Value = dtpNgaySinh.Value;
                         cmd.Parameters["@gt"].Value = gt;
                         cmd.Parameters["@maphong"].Value = cbbPhongBan.SelectedValue.ToString();
                         cmd.Parameters["@hsl"].Value = Convert.ToDouble(tbHSL.Text.Trim());
                         cmd.Parameters["@mcv"].Value = tbChucVu.Text.Trim().ToUpper();

                         conn1.Open();
                         int result = cmd.ExecuteNonQuery();
                         conn1.Close();
                         if(result > 0)
                             MessageBox.Show("Thêm thành công!");
                         else
                             MessageBox.Show("Thêm thất bại!");

                         load_Grid();
                    }
                }
                
                       
        }
        public void load_Grid()
        {
            string sqlDSNV = "select * from DSNV";
            da = new SqlDataAdapter(sqlDSNV, conn);
            da.Fill(ds, "DSNV");
            gridDSNV.DataSource = ds.Tables["DSNV"];
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from DSNV where HoTen like N'%" + tbHoTen.Text + "'";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            gridDSNV.DataSource = dt;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn1 = new SqlConnection(conn))
            {
                string sqlUP = "update DSNV set HoTen = @ht, NgaySinh = @ngs, GioiTinh = @gt, MaPhong = @maphong, HeSoLuong = @hsl, MaChucVu = @mcv where MaNV = @manv";
                using (SqlCommand cmdUP = new SqlCommand(sqlUP, conn1))
                {
                    if (!checkMaNV(tbMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                        return;
                    }

                    Boolean gt;
                    if (rdbNam.Checked == true)
                        gt = true;
                    else
                        gt = false;
                       
                    cmdUP.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@ht", tbHoTen.Text.Trim());
                    cmdUP.Parameters.AddWithValue("@ngs", dtpNgaySinh.Value);
                    cmdUP.Parameters.AddWithValue("@gt", gt);
                    cmdUP.Parameters.AddWithValue("@maphong", cbbPhongBan.SelectedValue.ToString());
                    cmdUP.Parameters.AddWithValue("@hsl", Convert.ToDouble(tbHSL.Text.Trim()));
                    cmdUP.Parameters.AddWithValue("@mcv", tbChucVu.Text.Trim().ToUpper());

                    conn1.Open();
                    int result = cmdUP.ExecuteNonQuery();
                    conn1.Close();

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
            using(SqlConnection conn1 = new SqlConnection(conn))
            {
                string sqlDel = "delete from DSNV where MaNV = @manv";
                using(SqlCommand cmdDel = new SqlCommand(sqlDel, conn1))
                {

                    cmdDel.Parameters.AddWithValue("@manv", tbMaNV.Text.Trim());

                    if (!checkMaNV(tbMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                        return;
                    }
                        
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn1.Open();
                        int result1 = cmdDel.ExecuteNonQuery();
                        conn1.Close();
                        if (result1 > 0)
                            MessageBox.Show("Xóa thành công!");
                        else
                            MessageBox.Show("Xóa thất bại!");
                        load_Grid();
                    }
                   

                }
            }
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
    }
}
