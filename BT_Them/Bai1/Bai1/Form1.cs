using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add(txtHoLot.Text + " " + txtTen.Text + " SN: " + txtNgSinh.Text);
            txtHoLot.Text = "";
            txtTen.Text = "";
            txtNgSinh.Text = "";
        }

        private void btThangNay_Click(object sender, EventArgs e)
        {
            DateTime day;
            lstDsSinhNhat.Items.Clear();
            foreach(String st in lstDanhSach.Items)
            {
                int vt = st.Trim().LastIndexOf(":");
                day = DateTime.Parse(st.Substring(vt+1));
                if(day.Month == DateTime.Now.Month)
                    lstDsSinhNhat.Items.Add(st);    
            }
        }

        private void btThangToi_Click(object sender, EventArgs e)
        {
            DateTime day;
            lstDsSinhNhat.Items.Clear();
            foreach (String st in lstDanhSach.Items)
            {
                int vt = st.Trim().LastIndexOf(':');
                day = DateTime.Parse(st.Substring(vt+1));
                if((day.Month-1) == DateTime.Now.Month)
                    lstDsSinhNhat.Items.Add((st));
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
