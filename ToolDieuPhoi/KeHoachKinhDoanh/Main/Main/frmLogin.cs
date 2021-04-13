using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;
using AccessData;
using System.Security.Cryptography;
using Main.Properties;
using System.Data.SqlClient;

namespace Main
{
    public partial class frmLogin : Form
    {
        clsMain main = new clsMain();
        int count = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtusername.Focus();

            txtusername.Text = Settings.Default.username;
            txtpassword.Text = Settings.Default.password;
            chbremember.Checked = Settings.Default.remember;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MD5 md5Hash = MD5.Create();
            string mahoa = clsMD5.GetMd5Hash(md5Hash, txtpassword.Text);

            dt = main.Check_Login(txtusername.Text, mahoa, true);
            if (dt.Rows.Count - 1 >= 0)
            {
                //UPDATE LOGIN DATE
                SqlParameter[] sqlpa = new SqlParameter[2];
                sqlpa[0] = new SqlParameter("@UserID", Convert.ToString(dt.Rows[0][0]));
                sqlpa[1] = new SqlParameter("@LoginDate", DateTime.Now);
                if (main.Update_LoginDate(sqlpa) > 0)
                {}
                //REMEMBER USER AND PASSWORD
                if (chbremember.Checked == true)
                {
                    Settings.Default.username = txtusername.Text;
                    Settings.Default.password = txtpassword.Text;
                }
                else
                {
                    Settings.Default.username = string.Empty;
                    Settings.Default.password = string.Empty;
                }
                Settings.Default.remember = chbremember.Checked;
                Settings.Default.Save();

                clsGlobalVariable.userid_ = Convert.ToString(dt.Rows[0][0]);
                clsGlobalVariable.username_ = Convert.ToString(dt.Rows[0][1]);
                clsGlobalVariable.password_ = Convert.ToString(dt.Rows[0][2]);
                clsGlobalVariable.fullname_ = Convert.ToString(dt.Rows[0][3]);
                clsGlobalVariable.department_ = Convert.ToString(dt.Rows[0][4]);
                clsGlobalVariable.date_ = DateTime.Now;

                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                txtpassword.Text = "";
                txtpassword.Focus();

                count = count + 1;
                if (count >= 3)
                {
                    btnlogin.Enabled = false;
                    MessageBox.Show("Vui lòng thử lại sau ít phút");
                }
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Nhấn Enter
            {
                btnlogin.Focus();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
