using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class AddFlightForm : Form
    {
        public AddFlightForm()
        {
            InitializeComponent();
        }

        private void selectRouteButton_Click(object sender, EventArgs e)
        {
            string query = "select route_id, start_location, airport_location as arrive_location, flight_time from (select route_id, airport_location as start_location, airport_arrive_id, flight_time from route inner join airport on route.airport_start_id = airport.airport_id) as a inner join airport on a.airport_arrive_id = airport.airport_id";
            DataTable route = sqlFunction.getSqlDataTable(query);
            using (SelectForm selectForm = new SelectForm()) 
            {
                selectForm.loadData(route, "Route");
                selectForm.ShowDialog();
                routeTextBox.Text = selectForm.selectedID;
            }
        }
    }
}
