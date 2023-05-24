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
            stopOver_grid.Columns.Add("airport_id", "ID");
            stopOver_grid.Columns.Add("airport_name", "Airport Name");
            stopOver_grid.Columns.Add("airport_location", "Location");
            stopOver_grid.Columns[0].Width = stopOver_grid.Width / 3;
            stopOver_grid.Columns[1].Width = stopOver_grid.Width / 3;
            stopOver_grid.Columns[2].Width = stopOver_grid.Width / 3;
            flightDeparture.Format = DateTimePickerFormat.Custom;
            flightDeparture.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            flightID.Text = sqlFunction.getSqlDataTable("select max(flight_id) from flight").Rows[0][0].ToString();
        }

        private void selectRouteButton_Click(object sender, EventArgs e)
        {
            string query = "select route_id, start_location, airport_location as arrive_location, flight_time from (select route_id, airport_location as start_location, airport_arrive_id, flight_time from route inner join airport on route.airport_start_id = airport.airport_id) as a inner join airport on a.airport_arrive_id = airport.airport_id";
            DataTable route = sqlFunction.getSqlDataTable(query);
            using (SelectForm selectForm = new SelectForm()) 
            {
                selectForm.loadData(route, "Route");
                selectForm.ShowDialog();
                routeID.Text = selectForm.selectedID;
            }
            if (routeID.Text == "")
            {
                return;
            }
            DataTable routeInfo = sqlFunction.getSqlDataTable("select route_id, airport.airport_name as start, airport.airport_location as start_location, b.airport_name as arrive, b.airport_location as arrive_location from route inner join airport on airport_start_id = airport_id inner join airport as b on airport_arrive_id = b.airport_id where route_id = " + routeID.Text);
            airportStart.Text = routeInfo.Rows[0]["start"].ToString();
            airportArrive.Text = routeInfo.Rows[0]["arrive"].ToString();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string airportID;
            using (SelectForm selectForm = new SelectForm())
            {
                DataTable airport = sqlFunction.getSqlDataTable("select * from airport");
                selectForm.loadData(airport, "Airport");
                selectForm.ShowDialog();
                airportID = selectForm.selectedID;
            }
            if (airportID == "")
            {
                return;
            }
            DataTable airportInfo = sqlFunction.getSqlDataTable("select airport_name, airport_location from airport where airport_id = " + airportID);
            stopOver_grid.Rows.Add(airportID, airportInfo.Rows[0][0].ToString(), airportInfo.Rows[0][1].ToString());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (class1amount.Text == "" || class2amount.Text == "" || routeID.Text == "")
            {
                MessageBox.Show("Please fill all information");
                return;
            }
            for (int i = 0; i < stopOver_grid.Rows.Count; i++)
            {
                for (int j = i + 1; j < stopOver_grid.Rows.Count; j++)
                {
                    if (stopOver_grid.Rows[i].Cells[0].Value.ToString() == stopOver_grid.Rows[j].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Stopover duplicate");
                        return;
                    }
                }
            }
            string date = flightDeparture.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "insert into flight values (" + routeID.Text + ", '" + date + "', '" + class1amount.Text + "', " + class2amount.Text + ")";
            sqlFunction.sqlQueryExcute(query);
            query = "insert into seat_detail values ((select max(flight_id) from flight), 1," + class1amount.Text + ", 0)";
            sqlFunction.sqlQueryExcute(query);
            query = "insert into seat_detail values ((select max(flight_id) from flight), 2," + class2amount.Text + ", 0)";
            sqlFunction.sqlQueryExcute(query);
            for (int i = 0; i < stopOver_grid.Rows.Count; i++)
            {
                query = "insert into flight_detail values ((select max(flight_id) from flight), " + stopOver_grid.Rows[i].Cells[0].Value.ToString() + ", '')";
                sqlFunction.sqlQueryExcute(query);
            }
            MessageBox.Show("Add Flight Success");
            this.Close();
        }

        private void class1amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (stopOver_grid.SelectedRows.Count == 0)
            {
                return;
            }
            stopOver_grid.Rows.RemoveAt(stopOver_grid.SelectedRows[0].Index);
        }
    }
}
