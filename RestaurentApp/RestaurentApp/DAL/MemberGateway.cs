using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using RestaurentApp.Models;

namespace RestaurentApp.DAL
{
    public class MemberGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["RestaurentBillSystem"].ConnectionString;
        public int Save(Member amember)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"INSERT INTO Members(Code,Name,Email,ContactNo,Type) VALUES('"
                + amember.Code + "','" + amember.Name + "','" + amember.Email + "','"
                + amember.ContactNo + "','" + amember.Type + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

    }
}