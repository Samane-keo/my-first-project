using QuanLyNopHoSo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNopHoSo
{
    public partial class frmHoSo : Form
    {
        cls_HoSo cls = new cls_HoSo();
        DataTable dt = new DataTable();
        public frmHoSo()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sohs, hoten, ngaysinh, diachi, dienthoai, ngaynophs, baovenhap, ghichu = "";
            DateTime dngaynophs;
            sohs = txtsohs.Text;
            hoten = txthovaten.Text;
            ngaysinh = txtngaysinh.Text;
            diachi = txtdiachi.Text;
            dienthoai = txtdienthoai.Text;
            baovenhap = txtbaovenhap.Text;
            ghichu = txtghichu.Text;
            dngaynophs = Convert.ToDateTime(dateNgaynophs.Text);
            ngaynophs = dngaynophs.ToString("yyyy-MM-dd");

            dt = cls.get_top_hoso();
            string hstop = "";
            if (dt.Rows.Count > 0)
            {
                 hstop = dt.Rows[0][0].ToString();
            }else
            {
                hstop = "";
            }
            string right_hs,str_hs = "";
            int num,num_add = 0;
            if(hstop == "")
            {
                str_hs = "HS0000001";
            }
            else
            {
                right_hs = hstop.Substring(2, 7);
                num = Convert.ToInt32(right_hs);
                num_add = num + 1;
                if(Convert.ToString(num_add).Length < 2)
                {
                    str_hs = "HS000000" + Convert.ToString(num_add);
                }else if (Convert.ToString(num_add).Length < 3)
                {
                    str_hs = "HS00000" + Convert.ToString(num_add);
                }
                else if (Convert.ToString(num_add).Length < 4)
                {
                    str_hs = "HS0000" + Convert.ToString(num_add);
                }
                else if (Convert.ToString(num_add).Length < 5)
                {
                    str_hs = "HS000" + Convert.ToString(num_add);
                }
                else if (Convert.ToString(num_add).Length < 6)
                {
                    str_hs = "HS00" + Convert.ToString(num_add);
                }
                else if (Convert.ToString(num_add).Length < 7)
                {
                    str_hs = "HS0" + Convert.ToString(num_add);
                }
                else
                {
                    str_hs = "HS" + Convert.ToString(num_add);
                }

            }

            if(cls.Insert_HoSo(str_hs, hoten,ngaysinh,diachi,ngaynophs,dienthoai,baovenhap,ghichu) > 0)
            {
                //txtsohs.Text = str_hs;
                MessageBox.Show("Thêm dữ liệu thành công! Số hồ sơ là: " + str_hs);
                lammoi();
            }
        }
        public void load_ngay()
        {
            DateTime dtt = DateTime.Now;
            dateNgaynophs.Text = dtt.ToString("dd/MM/yyyy");
        }
        public void lammoi()
        {
            get_all_hs();
            txtsohs.Text = "";
            txthovaten.Text = "";
            txtngaysinh.Text = "";
            txtdiachi.Text = "";
            dateNgaynophs.Text = "";
            txtdienthoai.Text = "";
            txtbaovenhap.Text = "";
            txtghichu.Text = "";
            load_ngay();
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }
        public void get_all_hs()
        {
            DataTable dt_hs_n = new DataTable();
            dt_hs_n = cls.get_hoso_all();
            gridHoso.DataSource = dt_hs_n;
        }
        private void frmHoSo_Load(object sender, EventArgs e)
        {
            load_ngay();
            get_all_hs();
        }

        private void gvHoSo_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string sohs = "";
            DateTime date;
            sohs = gvHoSo.GetRowCellValue(e.RowHandle, "SoHS").ToString();         
            DataTable dt_hs = new DataTable();
            dt_hs = cls.get_hoso_sohs(sohs);
            date = Convert.ToDateTime(dt_hs.Rows[0]["NgayNopHS"]);
            txtsohs.Text = dt_hs.Rows[0]["SoHS"].ToString();
            txthovaten.Text = dt_hs.Rows[0]["HoTen"].ToString();
            txtngaysinh.Text = dt_hs.Rows[0]["NgaySinh"].ToString();
            txtdiachi.Text = dt_hs.Rows[0]["DiaChi"].ToString();
            dateNgaynophs.Text = date.ToString("dd/MM/yyyy");
            txtdienthoai.Text = dt_hs.Rows[0]["DienThoai"].ToString();
            txtbaovenhap.Text = dt_hs.Rows[0]["BaoVeNhap"].ToString();
            txtghichu.Text = dt_hs.Rows[0]["GhiChu"].ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sohs, hoten, ngaysinh, diachi, dienthoai, ngaynophs, baovenhap, ghichu = "";
            DateTime dngaynophs;
            sohs = txtsohs.Text;
            hoten = txthovaten.Text;
            ngaysinh = txtngaysinh.Text;
            diachi = txtdiachi.Text;
            dienthoai = txtdienthoai.Text;
            baovenhap = txtbaovenhap.Text;
            ghichu = txtghichu.Text;
            dngaynophs = Convert.ToDateTime(dateNgaynophs.Text);
            ngaynophs = dngaynophs.ToString("yyyy-MM-dd");

            if(cls.Update_HoSo(sohs,hoten,ngaysinh,diachi,ngaynophs,dienthoai,baovenhap,ghichu) > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                lammoi();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txtsohs.Text != "")
            {
                if (cls.Delete_HoSo(txtsohs.Text) > 0)
                {
                    MessageBox.Show("Xoá dữ liệu thành công!");
                    lammoi();
                }
            }
            
        }
    }
}
