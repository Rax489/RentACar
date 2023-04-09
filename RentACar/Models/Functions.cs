using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace RentACar.Models
{
    public class Functions
    {
        public SqlConnection sqlConnection;
        public SqlCommand cmd;
        public DataTable dt;
        public string connectionString;
        public SqlDataAdapter sda;

        public Functions() 
        {
            string dbPath = HostingEnvironment.MapPath(@"~/App_Data/CarRentalDbASP.mdf");
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Downloads\RentACar\RentACar\App_Data\CarRentalDbASP.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
        }
        public DataTable GetData(string query) 
        {
            this.dt = new DataTable();
            this.sda = new SqlDataAdapter(query, this.connectionString);
            this.sda.Fill(this.dt);
            return this.dt;
        }
        public int SetData(string query) 
        {
            int rcnt = 0;
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            cmd.CommandText = query;
            rcnt = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return rcnt;
        }
    }
}