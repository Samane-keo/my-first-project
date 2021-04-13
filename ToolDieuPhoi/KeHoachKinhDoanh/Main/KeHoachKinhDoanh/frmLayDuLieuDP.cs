using AccessData;
using DevExpress.XtraGrid.Views.Grid;
using KeHoachKinhDoanh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeHoachKinhDoanh
{
    public partial class frmLayDuLieuDP : Form
    {
        cls_DieuPhoi cls = new cls_DieuPhoi();
        clsExportFile export = new clsExportFile();
        DataTable dt_grid_h = new DataTable();
        DataTable dt_grid_L = new DataTable();
        public frmLayDuLieuDP()
        {
            InitializeComponent();
        }
        const string folder = @"D:\DIEUPHOI";
        public static void createFolder()
        {
            //if folder does not exist yet, it will be created else this line will be ignored
            System.IO.Directory.CreateDirectory(folder);
        }
        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            DataTable dt_ex = new DataTable();
            if (rbtheothang.Checked == true)
            {

            }
            else if (rbtheongay.Checked == true)
            {
                GridView view = gridView_H;
                GridView view1 = gridView_L;
                createFolder();
                if (view != null && view1 != null)
                {
                    string path = @"D:\DIEUPHOI\DIEUPHOI_H_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + ".xlsx";
                    view.ExportToXlsx(path);
                    System.Diagnostics.Process.Start("explorer.exe", path);
                    view = null;
                    view = null;
                    string path1 = @"D:\DIEUPHOI\DIEUPHOI_L_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + ".xlsx";
                    view1.ExportToXlsx(path1);
                    System.Diagnostics.Process.Start("explorer.exe", path1);
                    view1 = null;
                    view1 = null;
                }
            }
            else if (rbtheolsx.Checked == true)
            {
                GridView view = gridView_H;
                GridView view1 = gridView_L;
                createFolder();
                if (view != null && view1 != null)
                {
                    string path = @"D:\DIEUPHOI\DIEUPHOI_H_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + ".xlsx";
                    view.ExportToXlsx(path);
                    System.Diagnostics.Process.Start("explorer.exe", path);
                    view = null;
                    view = null;
                    string path1 = @"D:\DIEUPHOI\DIEUPHOI_L_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + ".xlsx";
                    view1.ExportToXlsx(path1);
                    System.Diagnostics.Process.Start("explorer.exe", path1);
                    view1 = null;
                    view1 = null;
                }
            }
            MessageBox.Show("Đổ dữ liệu thành công!");
        }
        private void Load_Thang()
        {
            cbthang.DisplayMember = "Text";
            cbthang.ValueMember = "Value";
            for (int i = 1; i <= 12; i++)
            {
                cbthang.Items.Add(new { Text = i, Value = i });
            }

        }
        private void Load_Nam()
        {
            cbnam.DisplayMember = "Text";
            cbnam.ValueMember = "Value";
            for (int i = 2020; i <= 2030; i++)
            {
                cbnam.Items.Add(new { Text = i, Value = i });
            }

        }
        private void frmLayDuLieuDP_Load(object sender, EventArgs e)
        {
            Load_Thang();
            Load_Nam();
        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rbtheongay.Checked == true)
            {
                DateTime datetn = Convert.ToDateTime(dateTuNgay.Text);
                string tungay = datetn.ToString("yyyy-MM-dd");
                DateTime datedn = Convert.ToDateTime(dateDenNgay.Text);
                string denngay = datedn.ToString("yyyy-MM-dd");
                dt_grid_h = cls.get_lsx_H(tungay, denngay);
                gridLSX_H.DataSource = dt_grid_h;

                dt_grid_L = cls.get_lsx_L(tungay,denngay);
                gridLSX_L.DataSource = dt_grid_L;

            }
            if (rbtheolsx.Checked == true)
            {
                
                string Str = "";
                string Str_q = "";
                string SoLSX = txtLSX.Text;
                string[] strS = SoLSX.Split(',');
                for(int i = 0;i< strS.Count(); i++)
                {               
                    if(i == 0)
                    {
                        Str = Str + "'" + strS[i] + "'";
                    }else
                    {
                        Str = Str + ",'" + strS[i] + "'";
                    }
                }
                Str_q = "IN (" + Str + ")";
                dt_grid_h = cls.get_lsx_H_LSX(Str_q);
                gridLSX_H.DataSource = dt_grid_h;
                dt_grid_L = cls.get_lsx_L_LSX(Str_q);
                gridLSX_L.DataSource = dt_grid_L;
            }
            
        }
    }
}
