using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Reservation_System.Classes;

namespace Airline_Reservation_System.Functions
{
    internal class RouteFunction
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public static Route getRouteDetail(int routeID)
        {
            Route route = new Route();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM route WHERE route_id = " + routeID;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    route.ID = reader.GetInt32(0);
                    route.Departure = reader.GetInt32(1);
                    route.Arrival = reader.GetInt32(2);
                    route.FligtTime = reader.GetInt32(3);
                }
                connection.Close();
                return route;
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
                string query = "SELECT MAX(route_id) AS MAX FROM route";
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

        public static bool deleteRoute(int routeID)
        {
            try
            {
                string query = "DELETE FROM route WHERE route_id = '" + routeID + "'";
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
