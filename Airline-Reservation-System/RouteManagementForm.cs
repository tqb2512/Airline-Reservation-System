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

        private void dataLoad()
        {
            string query = "select * from route";

            DataTable table = sqlFunction.getSqlDataTable(query);
            routeDataGridView.DataSource = table;

            routeDataGridView.Columns["route_id"].HeaderText = "Route ID";
            routeDataGridView.Columns["airport_start_id"].HeaderText = "Departure";
            routeDataGridView.Columns["airport_arrive_id"].HeaderText = "Arrival";
            routeDataGridView.Columns["flight_time"].HeaderText = "Flight Time";
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
    }
}
