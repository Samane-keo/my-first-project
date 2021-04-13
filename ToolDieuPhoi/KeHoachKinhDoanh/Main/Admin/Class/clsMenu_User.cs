using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace Class
{
    class clsMenu_User
    {
        clsAccessData cls;
        clsConnection conn = new clsConnection();
        DataTable dt = new DataTable();
        public clsMenu_User()
        {
            cls = new clsAccessData(conn.serverName,conn.dbName);
        }

        // INSERT MENU_USER
        public int Insert_Menu_User(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spMenu_User_Insert", CommandType.StoredProcedure, par);
            return result;
        }
        // DELETE MENU_USER
        public int Delete_Menu_User(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spMenu_User_DeleteAll", CommandType.StoredProcedure, par);
            return result;
        }
    }
}
