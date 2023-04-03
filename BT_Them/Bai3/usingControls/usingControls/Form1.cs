using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usingControls
{
    public partial class FormMain : Form
    {
        String tmp, fileName;
        int tmp1;
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
            tmp = listBox1.SelectedItem.ToString();
            lbInfo.Text = tmp;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmp1 = listBox1.SelectedIndex;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(tmp1);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text File|*.txt";
            op.Title = "Chọn file";
            fileName = op.FileName;
            if(op.ShowDialog() == DialogResult.Yes)
            {
                try
                {
                  
                }
                catch(Exception)
                {
                    MessageBox.Show("Không tải được file!");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text File|*.txt";
            StreamWriter writer = new StreamWriter(fileName);
            if(sv.ShowDialog() == DialogResult.Yes)
            {
                foreach(string st in listBox1.Items)
                {
                    writer.WriteLine(st);
                }
                writer.Close();
            }
        }

    }
}
