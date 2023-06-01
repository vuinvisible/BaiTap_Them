namespace QLNV
{
    partial class FormDangNhap
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
            this.usCtlDangNhap1 = new QLNV.UsCtlDangNhap();
            this.SuspendLayout();
            // 
            // usCtlDangNhap1
            // 
            this.usCtlDangNhap1.Location = new System.Drawing.Point(43, 21);
            this.usCtlDangNhap1.Name = "usCtlDangNhap1";
            this.usCtlDangNhap1.Size = new System.Drawing.Size(379, 438);
            this.usCtlDangNhap1.TabIndex = 0;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 493);
            this.Controls.Add(this.usCtlDangNhap1);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private UsCtlDangNhap usCtlDangNhap1;
    }
}