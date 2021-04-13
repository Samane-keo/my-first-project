using AccessData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Class;

namespace Admin
{
    public partial class frmChangePassword : Form
    {
        clsUser user = new clsUser();

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txthoten.Text = clsGlobalVariable.fullname_;
            txttendangnhap.Text = clsGlobalVariable.username_;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            MD5 md5Hash = MD5.Create();

            string older = clsGlobalVariable.password_;
            string mahoa = clsMD5.GetMd5Hash(md5Hash, txtmatkhaucu.Text);
            string newpass = clsMD5.GetMd5Hash(md5Hash, txtmatkhaumoi.Text);
            if (mahoa == older)
            {
                SqlParameter[] sqlpa = new SqlParameter[2];
                sqlpa[0] = new SqlParameter("@UserID", clsGlobalVariable.userid_);
                sqlpa[1] = new SqlParameter("@Password", newpass);

                if (user.User_ChangePassword(sqlpa) > 0)
                {
                    MessageBox.Show("Mật khẩu đã được thay đổi");
                    txtmatkhaucu.Text = "";
                    txtmatkhaumoi.Text = "";
                }
            }
            else
                MessageBox.Show("Mật khẩu cũ không chính xác");
        }
    }
}
