using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;
using System.Data.SqlClient;
using AccessData;

namespace Admin
{
    public partial class frmMenu : Form
    {
        DataTable dt = new DataTable();
        clsMenu menu = new clsMenu();
        clsProject proj = new clsProject();
        bool isNew = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            DisplayForm();
            Load_Menu();
            Load_Project();
        }
        #region "Display"
        private void DisplayForm()
        {
            btnsave.Enabled = false;
            btncancel.Enabled = false;
            btnnew.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;

            txttenmenu.ReadOnly = true;
            txttenform.ReadOnly = true;
            txtpos.ReadOnly = true;
            gcmenu.Enabled = true;
            gvmenu.OptionsBehavior.Editable = false;
        }

        private void EditForm()
        {
            btnsave.Enabled = true;
            btncancel.Enabled = true;
            btnnew.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;

            gcmenu.Enabled = false;
            txttenmenu.ReadOnly = false;
            txttenform.ReadOnly = false;
            txtpos.ReadOnly = false;
        }
        #endregion

        #region "Load Data"
        private void Load_Menu()
        {
            gcmenu.DataSource = menu.Load_Menu();
            gvmenu.BestFitColumns();
        }

        private void Load_Project()
        {
            cbochuongtrinh.Properties.DataSource = proj.Load_Project();
            cbochuongtrinh.Properties.ValueMember = "ProjectID";
            cbochuongtrinh.Properties.DisplayMember = "Description";
            cbochuongtrinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }
        #endregion

        private void btnnew_Click(object sender, EventArgs e)
        {
            isNew = true;
            EditForm();

            txttenmenu.Text = "";
            txttenform.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                // Insert data
                SqlParameter[] sqlpa = new SqlParameter[4];
                sqlpa[0] = new SqlParameter("@TenMenu", (txttenmenu.Text).ToUpper());
                sqlpa[1] = new SqlParameter("@TenForm", txttenform.Text);
                sqlpa[2] = new SqlParameter("@Project", cbochuongtrinh.EditValue);
                sqlpa[3] = new SqlParameter("@Pos", txtpos.Text);

                if (menu.Insert_Menu(sqlpa) > 0)
                {
                    MessageBox.Show("Đã thêm mới dữ liệu.!");
                }
                isNew = false;
            }
            else
            {
                // Update data
                SqlParameter[] sqlpa = new SqlParameter[5];
                sqlpa[0] = new SqlParameter("@MenuID", lblmenuid.Text);
                sqlpa[1] = new SqlParameter("@TenMenu", (txttenmenu.Text).ToUpper());
                sqlpa[2] = new SqlParameter("@TenForm", txttenform.Text);
                sqlpa[3] = new SqlParameter("@Project", cbochuongtrinh.EditValue);
                sqlpa[4] = new SqlParameter("@Pos", txtpos.Text);
                if (menu.Update_Menu(sqlpa) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            Load_MenuByProject();
            DisplayForm();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DisplayForm();
        }

        private void gvmenu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (isNew == false)
            {
                lblmenuid.Text = gvmenu.GetFocusedRowCellValue("MenuID").ToString();
                txttenmenu.Text = gvmenu.GetFocusedRowCellValue("TenMenu").ToString();
                txttenform.Text = gvmenu.GetFocusedRowCellValue("TenForm").ToString();                
                txtpos.Text = gvmenu.GetFocusedRowCellValue("Pos").ToString();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            EditForm();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@MenuID", gvmenu.GetFocusedRowCellValue("MenuID").ToString());
            if (MessageBox.Show(this, "Bạn có chắc muốn xóa ?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (menu.Delete_Menu(sqlpar) > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    Load_Menu();
                    DisplayForm();
                }
            }
        }

        private void cbochuongtrinh_EditValueChanged(object sender, EventArgs e)
        {
            Load_MenuByProject();
        }
        private void Load_MenuByProject()
        {
            gcmenu.DataSource = menu.Load_MenuByProjectID(Convert.ToInt32(cbochuongtrinh.EditValue));
            gvmenu.BestFitColumns();
        }
    }
}
