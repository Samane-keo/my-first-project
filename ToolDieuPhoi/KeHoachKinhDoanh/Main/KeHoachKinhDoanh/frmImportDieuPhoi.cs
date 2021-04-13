using System;
using ExcelDataReader;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using KeHoachKinhDoanh.Class;

namespace KeHoachKinhDoanh
{
    public partial class frmImportDieuPhoi : Form
    {
        DataSet ds = new DataSet();
        cls_DieuPhoi cls = new cls_DieuPhoi();
        public frmImportDieuPhoi()
        {
            InitializeComponent();
        }

        private void clear_data()
        {
            dataGridView1.DataSource = null;
        }

        private void btn_import_Click_1(object sender, EventArgs e)
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

                            //cb_sheet.Items.Clear();
                            //foreach (DataTable dt in ds.Tables)
                            //{
                            //    cb_sheet.Items.Add(dt.TableName);
                            //}
                            dataGridView1.DataSource = ds.Tables[0];
                            reader.Close();

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thao tác đã bị lỗi: " + ex);
                    }
                   
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string solsx, makh, soddh, ngaygh, ngaytn, ngaydp, ngayvtdu, ngaylap = "", ngayduphong, ghichu;
            string masp, mamau, sodh, ngayps = "";
            int cosoid, msm, soluong = 0;
            bool moi = false; bool? CHTT = null; bool? TGPP=null;
            DateTime dngayps;
            DateTime dngaygh, dngaytn, dngaydp, dngayvtdu, dngaylap, dngayduphong;
            bool check = false;
            if(ds != null)
            {
                for(int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    if (ds.Tables[0].Columns[i].Caption == "Ma KH")
                    {
                        check = true;
                        break;
                    }
                }
            }
            if(ds != null)
            {
                if(check == true)
                {
                    for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        solsx = ds.Tables[0].Rows[i][0].ToString();

                        makh = ds.Tables[0].Rows[i][1].ToString();

                        soddh = ds.Tables[0].Rows[i][2].ToString();

                        if(ds.Tables[0].Rows[i][3].ToString() != "")
                        {
                            dngaygh = Convert.ToDateTime(ds.Tables[0].Rows[i][3]);
                            ngaygh = dngaygh.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            ngaygh = "";
                        }

                        if (ds.Tables[0].Rows[i][4].ToString() != "")
                        {
                            dngaytn = Convert.ToDateTime(ds.Tables[0].Rows[i][4]);
                            ngaytn = dngaytn.ToString("yyyy-MM-dd");
                        }else
                        {
                            ngaytn = "";
                        }
                        

                        if(ds.Tables[0].Rows[i][5].ToString() != "")
                        {
                            dngaydp = Convert.ToDateTime(ds.Tables[0].Rows[i][5]);
                            ngaydp = dngaydp.ToString("yyyy-MM-dd");
                        }else
                        {
                            ngaydp = "";
                        }

                        if (ds.Tables[0].Rows[i][6].ToString() != "")
                        {
                            dngayvtdu = Convert.ToDateTime(ds.Tables[0].Rows[i][6]);
                            ngayvtdu = dngayvtdu.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            ngayvtdu = "";
                        }

                        if (ds.Tables[0].Rows[i][7].ToString() != "")
                        {
                            dngaylap = Convert.ToDateTime(ds.Tables[0].Rows[i][7]);
                            ngaylap = dngaylap.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            ngaylap = "";
                        }
                        if (ds.Tables[0].Rows[i][8].ToString() != "")
                        {
                            dngayduphong = Convert.ToDateTime(ds.Tables[0].Rows[i][8]);
                            ngayduphong = dngayduphong.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            ngayduphong = "";
                        }
                        ghichu = ds.Tables[0].Rows[i][9].ToString().Replace("_x000d_","");
                        if (ds.Tables[0].Rows[i][10].ToString() != "")
                        {
                            CHTT = Convert.ToBoolean(ds.Tables[0].Rows[i][10].ToString());
                        }
                        else
                        {
                            CHTT = null;
                        }
                        if (ds.Tables[0].Rows[i][11].ToString() != "")
                        {
                            TGPP = Convert.ToBoolean(ds.Tables[0].Rows[i][11].ToString());
                        }
                        else
                        {
                            TGPP = null;
                        }
                        SqlParameter[] sqlpa = new SqlParameter[12];
                        sqlpa[0] = new SqlParameter("@SoLSX", solsx);
                        sqlpa[1] = new SqlParameter("@MaKH", makh);
                        sqlpa[2] = new SqlParameter("@SoDDH", soddh);
                        sqlpa[3] = new SqlParameter("@NgayGH", ngaygh);
                        sqlpa[4] = new SqlParameter("@NgayTN", ngaytn);
                        sqlpa[5] = new SqlParameter("@NgayDP", ngaydp);
                        sqlpa[6] = new SqlParameter("@NgayVTDU", ngayvtdu);
                        sqlpa[7] = new SqlParameter("@NgayLap", ngaylap);
                        sqlpa[8] = new SqlParameter("@NgayDuPhong", ngayduphong);
                        sqlpa[9] = new SqlParameter("@ghichu", ghichu);
                        sqlpa[10] = new SqlParameter("@CHTT", CHTT);
                        sqlpa[11] = new SqlParameter("@TGPP", TGPP);
                        if (cls.Insert_DP_LSX_H(sqlpa) > 0)
                        {

                        }

                    }
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }else
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        solsx = ds.Tables[0].Rows[i][0].ToString();
                        masp = ds.Tables[0].Rows[i][1].ToString();
                        mamau = ds.Tables[0].Rows[i][2].ToString();
                        msm = Convert.ToInt16(ds.Tables[0].Rows[i][3]);
                        cosoid = Convert.ToInt16(ds.Tables[0].Rows[i][4]);
                        soluong = Convert.ToInt32(ds.Tables[0].Rows[i][5]);
                        sodh = ds.Tables[0].Rows[i][6].ToString();
                        moi = Convert.ToBoolean(ds.Tables[0].Rows[i][7].ToString());

                        if(ds.Tables[0].Rows[i][8].ToString() != "")
                        {
                            dngayps = Convert.ToDateTime(ds.Tables[0].Rows[i][8]);
                            ngayps = dngayps.ToString("yyyy-MM-dd");
                        }else
                        {
                            ngayps = "";
                        }

                        SqlParameter[] sqlpa = new SqlParameter[9];
                        sqlpa[0] = new SqlParameter("@SoLSX", solsx);
                        sqlpa[1] = new SqlParameter("@MaSP", masp);
                        sqlpa[2] = new SqlParameter("@MaMau", mamau);
                        sqlpa[3] = new SqlParameter("@MSM", msm);
                        sqlpa[4] = new SqlParameter("@CoSoID", cosoid);
                        sqlpa[5] = new SqlParameter("@SoLuong", soluong);
                        sqlpa[6] = new SqlParameter("@SoDH", sodh);
                        sqlpa[7] = new SqlParameter("@Moi", moi);
                        sqlpa[8] = new SqlParameter("@NgayPhatSinh", ngayps);

                        if(cls.Insert_DP_LSX_L(sqlpa) > 0)
                        {

                        }
                    }
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để thêm vào!");
            }
        }
        //private void cb_sheet_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = ds.Tables[cb_sheet.SelectedIndex];
        //}
    }
}
