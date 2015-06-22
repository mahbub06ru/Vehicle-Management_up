using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VehicleManagementSoftware.Model;

namespace VehicleManagementSoftware.DAL
{
    public class VehicleGateway
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString; 
        public int Save(Vehicle aVehicle)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into vehicle (reg,engin) values(@reg,@engin)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@reg", aVehicle.RegNo);
            command.Parameters.Add("@engin", aVehicle.EngineNo);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }

        public bool CheckVehicle(Vehicle aVehicle)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from vehicle where reg='" + aVehicle.RegNo + "' or engin= '" + aVehicle.EngineNo + "' ";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
    }
}