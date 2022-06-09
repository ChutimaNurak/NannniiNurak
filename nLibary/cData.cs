using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLibary
{
	public static class cData
	{
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        #region getDataSetWithSqlCommand
        public static DataSet getDataSetWithSqlCommand(string strConn, string query, int timeOut, bool AlertDisplay)
        {

            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.CommandTimeout = timeOut;
                    da.Fill(ds, "getDsSql");
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (AlertDisplay)
                {
                    cMessage.Error_NotCaption(ex.Message);
                }
                ds.Tables.Add("aaaa");

            }

            return ds;
        }
        #endregion    

        #region setSqlWithCommand
        public static bool setSqlWithCommand(string query, string strConn, int timeOut, bool flag)
        {
            bool result = false;
            try
            {
                SqlTransaction sqltrans;
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    sqltrans = conn.BeginTransaction();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandType = CommandType.Text;
                            comm.CommandText = query;
                            comm.CommandTimeout = timeOut;
                            comm.Connection = conn;
                            comm.Transaction = sqltrans;

                            comm.ExecuteNonQuery();
                            sqltrans.Commit();

                            result = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        sqltrans.Rollback();
                        if (flag)
                        {
                            cMessage.Error_NotCaption(ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                if (flag)
                {
                    cMessage.Error_NotCaption(ex.Message);
                }
            }

            return result;
        }
        #endregion
    }
}
