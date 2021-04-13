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
    public partial class frmDieuPhoi : Form
    {
        cls_DieuPhoi cls = new cls_DieuPhoi();
        DataTable dt_kh = new DataTable();
        DataTable dt_sp = new DataTable();
        DataTable dt_head, dt_line = new DataTable();
        public frmDieuPhoi()
        {
            InitializeComponent();
        }

        private void frmDieuPhoi_Load(object sender, EventArgs e)
        {

        }
        private void Load_Khachhang(string makh)
        {
            dt_kh = cls.Load_Khachhang(makh);
            cbokhachhang.DataSource = dt_kh;
            cbokhachhang.ValueMember = "MaKH";
            cbokhachhang.DisplayMember = "TenKH";
        }
        private void Load_Sanpham(string masp)
        {
            dt_sp = cls.Load_SanPham(masp);
            cbomasp.DataSource = dt_sp;
            cbomasp.ValueMember = "MaSP";
            cbomasp.DisplayMember = "MaSP";
        }
        private void Load_Head_LSX(string solsx)
        {
            try
            {
                dt_head = cls.Load_Header_LSX(solsx);
                DateTime ngaygh, ngaydp, ngaykiem, ngaytn, ngayph, ngayvtdu, ngayncvt, ngaybbtn, ngaytnmd, ngayphmd, ngayduphong;
                if (dt_head.Rows[0]["MaKH"].ToString() != "")
                {
                    Load_Khachhang(dt_head.Rows[0]["MaKH"].ToString());
                }
                if (dt_head.Rows[0]["MaSP"].ToString() != "")
                {
                    Load_Sanpham(dt_head.Rows[0]["MaSP"].ToString());
                }


                if (dt_head.Rows[0]["NgayGH"].ToString() != "")
                {
                    ngaygh = Convert.ToDateTime(dt_head.Rows[0]["NgayGH"]);
                    if (ngaygh.Year != 1900)
                    {
                        txtngaygh.Text = ngaygh.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaygh.Text = "";
                    }

                }
                else
                {
                    txtngaygh.Text = "";
                }

                if (dt_head.Rows[0]["NgayDP"].ToString() != "")
                {
                    ngaydp = Convert.ToDateTime(dt_head.Rows[0]["NgayDP"]);
                    if (ngaydp.Year != 1900)
                    {
                        txtngaydp.Text = ngaydp.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaydp.Text = "";
                    }

                }
                else
                {
                    txtngaydp.Text = "";
                }
                if (dt_head.Rows[0]["NgayKIEM"].ToString() != "")
                {
                    ngaykiem = Convert.ToDateTime(dt_head.Rows[0]["NgayKIEM"]);
                    if (ngaykiem.Year != 1900)
                    {
                        txtngaykiem.Text = ngaykiem.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaykiem.Text = "";
                    }

                }
                else
                {
                    txtngaykiem.Text = "";
                }

                if (dt_head.Rows[0]["NgayTN"].ToString() != "")
                {
                    ngaytn = Convert.ToDateTime(dt_head.Rows[0]["NgayTN"]);
                    if (ngaytn.Year != 1900)
                    {
                        txtngaytn.Text = ngaytn.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaytn.Text = "";
                    }

                }
                else
                {
                    txtngaytn.Text = "";
                }

                if (dt_head.Rows[0]["NgayPH"].ToString() != "")
                {
                    ngayph = Convert.ToDateTime(dt_head.Rows[0]["NgayPH"]);
                    if (ngayph.Year != 1900)
                    {
                        txtngayph.Text = ngayph.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngayph.Text = "";
                    }

                }
                else
                {
                    txtngayph.Text = "";
                }

                if (dt_head.Rows[0]["NgayVTDU"].ToString() != "")
                {
                    ngayvtdu = Convert.ToDateTime(dt_head.Rows[0]["NgayVTDU"]);
                    if (ngayvtdu.Year != 1900)
                    {
                        txtngayvtdu.Text = ngayvtdu.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngayvtdu.Text = "";
                    }

                }
                else
                {
                    txtngayvtdu.Text = "";
                }

                if (dt_head.Rows[0]["NgayNCVT"].ToString() != "")
                {
                    ngayncvt = Convert.ToDateTime(dt_head.Rows[0]["NgayNCVT"]);
                    if (ngayncvt.Year != 1900)
                    {
                        txtngayncvt.Text = ngayncvt.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngayncvt.Text = "";
                    }

                }
                else
                {
                    txtngayncvt.Text = "";
                }

                if (dt_head.Rows[0]["NgayBBTN"].ToString() != "")
                {
                    ngaybbtn = Convert.ToDateTime(dt_head.Rows[0]["NgayBBTN"]);
                    if (ngaybbtn.Year != 1900)
                    {
                        txtngaybbtn.Text = ngaybbtn.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaybbtn.Text = "";
                    }

                }
                else
                {
                    txtngaybbtn.Text = "";
                }

                if (dt_head.Rows[0]["NgayTNMD"].ToString() != "")
                {
                    ngaytnmd = Convert.ToDateTime(dt_head.Rows[0]["NgayTNMD"]);
                    if (ngaytnmd.Year != 1900)
                    {
                        txtngaytnmd.Text = ngaytnmd.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaytnmd.Text = "";
                    }

                }
                else
                {
                    txtngaytnmd.Text = "";
                }

                if (dt_head.Rows[0]["NgayPHMD"].ToString() != "")
                {
                    ngayphmd = Convert.ToDateTime(dt_head.Rows[0]["NgayPHMD"]);
                    if (ngayphmd.Year != 1900)
                    {
                        txtngayphmd.Text = ngayphmd.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngayphmd.Text = "";
                    }

                }
                else
                {
                    txtngayphmd.Text = "";
                }

                if (dt_head.Rows[0]["NgayDuPhong"].ToString() != "")
                {
                    ngayduphong = Convert.ToDateTime(dt_head.Rows[0]["NgayDuPhong"]);
                    if (ngayduphong.Year != 1900)
                    {
                        txtngaydphong.Text = ngayduphong.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        txtngaydphong.Text = "";
                    }

                }
                else
                {
                    txtngaydphong.Text = "";
                }

                cbokhachhang.SelectedValue = dt_head.Rows[0]["MaKH"].ToString();
                txtsoddh.Text = dt_head.Rows[0]["SoDDH"].ToString();
                cbomasp.SelectedValue = dt_head.Rows[0]["MaSP"].ToString();
                if (dt_head.Rows[0]["PhanBo"].ToString() == "True")
                {
                    cbphanbo.Checked = true;
                }
                else
                {
                    cbphanbo.Checked = false;
                }
                if (dt_head.Rows[0]["ChoSX"].ToString() == "True")
                {
                    cbsxdaitra.Checked = true;
                }
                else
                {
                    cbsxdaitra.Checked = false;
                }
                memoGhichu.Text = dt_head.Rows[0]["GhiChu"].ToString();
                if (dt_head.Rows[0]["CHTT"].ToString() == "True")
                {
                    cbchtt.Checked = true;
                }
                else
                {
                    cbchtt.Checked = false;
                }
                if (dt_head.Rows[0]["TGPP"].ToString() == "True")
                {
                    cbtgpp.Checked = true;
                }
                else
                {
                    cbtgpp.Checked = false;
                }
                Load_Line_LSX(solsx);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
            
        }
        private void Clear_table()
        {
            int count_row = 0;
            count_row = gvLenhsanxuat.DataRowCount;
            for (int i = 1; i <= count_row; i++)
            {
                gvLenhsanxuat.DeleteRow(gvLenhsanxuat.FocusedRowHandle);
            }
            gcLenhsanxuat.DataSource = null;
            gvLenhsanxuat.Columns.Clear();


        }
        private void Load_Line_LSX(string solsx)
        {
            try
            {
                dt_line.Columns.Clear();
                Clear_table();
                DataTable dt_column = new DataTable();
                dt_column = cls.Load_Line_LSX(solsx);
                int count_col, count_dt, Sum_sl, sum_r = 0;
                count_col = (cls.Load_Line_LSX(solsx).Columns.Count) - 3;
                count_dt = cls.Load_Line_LSX(solsx).Rows.Count;
                dt_line.Columns.Add("MASP", typeof(string));
                dt_line.Columns.Add("MAU", typeof(string));
                dt_line.Columns.Add("MSM", typeof(string));
                for (int i = 0; i < count_col; i++)
                {
                    dt_line.Columns.Add(dt_column.Columns[i + 3].ColumnName.ToString(), typeof(string));
                }
                dt_line.Columns.Add("Tong", typeof(int));

                for (int j = 0; j < count_dt; j++)
                {
                    dt_line.Rows.Add();
                    Sum_sl = 0;
                    dt_line.Rows[j]["MASP"] = dt_column.Rows[j]["MASP"].ToString();
                    dt_line.Rows[j]["MAU"] = dt_column.Rows[j]["MAU"].ToString();
                    dt_line.Rows[j]["MSM"] = dt_column.Rows[j]["MSM"].ToString();
                    for (int k = 0; k < count_col; k++)
                    {
                        if(dt_column.Rows[j][dt_column.Columns[k + 3].ColumnName.ToString()].ToString() != "")
                        {
                            dt_line.Rows[j][dt_column.Columns[k + 3].ColumnName.ToString()] = dt_column.Rows[j][dt_column.Columns[k + 3].ColumnName.ToString()];
                            Sum_sl += Convert.ToInt32(dt_column.Rows[j][dt_column.Columns[k + 3].ColumnName.ToString()]);
                        }
                        else
                        {
                            dt_line.Rows[j][dt_column.Columns[k + 3].ColumnName.ToString()] = "-";
                        }  
                    }
                    dt_line.Rows[j]["Tong"] = Sum_sl;
                    sum_r += Sum_sl;
                }
                dt_line.Rows.Add();
                Set_Table();
                dt_line.Rows[count_dt]["Tong"] = sum_r;
                gcLenhsanxuat.DataSource = dt_line;
                Set_column(count_col);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
           
        }
        private void Set_column(int count_cl)
        {
            
            gvLenhsanxuat.Columns[0].Width = 80;
            gvLenhsanxuat.Columns[1].Width = 50;
            gvLenhsanxuat.Columns[2].Width = 50;
            for(int i = 0; i < count_cl; i++)
            {
                gvLenhsanxuat.Columns[i + 3].Width = 50;
            }
            
        }
        private void Set_Table()
        {
            gvLenhsanxuat.OptionsBehavior.Editable = false;
            gvLenhsanxuat.Appearance.HeaderPanel.Font = new Font(gvLenhsanxuat.Appearance.HeaderPanel.Font, FontStyle.Bold);
            dt_line.Columns["Tong"].Caption = "Tổng";
            dt_line.Columns["MASP"].Caption = "Mã SP";
            dt_line.Columns["MAU"].Caption = "Màu";
        }
        private void Clear_item()
        {
            cbokhachhang.SelectedValue = "";
            txtsolsx.Text = "";
            txtsoddh.Text = "";
            cbomasp.SelectedValue = "";
            txtngaydp.Text = "";
            txtngaygh.Text = "";
            txtngaykiem.Text = "";
            txtngaytn.Text = "";
            txtngayph.Text = "";
            txtngayvtdu.Text = "";
            txtngayncvt.Text = "";
            txtngaybbtn.Text = "";
            txtngaytnmd.Text = "";
            txtngayphmd.Text = "";
            txtngaydphong.Text = "";
            cbphanbo.Checked = false;
            cbsxdaitra.Checked = false;
            cbchtt.Checked = false;
            cbtgpp.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoiChieu frm = new frmBaoCaoDoiChieu();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_DM_SanPham_Barcode frm = new frm_DM_SanPham_Barcode();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmLayDuLieuDP frm = new frmLayDuLieuDP();
            frm.Show();
        }

        private void txtsolsx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Load_Head_LSX(txtsolsx.Text);
            }
        }
    }
}
