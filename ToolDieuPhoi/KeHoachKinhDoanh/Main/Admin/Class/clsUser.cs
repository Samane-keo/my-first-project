using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace Class
{
    public class clsUser
    {
        clsAccessData cls;
        clsConnection conn = new clsConnection();
        DataTable dt = new DataTable();
        public clsUser()
        { 
            cls = new clsAccessData(conn.serverName,conn.dbName);
        }
        //LOAD USER INFO
        public DataTable Load_User()
        {
            dt = cls.GetDataTable("spUser_GetAll", CommandType.Text);
            return dt;
        }

        public DataTable Load_User_GrantPer()
        {
            dt = cls.GetDataTable("select UserID,Username,Fullname from tblUser u inner join tbldonvi dv on u.Department=dv.madv", CommandType.Text);
            return dt;
        }

        // CHANGE PASSWORD
        public int User_ChangePassword(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spUser_ChangePassword", CommandType.StoredProcedure, par);
            return result;
        }

        // Insert method
        public int Insert_User(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spUser_Insert", CommandType.StoredProcedure, par);
            return result;
        }
        // Update method
        public int Update_User(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spUser_Update", CommandType.StoredProcedure, par);
            return result;
        }
        // Delete method
        public int Delete_User(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spUser_Delete", CommandType.StoredProcedure, par);
            return result;
        }
    }
}
