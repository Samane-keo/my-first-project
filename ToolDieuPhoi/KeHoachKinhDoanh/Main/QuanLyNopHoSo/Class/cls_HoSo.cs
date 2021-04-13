using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AccessData;

namespace QuanLyNopHoSo.Class
{
    public class cls_HoSo
    {
        clsAccessData cls = new clsAccessData("192.1.1.10,12526", "RIC");
        DataTable dt = new DataTable();

        public int Insert_HoSo(string SoHS, string HoTen, string NgaySinh, string DiaChi, string NgayNopHS, string DienThoai, string BaoVeNhap, string GhiChu)
        {
            SqlParameter[] sqlpar = new SqlParameter[8];
            sqlpar[0] = new SqlParameter("@SoHS", SoHS);
            sqlpar[1] = new SqlParameter("@HoTen", HoTen);
            sqlpar[2] = new SqlParameter("@NgaySinh", NgaySinh);
            sqlpar[3] = new SqlParameter("@DiaChi", DiaChi);
            sqlpar[4] = new SqlParameter("@NgayNopHS", NgayNopHS);
            sqlpar[5] = new SqlParameter("@DienThoai", DienThoai);
            sqlpar[6] = new SqlParameter("@BaoVeNhap", BaoVeNhap);
            sqlpar[7] = new SqlParameter("@GhiChu", GhiChu);

            return cls.MyExecuteQuyery("sp_InsertHoSo", CommandType.StoredProcedure, sqlpar); 
        }
        public int Update_HoSo(string SoHS, string HoTen, string NgaySinh, string DiaChi, string NgayNopHS, string DienThoai, string BaoVeNhap, string GhiChu)
        {
            SqlParameter[] sqlpar = new SqlParameter[8];
            sqlpar[0] = new SqlParameter("@SoHS", SoHS);
            sqlpar[1] = new SqlParameter("@HoTen", HoTen);
            sqlpar[2] = new SqlParameter("@NgaySinh", NgaySinh);
            sqlpar[3] = new SqlParameter("@DiaChi", DiaChi);
            sqlpar[4] = new SqlParameter("@NgayNopHS", NgayNopHS);
            sqlpar[5] = new SqlParameter("@DienThoai", DienThoai);
            sqlpar[6] = new SqlParameter("@BaoVeNhap", BaoVeNhap);
            sqlpar[7] = new SqlParameter("@GhiChu", GhiChu);

            return cls.MyExecuteQuyery("sp_UpdateHoSo", CommandType.StoredProcedure, sqlpar);
        }
        public int Delete_HoSo(string SoHS)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@SoHS", SoHS);
            return cls.MyExecuteQuyery("sp_DeleteHoSo", CommandType.StoredProcedure, sqlpar);
        }
        public DataTable get_top_hoso()
        {
            string sql = "SELECT TOP 1 SoHS FROM dbo.QLNhapHS ORDER BY NgayNhap DESC";
            dt = cls.GetDataTable(sql, CommandType.Text);
            return dt;
        }
        public DataTable get_hoso_all()
        {
            string sql = "SELECT SoHS ,HoTen ,NgaySinh ,DiaChi ,NgayNopHS ,DienThoai ,BaoVeNhap ,GhiChu ,NgayNhap FROM dbo.QLNhapHS ORDER BY NgayNhap DESC";
            dt = cls.GetDataTable(sql, CommandType.Text);
            return dt;
        }
        public DataTable get_hoso_str(string sohs, string hoten, string ngaysinh, string ngaynophs, string dienthoai, string baovenhap)
        {
            string sql = "SELECT SoHS ,HoTen ,NgaySinh ,DiaChi ,NgayNopHS ,DienThoai ,BaoVeNhap ,GhiChu ,NgayNhap FROM dbo.QLNhapHS ORDER BY NgayNhap DESC";
            dt = cls.GetDataTable(sql, CommandType.Text);
            return dt;
        }
        public DataTable get_hoso_sohs(string sohs)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@SoHS", sohs);
            dt = cls.GetDataTable("sp_Get_HoSo", CommandType.StoredProcedure, sqlpar);
            return dt;
        }

    }
}
