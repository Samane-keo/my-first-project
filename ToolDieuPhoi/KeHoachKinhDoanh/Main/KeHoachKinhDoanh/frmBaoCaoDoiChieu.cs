using AccessData;
using DevExpress.XtraEditors.Controls;
using KeHoachKinhDoanh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeHoachKinhDoanh
{
    public partial class frmBaoCaoDoiChieu : Form
    {
        cls_DieuPhoi cls = new cls_DieuPhoi();
        DataTable dt_t = new DataTable();
        DataTable dt_lsx = new DataTable();
        DataTable dt = new DataTable();
        clsExportFile export = new clsExportFile();
        public frmBaoCaoDoiChieu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoiChieu_Load(object sender, EventArgs e)
        {
            Load_Thang();
            Load_Nam();
        }
        private void Load_Thang()
        {
            cbthang.DisplayMember = "Text";
            cbthang.ValueMember = "Value";
            for(int i = 1; i <= 12; i++)
            {
                cbthang.Items.Add(new { Text = i, Value = i });
            }
            
        }
        private void Load_Nam()
        {
            cbnam.DisplayMember = "Text";
            cbnam.ValueMember = "Value";
            for (int i = 1; i <= 2020; i++)
            {
                cbnam.Items.Add(new { Text = i, Value = i });
            }

        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            string thang, nam, loaikh, tenkh, masp;
            string solsx, mamau, madep;
            int count_dt = 0;
            loaikh = "%";
            tenkh = "%";
            masp = "%";
            if(rbtheothang.Checked == true)
            {
                thang = cbthang.Text;
                nam = cbnam.Text;
                dt_t = cls.Load_DoiChieu_Export_Thang_TK_LSX(thang, nam, loaikh, tenkh, masp);
                count_dt = dt_t.Rows.Count;
                for(int i = 0; i < count_dt; i++)
                {
                    solsx = Convert.ToString(dt_t.Rows[0]["SOLSX"]);
                    mamau = Convert.ToString(dt_t.Rows[0]["MA_MAU"]);
                    madep = Convert.ToString(dt_t.Rows[0]["MA_DEP"]);
                    dt_lsx = cls.find_lsx(solsx, mamau, madep);
                    if(dt_lsx.Rows.Count == 0)
                    {
                        SqlParameter[] sqlpa = new SqlParameter[3];
                        sqlpa[0] = new SqlParameter("@SoLSX", solsx);
                        sqlpa[1] = new SqlParameter("@MaMau", mamau);
                        sqlpa[2] = new SqlParameter("@MaSP", madep);
                        if(cls.Insert_BCDC_NHAMAY(sqlpa) > 0)
                        {

                        }
                    }
                }
                dt = cls.Load_DoiChieu_Export_Thang(thang, nam, loaikh, tenkh, masp);
                export.exportDataToExcel_pro(dt);
                MessageBox.Show("Xuất dữ liệu thành công!");
            }
            
        }
    }
}
