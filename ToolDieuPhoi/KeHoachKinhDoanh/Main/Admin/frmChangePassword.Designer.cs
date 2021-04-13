namespace Admin
{
    partial class frmChangePassword
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtmatkhaumoi);
            this.panelControl1.Controls.Add(this.txtmatkhaucu);
            this.panelControl1.Controls.Add(this.txthoten);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txttendangnhap);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(409, 131);
            this.panelControl1.TabIndex = 3;
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(101, 87);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '*';
            this.txtmatkhaumoi.Size = new System.Drawing.Size(154, 21);
            this.txtmatkhaumoi.TabIndex = 7;
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Location = new System.Drawing.Point(101, 60);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.PasswordChar = '*';
            this.txtmatkhaucu.Size = new System.Drawing.Size(154, 21);
            this.txtmatkhaucu.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Location = new System.Drawing.Point(101, 33);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(154, 21);
            this.txthoten.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Enabled = false;
            this.txttendangnhap.Location = new System.Drawing.Point(101, 6);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(154, 21);
            this.txttendangnhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(101, 137);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(80, 27);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "Chấp nhận";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 181);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnok);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnok;
    }
}