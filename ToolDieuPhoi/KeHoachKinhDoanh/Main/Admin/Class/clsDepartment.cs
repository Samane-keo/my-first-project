using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace Class
{
    public class clsDepartment
    {
        clsAccessData cls;
        clsConnection conn = new clsConnection();
        DataTable dt = new DataTable();

        public clsDepartment()
        {
            cls = new clsAccessData(conn.serverName,conn.dbName);
        }
        //LOAD DEPARTMENT
        public DataTable Load_Department()
        {
            dt = cls.GetDataTable("select madv,tendv from tbldonvi order by madv", CommandType.Text);
            return dt;
        }
    }
}
