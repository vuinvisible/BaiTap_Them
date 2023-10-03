using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV;

namespace QLNV
{
    public partial class UsCtlDangNhap : UserControl
    {
        public UsCtlDangNhap()
        {
            InitializeComponent();
        }

        //string connStr = "Server = ANHVU\\SQLEXPRESS; Database = QLNV; Trusted_Connection = true";
        string connStr = "Data Source = ANHVU; Initial Catalog = QLNV; Integrated Security = True";

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sqlDN = "select * from USERS where TenDangNhap = @tdn and MatKhau = @mk";
                using (SqlCommand cmdDN = new SqlCommand(sqlDN, conn))
                {
                    cmdDN.Parameters.AddWithValue("@tdn", tbxTenDangNhap.Text.Trim());
                    cmdDN.Parameters.AddWithValue("@mk", tbxMatKhau.Text.Trim());

                    conn.Open();
                    SqlDataReader reader = cmdDN.ExecuteReader();

                    if (!reader.HasRows)
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                    else
                    {
                        // Tìm form cha và đóng form hiện tại
                        Form parentForm = this.FindForm();
                        parentForm.Hide();

                        // Hiển thị FormQL
                        FormQLNV f = new FormQLNV();
                        f.Show();
                    }
                }
            }
        }

    }
}
