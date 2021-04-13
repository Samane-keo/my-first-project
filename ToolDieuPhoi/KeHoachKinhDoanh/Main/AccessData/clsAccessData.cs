using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AccessData
{
    public class clsAccessData
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd = new SqlCommand();

        public string ser = "";
        public string db = "";

        public SqlConnection DBOpenConnect(string strConn)
        {
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
            return conn;
        }

        public void DBCloseConnect(SqlConnection conn)
        {
            conn.Close();
            conn.Dispose();
        }

        public clsAccessData(string tensv, string tendb)
        {
            ser = tensv;
            db = tendb;
        }
        public string chuoiketnoi()
        {
            //;Persist Security Info=True;User ID=sa;Password=sa
            //string chuoikn1 = "Data Source=" + ser + ";Initial Catalog=" + db + ";Integrated security=SSPI";            
            string chuoikn1 = "Data Source=" + ser + ";Initial Catalog=" + db + ";Persist Security Info=True;User ID=sa;Password=sa";
            return chuoikn1;
        }
        public SqlConnection getConnection()
        {
            try
            {
                sqlcon = new SqlConnection(chuoiketnoi());
                if (sqlcon.State != ConnectionState.Open)
                {
                    sqlcon.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return sqlcon;
        }

        private void closeConnection()
        {
            sqlcon.Close();
            sqlcmd.Dispose();
        }

        public DataTable GetDataTable(string sql, CommandType cmdType, SqlParameter[] sqlpar = null)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlcon = getConnection();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = sql;
                sqlcmd.CommandType = cmdType;
                if (sqlpar != null)
                {
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddRange(sqlpar);
                }
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlcmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public int MyExecuteQuyery(string sql, CommandType cmdType, SqlParameter[] sqlpar = null)
        {
            int result = 0;
            try
            {
                sqlcon = getConnection();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = sql;
                sqlcmd.CommandType = cmdType;
                if (sqlpar != null)
                {
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddRange(sqlpar);
                }
                result = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                closeConnection();
                sqlcmd.Dispose();
            }
            return result;
        }

        public DataTable MyExecuteQuyery(string sql, CommandType cmdType)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlcon = getConnection();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = sql;
                sqlcmd.CommandType = cmdType;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlcmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }


        //Trả về giá trị của dòng và cột đầu tiên trong bảng kết quả
        public object ExecuteScalar(string commandText, CommandType commandType, SqlParameter[] sqlpar = null)
        {
            object result = null;
            try
            {
                sqlcon = getConnection();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = commandText;
                sqlcmd.CommandType = commandType;
                if (sqlpar != null)
                {
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddRange(sqlpar);
                }
                result = sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConnection();
                sqlcmd.Dispose();
            }
            return result;
        }
    }
}
