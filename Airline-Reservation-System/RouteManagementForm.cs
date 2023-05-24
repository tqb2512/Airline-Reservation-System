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
            this.SizeChanged += new EventHandler(RouteManagementForm_SizeChanged);
        }

        double routeIdWidth = 0.2;
        double startWidth = 0.2;
        double startLocationWidth = 0.2;
        double arriveWidth = 0.2;
        double arriveLocationWidth = 0.2;

        private void dataLoad()
        {
            DataTable route = sqlFunction.getSqlDataTable("select route_id, airport.airport_name as start, airport.airport_location as start_location, b.airport_name as arrive, b.airport_location as arrive_location from route inner join airport on airport_start_id = airport_id inner join airport as b on airport_arrive_id = b.airport_id");
            kryptonDataGridView1.DataSource = route;
            kryptonDataGridView1.Columns[0].HeaderText = "Route ID";
            kryptonDataGridView1.Columns[1].HeaderText = "Airport Start";
            kryptonDataGridView1.Columns[2].HeaderText = "Airport Start Location";
            kryptonDataGridView1.Columns[3].HeaderText = "Airport Arrive";
            kryptonDataGridView1.Columns[4].HeaderText = "Airport Arrive Location";
        }

        private void RouteManagementForm_SizeChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * routeIdWidth);
            kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * startWidth);
            kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * startLocationWidth);
            kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * arriveWidth);
            kryptonDataGridView1.Columns[4].Width = (int)(kryptonDataGridView1.Width * arriveLocationWidth);
            searchLayout.ColumnStyles[0].Width = (int)(searchLayout.Width * routeIdWidth);
            searchLayout.ColumnStyles[1].Width = (int)(searchLayout.Width * startWidth);
            searchLayout.ColumnStyles[2].Width = (int)(searchLayout.Width * startLocationWidth);
            searchLayout.ColumnStyles[3].Width = (int)(searchLayout.Width * arriveWidth);
            searchLayout.ColumnStyles[4].Width = (int)(searchLayout.Width * arriveLocationWidth);
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable routeDetail = sqlFunction.getSqlDataTable("select route_id, airport.airport_name as start, airport.airport_location as start_location, b.airport_name as arrive, b.airport_location as arrive_location from route inner join airport on airport_start_id = airport_id inner join airport as b on airport_arrive_id = b.airport_id where route_id = '" + kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
            DataTable class1price = sqlFunction.getSqlDataTable("select price from ticket_price where route_id = '" + kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' and seat_id = 1");
            DataTable class2price = sqlFunction.getSqlDataTable("select price from ticket_price where route_id = '" + kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' and seat_id = 2");

            routeId.Text = routeDetail.Rows[0][0].ToString();
            airportStart.Text = routeDetail.Rows[0][1].ToString();
            startLocation.Text = routeDetail.Rows[0][2].ToString();
            airportArrive.Text = routeDetail.Rows[0][3].ToString();
            arriveLocation.Text = routeDetail.Rows[0][4].ToString();
            class1Price.Text = class1price.Rows[0][0].ToString();
            class2Price.Text = class2price.Rows[0][0].ToString();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddRouteForm addRouteForm = new AddRouteForm();
            addRouteForm.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
