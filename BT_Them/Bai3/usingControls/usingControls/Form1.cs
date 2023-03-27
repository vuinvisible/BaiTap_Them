using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usingControls
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Tập tin ảnh|*.bmp; *.jpg; *.gif|File tuỳ ý (*.*)|*.*";
            if(Open.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    picIMG.Image = Image.FromFile(Open.FileName);
                }
                catch(Exception)
                {
                    MessageBox.Show(String.Format("Không thể nạp file ảnh [{0}]", Open.FileName));
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lbName.Text = txtName.Text;
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOther.Enabled = chkOther.Checked;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            lbInfo.Text = (chkIsMale.Checked ? "Anh " : "Chị ") + txtName.Text + ". Môn học yêu thích: ";
            if (chkOOP.Checked)
                lbInfo.Text += " " + chkOOP.Text + ", ";
            if (chkAnD.Checked)
                lbInfo.Text += " " + chkAnD.Text + ", ";
            if (chkNET.Checked)
                lbInfo.Text += " " + chkNET.Text + ", ";
            if (chkOther.Checked && txtOther.Text.Trim() != "")
                lbInfo.Text += " " + txtOther.Text + ", ";
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            tmrScroll.Enabled = !tmrScroll.Enabled;
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            lbInfo.Text = lbInfo.Text.Substring(1) + lbInfo.Text.Substring(0, 1);
        }
    }
}
