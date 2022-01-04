using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ITI_Management_System
{
    internal class DB_Layer
    {

        //Select  connectionless
        public static DataTable Select(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["iti_con"].ConnectionString);
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }


       
        //DML    connection 
        public static int DML(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["iti_con"].ConnectionString);
            cmd.Connection = conn;
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }
    }
}
