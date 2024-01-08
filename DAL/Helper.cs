using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class Helper : IDisposable
    {
         SqlConnection cn;
         SqlCommand cmd;
         string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            cn = new SqlConnection(cstr);
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            cn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // SqlConnection ve SqlCommand nesnelerini dispose et
                if (cmd != null)
                {
                    cmd.Dispose();
                    cmd = null;
                }

                if (cn != null)
                {
                    cn.Dispose();
                    cn = null;
                }
            }
        }
    }
}
