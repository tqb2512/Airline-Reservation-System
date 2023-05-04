using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Reservation_System.Classes;

namespace Airline_Reservation_System.Functions
{
    internal class PassengerFunction
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public static Passenger getPassengerDetail(int passengerId)
        {
            Passenger passenger = new Passenger();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM PASSENGER WHERE PASSENGER_ID = " + passengerId;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    passenger.ID = reader.GetInt32(0);
                    passenger.FullName = reader.GetString(1);
                    passenger.PhoneNumber = reader.GetString(2);
                    passenger.IDNumber = reader.GetString(3);
                }
                connection.Close();
                return passenger;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static int getMaxID()
        {
            try
            {
                int max = 0;
                string query = "SELECT MAX(passenger_id) AS MAX FROM passenger";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    max = reader.GetInt32(0);
                }
                connection.Close();
                return max;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public static bool deletePassenger(int passengerID)
        {
            try
            {
                string query = "DELETE FROM passenger WHERE passenger_id = '" + passengerID + "'";
                if (sqlFunction.sqlQueryExcute(query) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
