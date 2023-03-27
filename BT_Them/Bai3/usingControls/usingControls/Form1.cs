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
        String tmp;
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
            String tt;
            tt = (chkIsMale.Checked ? "Anh " : "Chị ") + txtName.Text + ". Môn học yêu thích: ";
            if (chkOOP.Checked)
                tt +=  " "+ chkOOP.Text + ", ";
            if (chkAnD.Checked)
                tt += " " + chkAnD.Text + ", ";
            if (chkNET.Checked)
                tt += " " + chkNET.Text + ", ";
            if (chkOther.Checked && txtOther.Text.Trim() != "")
                tt += " " + txtOther.Text + ", ";
            listBox1.Items.Add(tt);
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            tmrScroll.Enabled = !tmrScroll.Enabled;
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            lbInfo.Text = lbInfo.Text.Substring(1) + lbInfo.Text.Substring(0, 1);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            lbInfo.Text = tmp;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp = listBox1.SelectedItem.ToString();
        }
    }
}
