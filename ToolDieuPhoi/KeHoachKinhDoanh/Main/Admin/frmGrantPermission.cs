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
using System.Collections;

namespace Admin
{
    public partial class frmGrantPermission : Form
    {
        clsUser user = new clsUser();
        clsProject proj = new clsProject();
        clsMenu menu = new clsMenu();
        clsMenu_User mu = new clsMenu_User();
        DataTable dt = new DataTable();

        int projectid, userid;

        public frmGrantPermission()
        {
            InitializeComponent();
        }

        private void frmGrantPermission_Load(object sender, EventArgs e)
        {
            Load_User();
            Load_Project();
            gvproject.OptionsBehavior.Editable = false;
            gvuser.OptionsBehavior.Editable = false;
            gvmenu.OptionsBehavior.Editable = false;
        }

        #region "Load Data"
        private void Load_User()
        {
            gcuser.DataSource = user.Load_User_GrantPer();
            gvuser.BestFitColumns();
        }
        //
        private void Load_Project()
        {
            gcproject.DataSource = proj.Load_Project();
            gvproject.BestFitColumns();
        }
        #endregion 

        #region "Event"
        private void cboproject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////GET PROJECT ID
            //DataRow selectedDataRow = ((DataRowView)cboproject.SelectedItem).Row;
            //int projectid = Convert.ToInt32(selectedDataRow["ProjectID"]);
            ////Push menu to checklist
            //chbmenu.DataSource = menu.Load_MenuIntoCheckboxByProjectID(projectid);
            //chbmenu.ValueMember = "MenuID";
            //chbmenu.DisplayMember = "TenMenu";
           
            //var dt = menu.Load_CheckedMenu(projectid,Convert.ToInt32(cbouser.EditValue.ToString()));
            ////CLEAR CHECKLIST
            //while (chbmenu.CheckedIndices.Count > 0)
            //    chbmenu.SetItemChecked(chbmenu.CheckedIndices[0], false);
            ////CHECK MENU THEO NHOM USER
            //foreach (DataRow dr in dt.Rows)
            //{
            //    int index = chbmenu.FindString(dr[1].ToString());
            //    chbmenu.SetItemChecked(index, true);
            //}
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            //SqlParameter[] sqlpar = new SqlParameter[2];
            //sqlpar[0] = new SqlParameter("@UserID", cbouser.EditValue);
            //sqlpar[1] = new SqlParameter("@ProjectID", cboproject.SelectedValue);
            //if (mu.Delete_Menu_User(sqlpar) > 0)
            //{ }
            ////INSERT NEW DATA
            //foreach (object item in chbmenu.CheckedItems)
            //{
            //    DataRowView r = item as DataRowView;
            //    {
            //        SqlParameter[] sqlpa = new SqlParameter[3];
            //        sqlpa[0] = new SqlParameter("@UserID", cbouser.EditValue);
            //        sqlpa[1] = new SqlParameter("@ProjectID", cboproject.SelectedValue);
            //        sqlpa[2] = new SqlParameter("@MenuID", Convert.ToInt32(r["MenuID"]));
            //        if (mu.Insert_Menu_User(sqlpa) > 0)
            //        { }
            //    }
            //}
            //MessageBox.Show("Cập nhật thành công.!");
        }

        private void chbcheckall_CheckedChanged(object sender, EventArgs e)
        {
            //if (chbcheckall.Checked == true)
            //{
            //    for (int i = 0; i < chbmenu.Items.Count; i++)
            //        chbmenu.SetItemChecked(i, true);
            //}
            //else
            //{
            //    for (int i = 0; i < chbmenu.Items.Count; i++)
            //        chbmenu.SetItemChecked(i, false);
            //}
        }
        #endregion

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            projectid = Convert.ToInt32(gvproject.GetFocusedRowCellValue("ProjectID").ToString());
            userid = Convert.ToInt32(gvuser.GetFocusedRowCellValue("UserID").ToString());
            //CLEAR BEFORE INSERT
            SqlParameter[] sqlpar = new SqlParameter[2];
            sqlpar[0] = new SqlParameter("@UserID", userid);
            sqlpar[1] = new SqlParameter("@ProjectID", projectid);
            if (mu.Delete_Menu_User(sqlpar) > 0)
            { }
            ArrayList Rows = new ArrayList();
            int I;
            for (I = 0; I <= gvmenu.SelectedRowsCount - 1; I++)
            {
                if ((gvmenu.GetSelectedRows()[I] >= 0))
                {
                    Rows.Add(gvmenu.GetDataRow(gvmenu.GetSelectedRows()[I]));
                }
            }
            for (I = 0; I <= Rows.Count - 1; I++)
            {
                DataRow Row = (DataRow)Rows[I];
                SqlParameter[] sqlpa = new SqlParameter[3];
                sqlpa[0] = new SqlParameter("@UserID", userid);
                sqlpa[1] = new SqlParameter("@ProjectID", projectid);
                sqlpa[2] = new SqlParameter("@MenuID", Row["MenuID"]);
                if (mu.Insert_Menu_User(sqlpa) > 0)
                { }
            }
            MessageBox.Show("Cập nhật thành công.!");
        }

        private void gvproject_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            projectid = Convert.ToInt32(gvproject.GetFocusedRowCellValue("ProjectID").ToString());
            userid = Convert.ToInt32(gvuser.GetFocusedRowCellValue("UserID").ToString());

            gcmenu.DataSource = menu.Load_MenuByProjectID(projectid);
            gvmenu.BestFitColumns();

            var dt = menu.Load_CheckedMenu(projectid, userid);
            int menuid, rowHandle;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                menuid = Convert.ToInt32(dt.Rows[i][0]);
                rowHandle = gvmenu.LocateByValue("MenuID", menuid);
                gvmenu.SelectRow(rowHandle);
            }
        }
    }
}
