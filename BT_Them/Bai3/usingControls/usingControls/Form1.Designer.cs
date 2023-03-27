namespace usingControls
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb1Name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.chkIsMale = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkNET = new System.Windows.Forms.CheckBox();
            this.chkAnD = new System.Windows.Forms.CheckBox();
            this.chkOOP = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picIMG = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIMG)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1Name
            // 
            this.lb1Name.AutoSize = true;
            this.lb1Name.Location = new System.Drawing.Point(26, 20);
            this.lb1Name.Name = "lb1Name";
            this.lb1Name.Size = new System.Drawing.Size(42, 13);
            this.lb1Name.TabIndex = 0;
            this.lb1Name.Text = "Họ tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày sinh:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(29, 84);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(216, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // chkIsMale
            // 
            this.chkIsMale.AutoSize = true;
            this.chkIsMale.Location = new System.Drawing.Point(338, 39);
            this.chkIsMale.Name = "chkIsMale";
            this.chkIsMale.Size = new System.Drawing.Size(91, 17);
            this.chkIsMale.TabIndex = 4;
            this.chkIsMale.Text = "Giới tính Nam";
            this.chkIsMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOther);
            this.groupBox1.Controls.Add(this.chkOther);
            this.groupBox1.Controls.Add(this.chkNET);
            this.groupBox1.Controls.Add(this.chkAnD);
            this.groupBox1.Controls.Add(this.chkOOP);
            this.groupBox1.Location = new System.Drawing.Point(29, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học yêu thích:";
            // 
            // txtOther
            // 
            this.txtOther.Enabled = false;
            this.txtOther.Location = new System.Drawing.Point(27, 131);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(219, 20);
            this.txtOther.TabIndex = 4;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(6, 97);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(95, 17);
            this.chkOther.TabIndex = 3;
            this.chkOther.Text = "Môn học khác";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkNET
            // 
            this.chkNET.AutoSize = true;
            this.chkNET.Location = new System.Drawing.Point(6, 74);
            this.chkNET.Name = "chkNET";
            this.chkNET.Size = new System.Drawing.Size(170, 17);
            this.chkNET.TabIndex = 2;
            this.chkNET.Text = "Chuyên đề Visual Studio .NET";
            this.chkNET.UseVisualStyleBackColor = true;
            // 
            // chkAnD
            // 
            this.chkAnD.AutoSize = true;
            this.chkAnD.Location = new System.Drawing.Point(6, 51);
            this.chkAnD.Name = "chkAnD";
            this.chkAnD.Size = new System.Drawing.Size(166, 17);
            this.chkAnD.TabIndex = 1;
            this.chkAnD.Text = "Phân tích & Thiết kế hệ thống ";
            this.chkAnD.UseVisualStyleBackColor = true;
            // 
            // chkOOP
            // 
            this.chkOOP.AutoSize = true;
            this.chkOOP.Location = new System.Drawing.Point(6, 28);
            this.chkOOP.Name = "chkOOP";
            this.chkOOP.Size = new System.Drawing.Size(148, 17);
            this.chkOOP.TabIndex = 0;
            this.chkOOP.Text = "Lập trình hướng đối tượng";
            this.chkOOP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picIMG);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Location = new System.Drawing.Point(338, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 184);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh";
            // 
            // picIMG
            // 
            this.picIMG.Location = new System.Drawing.Point(6, 19);
            this.picIMG.Name = "picIMG";
            this.picIMG.Size = new System.Drawing.Size(188, 132);
            this.picIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIMG.TabIndex = 1;
            this.picIMG.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(6, 154);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên của bạn: ";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(338, 321);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(91, 39);
            this.btSelect.TabIndex = 7;
            this.btSelect.Text = "Chọn ảnh";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(447, 321);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(91, 39);
            this.btApply.TabIndex = 8;
            this.btApply.Text = "Cập nhật";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbInfo);
            this.groupBox3.Location = new System.Drawing.Point(29, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 97);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(6, 32);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(240, 39);
            this.lbInfo.TabIndex = 10;
            this.lbInfo.Text = "Chưa cập nhật";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // tmrScroll
            // 
            this.tmrScroll.Interval = 120;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkIsMale);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb1Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Hello Winforms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIMG)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1Name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.CheckBox chkIsMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkNET;
        private System.Windows.Forms.CheckBox chkAnD;
        private System.Windows.Forms.CheckBox chkOOP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picIMG;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Timer tmrScroll;
    }
}

