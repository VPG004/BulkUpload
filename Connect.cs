using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using NLog.Internal;

namespace BulkUpload
{
    public class Connect
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Quotes_ConnectionString"].ConnectionString);
        }

        public static SqlDataReader ExecuteReader(string qry)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand(qry, getConnection());
                cmd.Connection.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return dr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable getData(string qry)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, getConnection());
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet getDataSet(string qry)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(qry, getConnection());
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int ExecuteNonQuery(string qry)
        {
            try
            {
                int i;
                SqlCommand cmd = new SqlCommand(qry, getConnection());
                cmd.Connection.Open();
                i = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


