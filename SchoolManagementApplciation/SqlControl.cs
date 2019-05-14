using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace SchoolManagementApplciation
{
    class SqlControl
    {

        private System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        private System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

        public System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter();
        public DataSet data = new DataSet();

        public List<System.Data.SqlClient.SqlParameter> prams = new List<System.Data.SqlClient.SqlParameter>();

        public int count;
        public string exep;

        public void ExecSql(string query)
        {
            exep = "";
            count = 0;
            try
            {
                con.Open();
                cmd = new System.Data.SqlClient.SqlCommand(query, con);
                prams.ForEach(x => cmd.Parameters.Add(x));
                prams.Clear();
                data = new DataSet();
                adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);
                count = adapter.Fill(data, query);
                con.Close();
            }
            catch (Exception ex)
            {
                exep = ex.Message;
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void ExecProc(string query)
        {
            exep = "";
            count = 0;
            try
            {
                con.Open();
                cmd = new System.Data.SqlClient.SqlCommand(query, con);
                prams.ForEach(x => cmd.Parameters.Add(x));
                prams.Clear();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                exep = ex.Message;
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void addprams(string name, object value)
        {
            System.Data.SqlClient.SqlParameter para = new System.Data.SqlClient.SqlParameter(name, value);
            prams.Add(para);
        }
    }
}
