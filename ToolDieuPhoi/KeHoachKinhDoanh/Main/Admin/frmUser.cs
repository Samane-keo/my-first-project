using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;
using System.Security.Cryptography;
using System.Data.SqlClient;
using AccessData;

namespace Admin
{
    public partial class frmUser : Form
    {
        clsUser user = new clsUser();
        clsDepartment dv = new clsDepartment();
        DataTable dt = new DataTable();
        bool isNew = false;

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            DisplayForm();
            Load_User();
            Load_Department();
        }
        #region "Display"
        private void DisplayForm()
        {
            btnsave.Enabled = false;
            btncancel.Enabled = false;
            btnnew.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;

            txtusername.ReadOnly = true;
            txtpassword.ReadOnly = true;
            txtfullname.ReadOnly = true;


            chbisactive.ReadOnly = true;
            gcuser.Enabled = true;
            gvuser.OptionsBehavior.Editable = false;
        }

        private void EditForm()
        {
            btnsave.Enabled = true;
            btncancel.Enabled = true;
            btnnew.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;

            txtusername.ReadOnly = false;
            txtpassword.ReadOnly = false;
            txtfullname.ReadOnly = false;
            chbisactive.ReadOnly = false;
            gcuser.Enabled = false;
        }
        #endregion

        #region "LoadData"
        private void Load_User()
        {
            gcuser.DataSource = user.Load_User();
            gvuser.BestFitColumns();
        }
        //
        private void Load_Department()
        {
            cbodepartment.Properties.DataSource = dv.Load_Department();
            cbodepartment.Properties.ValueMember = "madv";
            cbodepartment.Properties.DisplayMember = "tendv";
            cbodepartment.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }
        #endregion

        #region "Event"
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MD5 md5Hash = MD5.Create();
                string mahoa = clsMD5.GetMd5Hash(md5Hash, txtpassword.Text);
                // Insert data
                SqlParameter[] sqlpa = new SqlParameter[6];
                sqlpa[0] = new SqlParameter("@Username", txtusername.Text);
                sqlpa[1] = new SqlParameter("@Password", mahoa);
                sqlpa[2] = new SqlParameter("@Fullname", txtfullname.Text);
                sqlpa[3] = new SqlParameter("@Department", cbodepartment.EditValue);
                sqlpa[4] = new SqlParameter("@CreateDate", DateTime.Now);
                sqlpa[5] = new SqlParameter("@isActive", chbisactive.Checked);

                if (user.Insert_User(sqlpa) > 0)
                {
                    MessageBox.Show("Đã thêm mới dữ liệu.!");
                }
                isNew = false;
            }
            else
            {
                // Update data
                SqlParameter[] sqlpa = new SqlParameter[4];
                sqlpa[0] = new SqlParameter("@UserID", lbluserid.Text);
                sqlpa[1] = new SqlParameter("@Fullname", txtfullname.Text);
                sqlpa[2] = new SqlParameter("@Department", cbodepartment.EditValue);
                sqlpa[3] = new SqlParameter("@isActive", chbisactive.Checked);
                if (user.Update_User(sqlpa) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            Load_User();
            DisplayForm();
        }
        //
        private void btnnew_Click(object sender, EventArgs e)
        {
            isNew = true;
            EditForm();

            txtusername.Text = "";
            txtpassword.Text = "";
            txtfullname.Text = "";
            chbisactive.Checked = true;
        }
        //
        private void gvuser_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (isNew == false)
            {
                lbluserid.Text = gvuser.GetFocusedRowCellValue("UserID").ToString();
                txtusername.Text = gvuser.GetFocusedRowCellValue("Username").ToString();
                txtpassword.Text = gvuser.GetFocusedRowCellValue("Password").ToString();
                txtfullname.Text = gvuser.GetFocusedRowCellValue("Fullname").ToString();
                cbodepartment.EditValue = gvuser.GetFocusedRowCellValue("MaDV").ToString();
                chbisactive.Checked = Convert.ToBoolean(gvuser.GetFocusedRowCellValue("isActive").ToString());
            }
        }
        //
        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@UserID", lbluserid.Text);
            if (MessageBox.Show(this, "Bạn có chắc muốn xóa ?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (user.Delete_User(sqlpar) > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    frmUser_Load(sender, e);
                }
            }
        }
        //
        private void btncancel_Click(object sender, EventArgs e)
        {
            isNew = false;
            frmUser_Load(sender, e);
            DisplayForm();
        }
        //
        private void btnedit_Click(object sender, EventArgs e)
        {
            EditForm();
        }
        #endregion            
    }
}
