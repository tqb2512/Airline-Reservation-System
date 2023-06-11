using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class TicketManagementForm : Form
    {
        public TicketManagementForm()
        {
            InitializeComponent();
        }

        float idTicketColumn = 0.05f;
        float namePassengerColumn = 0.2f;
        float departureColumn = 0.15f;
        float departureAirportColumn = 0.2f;
        float arrivalAirportColumn = 0.2f;
        float seatNameColumn = 0.05f;
        float priceColumn = 0.1f;
        float flightIdColumn = 0.05f;


        public void dataLoad()
        {
            String query = "SELECT TICKET_ID, PASSENGER_NAME, FLIGHT.FLIGHT_ID, DEPARTURE ,a1.airport_name AS DepartureAirport, a2.airport_name AS ArrivalAirport, SEAT_NAME ,PRICE, PASSENGER.passenger_id ,PASSENGER_ID_NUMBER, PASSENGER_PHONE " +
                 "FROM TICKET JOIN PASSENGER ON TICKET.PASSENGER_ID = PASSENGER.PASSENGER_ID " +
                 "JOIN FLIGHT ON TICKET.FLIGHT_ID = FLIGHT.FLIGHT_ID " +
                 "JOIN ROUTE ON ROUTE.route_id = FLIGHT.route_id " +
                 "JOIN TICKET_PRICE ON TICKET.TICKET_PRICE_ID = TICKET_PRICE.TICKET_PRICE_ID " +
                 "JOIN SEAT_INFO ON seat_info.SEAT_ID = TICKET_PRICE.SEAT_ID " +
                 "JOIN airport a1 ON route.airport_start_id = a1.airport_id " +
                 "JOIN airport a2 ON route.airport_arrive_id = a2.airport_id ";

            DataTable table = sqlFunction.getSqlDataTable(query);
            Ticket_dataGridView.DataSource = table;
            Ticket_dataGridView.Columns["TICKET_ID"].HeaderText = "ID";
            Ticket_dataGridView.Columns["PASSENGER_NAME"].HeaderText = "Pasenger Name";
            Ticket_dataGridView.Columns["DEPARTURE"].HeaderText = "Departure";
            Ticket_dataGridView.Columns["DepartureAirport"].HeaderText = "Departure Airport";
            Ticket_dataGridView.Columns["ArrivalAirport"].HeaderText = "Arrival Airport";
            Ticket_dataGridView.Columns["SEAT_NAME"].HeaderText = "Seatname";
            Ticket_dataGridView.Columns["PRICE"].HeaderText = "Ticket Price";
            Ticket_dataGridView.Columns["FLIGHT_ID"].HeaderText = "FID";

            Ticket_dataGridView.Columns["PASSENGER_ID_NUMBER"].Visible = false;
            Ticket_dataGridView.Columns["PASSENGER_PHONE"].Visible = false;
            Ticket_dataGridView.Columns["passenger_id"].Visible = false;
        }

        private void TicketManagementForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += new System.EventHandler(this.TicketManagementForm_SizeChanged);
        }

        private void SearchTextBox(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in Search_Ticket_Information_tableLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "idSearch":
                                filter += "CONVERT(TICKET_ID, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch":
                                filter += "CONVERT(PASSENGER_NAME, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "departureSearch":
                                filter += "CONVERT(DEPARTURE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "fromSearch":
                                filter += "CONVERT(DepartureAirport, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "toSearch":
                                filter += "CONVERT(ArrivalAirport, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "classSearch":
                                filter += "CONVERT(SEAT_NAME, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "priceSearch":
                                filter += "CONVERT(PRICE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "flightIdSearch":
                                filter += "CONVERT(FLIGHT_ID, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }

            if (filter != "")
            {
                filter = filter.Remove(filter.Length - 4);
                (Ticket_dataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (Ticket_dataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void Ticket_dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
            }
        }

        private void TicketManagementForm_SizeChanged(object sender, EventArgs e)
        {
            Ticket_dataGridView.Columns["FLIGHT_ID"].Width = (int)(Ticket_dataGridView.Width * flightIdColumn);
            Ticket_dataGridView.Columns["TICKET_ID"].Width = (int)(Ticket_dataGridView.Width * idTicketColumn);
            Ticket_dataGridView.Columns["PASSENGER_NAME"].Width = (int)(Ticket_dataGridView.Width * namePassengerColumn);
            Ticket_dataGridView.Columns["DEPARTURE"].Width = (int)(Ticket_dataGridView.Width * departureColumn);
            Ticket_dataGridView.Columns["DepartureAirport"].Width = (int)(Ticket_dataGridView.Width * departureAirportColumn);
            Ticket_dataGridView.Columns["ArrivalAirport"].Width = (int)(Ticket_dataGridView.Width * arrivalAirportColumn);
            Ticket_dataGridView.Columns["SEAT_NAME"].Width = (int)(Ticket_dataGridView.Width * seatNameColumn);
            Ticket_dataGridView.Columns["PRICE"].Width = (int)(Ticket_dataGridView.Width * priceColumn) + 3;

            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[0].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * idTicketColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[1].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * namePassengerColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[2].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * flightIdColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[3].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * departureColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[4].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * departureAirportColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[5].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * arrivalAirportColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[6].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * seatNameColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[7].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * priceColumn);
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this ticket?", "Delete Ticket", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM TICKET WHERE TICKET_ID = " + Ticket_dataGridView.SelectedRows[0].Cells["TICKET_ID"].Value.ToString();
                sqlFunction.sqlQueryExcute(query);
                query = "update seat_detail set reserved_amount = reserved_amount -1 and empty_amount = empty_amount +1 where seat_name = '" + Ticket_dataGridView.SelectedRows[0].Cells["SEAT_NAME"].Value.ToString() + "' and flight_id = " + Ticket_dataGridView.SelectedRows[0].Cells["FLIGHT_ID"].Value.ToString();
                sqlFunction.sqlQueryExcute(query);
                dataLoad();
            }
        }
    }
}
