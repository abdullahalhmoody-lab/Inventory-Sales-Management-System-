using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Sales_Management_Systemm
{
    public static class DBHelper
    {
        private static string connectionString =
            @"Server=(localdb)\MSSQLLocalDB; Database=InventoryDB1; Integrated Security=True";
 
        // INSERT – UPDATE – DELETE
        public static int ExecuteCommand(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // SELECT → DataTable
        public static DataTable ExecuteDataTable(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // SELECT Scalar
        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
