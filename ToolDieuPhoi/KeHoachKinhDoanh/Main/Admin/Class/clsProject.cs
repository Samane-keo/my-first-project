using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace Class
{
    class clsProject
    {
        
        clsAccessData cls;
        clsConnection conn = new clsConnection();
        DataTable dt = new DataTable();
        public clsProject()
        { 
            cls = new clsAccessData(conn.serverName,conn.dbName);
        }
        //LOAD PROJECT
        public DataTable Load_Project()
        {
            dt = cls.GetDataTable("select ProjectID,ProjectName,Description from tblProject", CommandType.Text);
            return dt;
        }
        // INSERT PROJECT
        public int Insert_Project(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spProject_Insert", CommandType.StoredProcedure, par);
            return result;
        }
        // UPDATE PROJECT
        public int Update_Project(SqlParameter[] par)
        {
            int result = 0;
            result = cls.MyExecuteQuyery("spProject_Update", CommandType.StoredProcedure, par);
            return result;
        }
    }
}
