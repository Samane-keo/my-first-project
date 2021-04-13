using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccessData.Utils;
using DevExpress.XtraGrid.Views.Grid;
using KeHoachKinhDoanh.Class;

namespace KeHoachKinhDoanh
{
    public partial class frm_DM_SanPham_Barcode : Form
    {
        cls_DM_Barcode cls = new cls_DM_Barcode();
        DataTable dt_lsx = new DataTable();
        int MaPX = 0;
        string MaNV = "";
        public frm_DM_SanPham_Barcode()
        {
            InitializeComponent();
        }
        private bool check()
        {
            if (GeneralFunction.ValidateMandantoryField(cbotuan) == false)
                return false;
            if (GeneralFunction.ValidateMandantoryField(cbothang) == false)
                return false;
            //if (GeneralFunction.ValidateMandantoryField(cbothang) == false)
            //    return false;
            if (GeneralFunction.ValidateMandantoryField(cbonam) == false)
                return false;
            return true;
        }
        private void Load_DM_Barcode()
        {
            //if (check() == false)
            //    return;
            string tuanGH, MaSP, Barcode;
            if (cboChungloai.SelectedIndex == 0)
            {
                MaPX = 15;
                tuanGH = "%" + cbotuan.Text + cbothang.Text + cbonam.Text;
                MaSP = txtMaSP.Text.MyTrim() + "%";
                Barcode = txtBar.Text.MyTrim() + "%";
                dt_lsx = cls.Load_DM_Barcode(MaPX, tuanGH, MaSP, Barcode);
                grdDM.DataSource = dt_lsx;
            }
            if (cboChungloai.SelectedIndex == 1)
            {
                MaPX = 27;
                tuanGH = "%" + cbotuan.Text + cbothang.Text + cbonam.Text;
                MaSP = txtMaSP.Text.MyTrim() + "%";
                Barcode = txtBar.Text.MyTrim() + "%";
                dt_lsx = cls.Load_DM_Barcode(MaPX, tuanGH, MaSP, Barcode);
                grdDM.DataSource = dt_lsx;
            }
        }
        private void Load_DM_Bar()
        {
            string MaSP, Barcode;
            MaSP = txtMaSP.Text.MyTrim() + "%";
            Barcode = txtBar.Text.MyTrim() + "%";

            string Str = "";
            string Str_q = "";
            string SoLSX = txtMaSP.Text;
            string[] strS = SoLSX.Split(',');
            for (int i = 0; i < strS.Count(); i++)
            {
                if (i == 0)
                {
                    Str = Str + "'" + strS[i] + "'";
                }
                else
                {
                    Str = Str + ",'" + strS[i] + "'";
                }
            }
            Str_q = "IN (" + Str + ")";

            dt_lsx = cls.Load_DM_Bar(Str_q, Barcode);
            grdDM.DataSource = dt_lsx;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Load_DM_Bar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Load_DM_Bar();
        }

        private void txtBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Load_DM_Bar();
        }

        const string folder = @"D:\DM_Barcode";
        public static void createFolder()
        {
            //if folder does not exist yet, it will be created else this line will be ignored
            System.IO.Directory.CreateDirectory(folder);
        }
        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            GridView view = gridView1;

            createFolder();
            if (view != null)
            {
                string path = @"D:\DM_Barcode\DM_Barcode_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + ".xlsx";
                view.ExportToXlsx(path);
                System.Diagnostics.Process.Start("explorer.exe", path);
                view = null;
                view = null;
            }
        }

        private void txtBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Load_DM_Barcode();
        }
    }
}
