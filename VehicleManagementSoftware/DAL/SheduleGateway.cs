using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VehicleManagementSoftware.Model;

namespace VehicleManagementSoftware.DAL
{
    public class SheduleGateway
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public List<Vehicle> GetAllVehicles()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from vehicle";
            SqlCommand command = new SqlCommand(query, connection);
            List<Vehicle> vehicles = new List<Vehicle>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vehicle aVehicle = new Vehicle();
                aVehicle.Vid = Convert.ToInt32(reader["vid"].ToString());
                aVehicle.RegNo = reader["reg"].ToString();
                aVehicle.EngineNo = reader["engin"].ToString();
                vehicles.Add(aVehicle);
            }
            connection.Close();
            return vehicles;
        }

        public decimal Save(Shedule aShedule)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into shedule (date,shift,bookedBy,address,vid) values (@date,@shift,@bookedBy,@address,@vid)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@date", aShedule.Date);
            command.Parameters.Add("@shift", aShedule.Shift);
            command.Parameters.Add("@bookedBy", aShedule.BookedBy);
            command.Parameters.Add("@address", aShedule.Address);
            command.Parameters.Add("@vid", aShedule.Vid);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        internal bool CheckShedule(Shedule aShedule)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from shedule where date='" + aShedule.Date + "' and shift= '" + aShedule.Shift + "' ";
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

        public static List<View> GetAllShedules(int vid)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select date,shift from shedule where vid =" + vid;
            SqlCommand command = new SqlCommand(query, connection);
            List<View> views = new List<View>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                View view = new View();
                view.Date = (DateTime)reader["date"];
                view.Shift = reader["shift"].ToString();
                views.Add(view);
            }
            connection.Close();
            return views;
        }
    }
}