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
    }
}
