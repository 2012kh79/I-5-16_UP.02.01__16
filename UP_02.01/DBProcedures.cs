using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_02._01
{
    class DBProcedures
    {
        private SqlCommand cmd = new SqlCommand("Empty",Form1.sql);

        private void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }
        public void spAccount_Insert(string loginAcc, string passwordAcc, Int32 role_id)
        {
            spConfiguration("account_insert");
            try
            {
                cmd.Parameters.AddWithValue("@login_acc", loginAcc);
                cmd.Parameters.AddWithValue("@password_acc", passwordAcc);
                cmd.Parameters.AddWithValue("@role_id", role_id);
                Form1.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                //Form1.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                Form1.sql.Close();
            }
        }
    }
}
