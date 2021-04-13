using ExcelDataReader;
using KeHoachKinhDoanh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeHoachKinhDoanh
{
    public partial class frmImportBarcode : Form
    {
        DataSet ds = new DataSet();
        cls_DM_Barcode cls = new cls_DM_Barcode();
        public frmImportBarcode()
        {
            InitializeComponent();
        }

        private void frmImportBarcode_Load(object sender, EventArgs e)
        {

        }
        private void clear_data()
        {
            dataGridView1.DataSource = null;
        }
        private void btn_import_Click(object sender, EventArgs e)
        {
            if (ds != null)
            {
                clear_data();
            }
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            IExcelDataReader reader;
                            if (ofd.FilterIndex == 2)
                            {
                                reader = ExcelReaderFactory.CreateBinaryReader(stream);
                            }
                            else
                            {
                                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                            }

                            ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            dataGridView1.DataSource = ds.Tables[0];
                            reader.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thao tác đã bị lỗi: " + ex);
                    }

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string masp, mau, coso, barcode, barcode2, ngaytao = "";
            DateTime dngaytao;
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    masp = ds.Tables[0].Rows[i][0].ToString();
                    mau = ds.Tables[0].Rows[i][1].ToString();
                    coso = ds.Tables[0].Rows[i][2].ToString();
                    barcode = ds.Tables[0].Rows[i][3].ToString();
                    barcode2 = ds.Tables[0].Rows[i][4].ToString();

                    dngaytao = Convert.ToDateTime(ds.Tables[0].Rows[i][5]);
                    ngaytao = dngaytao.ToString("yyyy-MM-dd");

                    if(cls.Insert_Barcode(masp,mau,coso,barcode,barcode2,ngaytao) > 0)
                    {

                    }
                }
                MessageBox.Show("Thêm dữ liệu barcode thành công!");
            }

        }
    }
}
