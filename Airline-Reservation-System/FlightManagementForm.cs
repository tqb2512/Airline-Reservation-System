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
    public partial class FlightManagementForm : Form
    {
        double idWidth = 0.05;
        double fromWidth = 0.15;
        double toWidth = 0.15;
        double dateWidth = 0.15;
        double timeWidth = 0.1;
        double class1seatWidth = 0.1;
        double class1reservedWidth = 0.1;
        double class2seatWidth = 0.1;
        double class2reservedWidth = 0.1;
        public FlightManagementForm()
        {
            InitializeComponent();
            dataLoad();
            this.SizeChanged += new EventHandler(FlightManagementForm_SizeChanged);
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            AddFlightForm addFlightForm = new AddFlightForm();
            addFlightForm.ShowDialog();
            dataLoad();
        }

        private void dataLoad()
        {
            string query = "select c.flight_id, departure, start, arrive, flight_time, class_1_amount, class1_reserved, class_2_amount, reserved_amount as class2_reserved from (select b.flight_id, route_id, departure, start, arrive, flight_time, reserved_amount as class1_reserved, class_1_amount, class_2_amount from (select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time, class_1_amount, class_2_amount from (select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time, class_1_amount, class_2_amount from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id) as a inner join airport on airport_arrive_id = airport_id) as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1) as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2";
            DataTable table = sqlFunction.getSqlDataTable(query);
            flightDataGridView.DataSource = table;
            flightDataGridView.Columns[0].HeaderText = "ID";
            flightDataGridView.Columns[1].HeaderText = "Date";
            flightDataGridView.Columns[2].HeaderText = "Airport Start";
            flightDataGridView.Columns[3].HeaderText = "Airport Arrive";
            flightDataGridView.Columns[4].HeaderText = "Fly Time";
            flightDataGridView.Columns[5].HeaderText = "A1 Seats";
            flightDataGridView.Columns[6].HeaderText = "A1 Reserved";
            flightDataGridView.Columns[7].HeaderText = "A2 Seat";
            flightDataGridView.Columns[8].HeaderText = "A2 Reserved";
        }

        private void FlightManagementForm_SizeChanged(object sender, EventArgs e)
        {
            flightDataGridView.Columns[0].Width = (int)(flightDataGridView.Width * idWidth) + 2;
            flightDataGridView.Columns[1].Width = (int)(flightDataGridView.Width * dateWidth);
            flightDataGridView.Columns[2].Width = (int)(flightDataGridView.Width * fromWidth);
            flightDataGridView.Columns[3].Width = (int)(flightDataGridView.Width * toWidth);
            flightDataGridView.Columns[4].Width = (int)(flightDataGridView.Width * timeWidth);
            flightDataGridView.Columns[5].Width = (int)(flightDataGridView.Width * class1seatWidth);
            flightDataGridView.Columns[6].Width = (int)(flightDataGridView.Width * class1reservedWidth);
            flightDataGridView.Columns[7].Width = (int)(flightDataGridView.Width * class2seatWidth);
            flightDataGridView.Columns[8].Width = (int)(flightDataGridView.Width * class2reservedWidth);
            search_layout.ColumnStyles[0].Width = (int)(search_layout.Width * idWidth) + 2;
            search_layout.ColumnStyles[1].Width = (int)(search_layout.Width * dateWidth);
            search_layout.ColumnStyles[2].Width = (int)(search_layout.Width * fromWidth);
            search_layout.ColumnStyles[3].Width = (int)(search_layout.Width * toWidth);
            search_layout.ColumnStyles[4].Width = (int)(search_layout.Width * timeWidth);
            search_layout.ColumnStyles[5].Width = (int)(search_layout.Width * class1seatWidth);
            search_layout.ColumnStyles[6].Width = (int)(search_layout.Width * class1reservedWidth);
            search_layout.ColumnStyles[7].Width = (int)(search_layout.Width * class2seatWidth);
            search_layout.ColumnStyles[8].Width = (int)(search_layout.Width * class2reservedWidth);
        }

        private void SearchTextBox(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in search_layout.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idSearch":
                                filter += "CONVERT(flight_id, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "dateSearch":
                                filter += "CONVERT(departure, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "fromSearch":
                                filter += "CONVERT(start, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "toSearch":
                                filter += "CONVERT(arrive, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "flyTimeSearch":
                                filter += "CONVERT(flight_time, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "class1search":
                                filter += "CONVERT(class_1_amount, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "class1reservedSearch":
                                filter += "CONVERT(class1_reserved, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "class2search":
                                filter += "CONVERT(class_2_amount, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "class2reservedSearch":
                                filter += "CONVERT(class2_reserved, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }

            if (filter != "")
            {
                filter = filter.Remove(filter.Length - 4);
                (flightDataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (flightDataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete flight will delete all tickets relate to", "Delete Flight", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "delete from flight where flight_id = " + flightDataGridView.CurrentRow.Cells[0].Value.ToString();
                sqlFunction.sqlQueryExcute(query);
                dataLoad();
            }
        }
    }
}
