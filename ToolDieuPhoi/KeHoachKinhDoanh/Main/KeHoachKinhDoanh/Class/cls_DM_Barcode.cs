using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KeHoachKinhDoanh.Class
{
    class cls_DM_Barcode
    {
        clsAccessData cls = new clsAccessData("192.1.1.12,12526", "KHKD");
        DataTable dt = new DataTable();
        public DataTable Load_DM_Barcode(int MaPX, string tuangh, string MaSP, string Barcode)
        {
            SqlParameter[] sqlpar = new SqlParameter[4];
            sqlpar[0] = new SqlParameter("@MaPX", MaPX);
            sqlpar[1] = new SqlParameter("@tuangh", tuangh);
            sqlpar[2] = new SqlParameter("@MaSP", MaSP);
            sqlpar[3] = new SqlParameter("@Barcode", Barcode);

            dt = cls.GetDataTable("TK_P_GET_BARCODE", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        public int Save_Barcode_SanPham(string MaSP, string Mau, string CoSo, string Barcode, string Barcode2)
        {
            SqlParameter[] sqlpar = new SqlParameter[5];
            sqlpar[0] = new SqlParameter("@MaPX", MaSP);
            sqlpar[1] = new SqlParameter("@SoLSX", Mau);
            sqlpar[2] = new SqlParameter("@MaSP", CoSo);
            sqlpar[3] = new SqlParameter("@tuandp", Barcode);
            sqlpar[4] = new SqlParameter("@tuankh", Barcode2);
            return cls.MyExecuteQuyery("TK_P_Save_DM_Barcode", CommandType.StoredProcedure, sqlpar);
        }
        public int Insert_Barcode(string MaSP, string Mau, string CoSo, string Barcode, string Barcode2, string NgayTao)
        {
            SqlParameter[] sqlpar = new SqlParameter[6];
            sqlpar[0] = new SqlParameter("@MaSP", MaSP);
            sqlpar[1] = new SqlParameter("@Mau", Mau);
            sqlpar[2] = new SqlParameter("@CoSo", CoSo);
            sqlpar[3] = new SqlParameter("@Barcode", Barcode);
            sqlpar[4] = new SqlParameter("@Barcode2", Barcode2);
            sqlpar[5] = new SqlParameter("@NgayTao", NgayTao);

            return cls.MyExecuteQuyery("sp_Insert_DM_Barcode", CommandType.StoredProcedure, sqlpar);
        }
        public DataTable Load_DM_Bar(string MaSP, string Barcode)
        {
            string sql = "SELECT MaSP, Mau , CoSo , BarCode ,  BarCode2 , NgayTao FROM dbo.DM_SanPham_Barcode where MaSP " + MaSP + " AND BarCode like '" + Barcode + "'";

            dt = cls.GetDataTable(sql, CommandType.Text);
            return dt;
        }
    }
}
