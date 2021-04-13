using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KeHoachKinhDoanh.Class
{
    public class cls_DieuPhoi
    {
        clsAccessData cls = new clsAccessData("192.1.1.14", "KHKD");
        DataTable dt = new DataTable();

        public DataTable Load_Khachhang(string makh)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@MaKH", makh);
            dt = cls.GetDataTable("sp_get_cbo_khachhang", CommandType.StoredProcedure,sqlpar);
            return dt;
        }
        public DataTable Load_SanPham(string masp)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@MaSP", masp);
            dt = cls.GetDataTable("sp_get_cbo_masp", CommandType.StoredProcedure,sqlpar);
            return dt;
        }
        public DataTable Load_Header_LSX(string SoLSX)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@SoLSX", SoLSX);
            dt = cls.GetDataTable("sp_get_head_lsx", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        public DataTable get_lsx_H(string tungay, string denngay)
        {
            SqlParameter[] sqlpar = new SqlParameter[2];
            sqlpar[0] = new SqlParameter("@TuNgay", tungay);
            sqlpar[1] = new SqlParameter("@DenNgay", denngay);
            dt = cls.GetDataTable("Get_dp_lsx_h_excel", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        public DataTable get_lsx_H_LSX(string solsx)
        {
            string sql = "SELECT SoLSX ,MaKH ,SoDDH, NgayGH,NgayTN,NgayDP,NgayVTDU,NgayLap, NgayDuPhong, GhiChu, CHTT, TGPP FROM dbo.DP_LSX_H where SoLSX "+solsx+ "ORDER BY NgayGH,SoLSX";

            dt = cls.GetDataTable(sql, CommandType.Text);
            return dt;
        }
        public DataTable get_lsx_L_LSX(string solsx)
        {
            string sql = "SELECT l.SoLSX ,MaSP,MA_MAU, MSM ,CoSoID ,SoLuong ,SoDH ,Moi ,l.Ngayphatsinh FROM dbo.DP_LSX_H h INNER JOIN dbo.DP_LSX_L l ON l.SoLSX = h.SoLSX WHERE l.SoLSX " + solsx+ " ORDER BY SoLSX ,MaSP,MA_MAU, MSM ,CoSoID ,SoLuong ,SoDH ,Moi ,Ngayphatsinh";
            dt = cls.GetDataTable(sql, CommandType.Text);
            return dt;
        }
        public DataTable get_lsx_L(string tungayl, string denngayl)
        {
            SqlParameter[] sqlpar = new SqlParameter[2];
            sqlpar[0] = new SqlParameter("@TuNgay", tungayl);
            sqlpar[1] = new SqlParameter("@DenNgay", denngayl);
            dt = cls.GetDataTable("Get_dp_lsx_l_excel", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        public DataTable Load_Line_LSX(string SoLSX)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@SoLSX", SoLSX);
            dt = cls.GetDataTable("sp_GetLSX_Pivot", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        public DataTable Load_DoiChieu_Export_Thang_TK_LSX(string thang, string nam, string loaikh, string tenkh, string masp)
        {
            SqlParameter[] sqlpar = new SqlParameter[5];
            sqlpar[0] = new SqlParameter("@Thang", thang);
            sqlpar[1] = new SqlParameter("@Nam", nam);
            sqlpar[2] = new SqlParameter("@LoaiKH", loaikh);
            sqlpar[3] = new SqlParameter("@TenKH", tenkh);
            sqlpar[4] = new SqlParameter("@MaSP", masp);
            dt = cls.GetDataTable("DP_spDoiChieu_Export_Thang1", CommandType.StoredProcedure,sqlpar);
            return dt;
        }
        public DataTable find_lsx(string lsx, string mamau, string masp)
        {
            SqlParameter[] sqlpar = new SqlParameter[3];
            sqlpar[0] = new SqlParameter("@SoLSX", lsx);
            sqlpar[1] = new SqlParameter("@MaMau", mamau);
            sqlpar[2] = new SqlParameter("@MaSP", masp);
            dt = cls.GetDataTable("TimKiem_LSX_LSXID_04032019_Hien", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        public int Insert_BCDC_NHAMAY(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("Insert_Data_BCDC_NHAMAY_04032019_Hien", CommandType.StoredProcedure, par);
            return result;
        }
        public int Insert_DP_LSX_H(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("sp_Insert_DP_LSX_H", CommandType.StoredProcedure, par);
            return result;
        }
        public int Insert_DP_LSX_L(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("sp_Insert_DP_LSX_L", CommandType.StoredProcedure, par);
            return result;
        }
        public int sp_Update_Note_LSX(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("sp_Update_Note_LSX", CommandType.StoredProcedure, par);
            return result;
        }
        public DataTable Load_DoiChieu_Export_Thang(string thang, string nam, string loaikh, string tenkh, string masp)
        {
            SqlParameter[] sqlpar = new SqlParameter[5];
            sqlpar[0] = new SqlParameter("@Thang", thang);
            sqlpar[1] = new SqlParameter("@Nam", nam);
            sqlpar[2] = new SqlParameter("@LoaiKH", loaikh);
            sqlpar[3] = new SqlParameter("@TenKH", tenkh);
            sqlpar[4] = new SqlParameter("@MaSP", masp);
            dt = cls.GetDataTable("DP_spDoiChieu_Export_Thang_18012020_Hien", CommandType.StoredProcedure, sqlpar);
            return dt;
        }

    }
}
