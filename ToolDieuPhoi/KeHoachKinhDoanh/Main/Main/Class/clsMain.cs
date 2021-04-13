using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace Class
{
    class clsMain
    {
        clsAccessData cls = new clsAccessData("192.1.1.20,12526", "DBMain");
        DataTable dt = new DataTable();

        //LOAD PARENT MENU
        public DataTable Load_LeftMenu(int userid)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@UserID", userid);         
            return cls.GetDataTable("spMain_Load_LeftMenu", CommandType.StoredProcedure, sqlpar);
        }
        //LOAD CHILD MENU
        public DataTable Load_ChildMenu(int projectid, int userid)
        {
            SqlParameter[] sqlpar = new SqlParameter[2];
            sqlpar[0] = new SqlParameter("@ProjectID", projectid);
            sqlpar[1] = new SqlParameter("@UserID", userid);
            return cls.GetDataTable("spMain_Load_ChildMenu", CommandType.StoredProcedure, sqlpar);
        }
        //CHECK USER LOGIN 
        public DataTable Check_Login(string username, string password, bool active)
        {
            SqlParameter[] sqlpar = new SqlParameter[3];
            sqlpar[0] = new SqlParameter("@Username", username);
            sqlpar[1] = new SqlParameter("@Password", password);
            sqlpar[2] = new SqlParameter("@isActive", active);
            dt = cls.GetDataTable("spUser_CheckLogin", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        //UPDATE LOGIN DATE
        public int Update_LoginDate(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spUser_UpdateLoginDate", CommandType.StoredProcedure, par);
            return result;
        }


        //LOAD CHILD MENU
        public DataTable Maintenance()
        {
            return cls.GetDataTable("select MaXuong,TenXuong from TKL_DMXuong", CommandType.Text);
        }
    }
}
