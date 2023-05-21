using Airline_Reservation_System.Classes;
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
    public partial class RouteManagementForm : Form
    {
        public RouteManagementForm()
        {
            InitializeComponent();
            dataLoad();
        }

        float idColumnWidth = 0.15f;
        float departureColumnWidth = 0.25f;
        float arrivalNumColumnWidth = 0.25f;
        float flightTimeColumnWidth = 0.35f;

        Route route = new Route();

        private void dataLoad()
        {
            string query = "select * from route";

            DataTable table = sqlFunction.getSqlDataTable(query);
            routeDataGridView.DataSource = table;

            routeDataGridView.Columns["route_id"].HeaderText = "Route ID";
            routeDataGridView.Columns["airport_start_id"].HeaderText = "Departure";
            routeDataGridView.Columns["airport_arrive_id"].HeaderText = "Arrival";
            routeDataGridView.Columns["flight_time"].HeaderText = "Flight Time";

            routeDataGridView.Columns["route_id"].Width = (int)(routeDataGridView.Width * idColumnWidth);
            routeDataGridView.Columns["airport_start_id"].Width = (int)(routeDataGridView.Width * departureColumnWidth);
            routeDataGridView.Columns["airport_arrive_id"].Width = (int)(routeDataGridView.Width * arrivalNumColumnWidth);
            routeDataGridView.Columns["flight_time"].Width = (int)(routeDataGridView.Width * flightTimeColumnWidth);

            R_ID_TextBox.ReadOnly = true;
            R_Departure_TextBox.ReadOnly = true;
            R_Arrival_TextBox.ReadOnly = true;  
            R_FlightTime_TextBox.ReadOnly = true;

            R_ID_TextBox.Enabled = false;
            R_Departure_TextBox.Enabled = false;
            R_Arrival_TextBox.Enabled = false;
            R_FlightTime_TextBox.Enabled = false;
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in R_SearchTableLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idRouteSearchTextBox":
                                filter += "CONVERT(route_id, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "departureSearchTextBox":
                                filter += "CONVERT(airport_start_id, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "arrivalSearchTextBox":
                                filter += "CONVERT(airport_arrive_id, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "flightTimeSearchTextBox":
                                filter += "CONVERT(flight_time, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (routeDataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (routeDataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void R_addButton_Click(object sender, EventArgs e)
        {
            AddRouteForm addRouteForm = new AddRouteForm();
            addRouteForm.ShowDialog();  
        }

        private void R_refreshButton_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void routeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                R_editButton.Text = "Edit";
                route = Functions.RouteFunction.getRouteDetail(Convert.ToInt32(routeDataGridView.Rows[e.RowIndex].Cells["route_id"].Value.ToString()));

                R_ID_TextBox.Text = route.ID.ToString();
                R_Departure_TextBox.Text = route.Departure.ToString();
                R_Arrival_TextBox.Text = route.Arrival.ToString();
                R_FlightTime_TextBox.Text = route.FligtTime.ToString();

                R_ID_TextBox.ReadOnly = true;
                R_Departure_TextBox.ReadOnly = true;
                R_Arrival_TextBox.ReadOnly = true;
                R_FlightTime_TextBox.ReadOnly = true;

                R_ID_TextBox.Enabled = false;
                R_Departure_TextBox.Enabled = false;
                R_Arrival_TextBox.Enabled = false;
                R_FlightTime_TextBox.Enabled = false;
            }
        }

        private void R_deteleButton_Click(object sender, EventArgs e)
        {
            if (R_ID_TextBox.Text != "" || R_ID_TextBox.Text != Convert.ToString(Functions.RouteFunction.getMaxID()))
            {
                if (Functions.RouteFunction.deleteRoute(Convert.ToInt32(R_ID_TextBox.Text)) == true)
                {
                    MessageBox.Show("Route Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    R_ID_TextBox.Text = "";
                    R_Departure_TextBox.Text = "";
                    R_Arrival_TextBox.Text = "";
                    R_FlightTime_TextBox.Text = "";

                    dataLoad();
                }
                else
                {
                    MessageBox.Show("Deleting Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
