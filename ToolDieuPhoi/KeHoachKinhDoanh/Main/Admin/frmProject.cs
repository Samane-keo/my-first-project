using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Class;

namespace Admin
{
    public partial class frmProject : Form
    {
        clsProject pro = new clsProject();

        public frmProject()
        {
            InitializeComponent();
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            Load_Project();
        }
        private void Load_Project()
        {
            gcproject.DataSource = pro.Load_Project();
            gvproject.BestFitColumns();
        }

        private void gvproject_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool isvalid = true;
            //Kiểm tra tên chủng loại ko đc rỗng
            if (gvproject.GetRowCellValue(e.RowHandle, "ProjectName").ToString() == "" || gvproject.GetRowCellValue(e.RowHandle, "Description").ToString() == "")
            {
                isvalid = false;
                MessageBox.Show("Vui lòng không để trống dữ liệu");
            }
            //Kiểm tra cập nhật trên lưới
            if (isvalid)
            {
                if (e.RowHandle < 0)
                {
                    SqlParameter[] sqlpa = new SqlParameter[2];
                    sqlpa[0] = new SqlParameter("@ProjectName", gvproject.GetRowCellValue(gvproject.FocusedRowHandle, gvproject.Columns[1]).ToString());
                    sqlpa[1] = new SqlParameter("@Description", gvproject.GetRowCellValue(gvproject.FocusedRowHandle, gvproject.Columns[2]).ToString());
                    
                    if (pro.Insert_Project(sqlpa) > 0)
                    {
                        MessageBox.Show("Thêm thành công.!");
                    }
                }
                else
                {
                    SqlParameter[] sqlpa = new SqlParameter[3];
                    sqlpa[0] = new SqlParameter("@ProjectID", gvproject.GetRowCellValue(gvproject.FocusedRowHandle, gvproject.Columns[0]).ToString());
                    sqlpa[1] = new SqlParameter("@ProjectName", gvproject.GetRowCellValue(gvproject.FocusedRowHandle, gvproject.Columns[1]).ToString());
                    sqlpa[2] = new SqlParameter("@Description", gvproject.GetRowCellValue(gvproject.FocusedRowHandle, gvproject.Columns[2]).ToString());
                    
                    if (pro.Update_Project(sqlpa) > 0)
                    {
                        MessageBox.Show("Update thành công.!");
                    }
                }
                Load_Project();
            }
            else
            {
                e.Valid = false;
                MessageBox.Show("Không có thay đổi, hoàn tác dữ liệu");
                Load_Project();
            }
        }
    }
}
