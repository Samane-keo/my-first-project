using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace Class
{
    class clsMenu
    {
        clsAccessData cls;
        clsConnection conn = new clsConnection();
        DataTable dt = new DataTable();
        public clsMenu()
        {
            cls = new clsAccessData(conn.serverName,conn.dbName);
        }

        //LOAD MENU
        public DataTable Load_Menu()
        {
            dt = cls.GetDataTable("spMenu_GetAll", CommandType.Text);
            return dt;
        }
        
        //LOAD MENU BY PROJECT ID
        public DataTable Load_MenuByProjectID(int projectid)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@ProjectID", projectid);
            dt = cls.GetDataTable("spMenu_GetMenuByProjectID", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        //LOAD MENU INTO CHECKLIST BY PROJECT ID
        public DataTable Load_MenuIntoCheckboxByProjectID(int projectid)
        {
            SqlParameter[] sqlpar = new SqlParameter[1];
            sqlpar[0] = new SqlParameter("@ProjectID", projectid);
            dt = cls.GetDataTable("spMenu_LoadByProjectID", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        //LOAD CHECKED MENU INTO CHECKLISTBOX BY PROJECT ID
        public DataTable Load_CheckedMenu(int projectid,int userid)
        {
            SqlParameter[] sqlpar = new SqlParameter[2];
            sqlpar[0] = new SqlParameter("@ProjectID", projectid);
            sqlpar[1] = new SqlParameter("@UserID", userid);
            dt = cls.GetDataTable("spMenu_LoadCheckedMenu", CommandType.StoredProcedure, sqlpar);
            return dt;
        }
        // INSERT MENU
        public int Insert_Menu(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spMenu_Insert", CommandType.StoredProcedure, par);
            return result;
        }
        // UPDATE MENU
        public int Update_Menu(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spMenu_Update", CommandType.StoredProcedure, par);
            return result;
        }
        // DELETE MENU
        public int Delete_Menu(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spMenu_Delete", CommandType.StoredProcedure, par);
            return result;
        }
    }
}
