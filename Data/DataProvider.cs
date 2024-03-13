using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHThuoc.Data
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value; 
        }

        private DataProvider() { }

        private string sqlConnection = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = QUANLYCUAHANGTHUOC; Integrated Security = True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(sqlConnection))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int res = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlConnection, conn);
                res = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return res;
        }
    }
}
