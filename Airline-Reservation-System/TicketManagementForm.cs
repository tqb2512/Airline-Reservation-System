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

        float idTicketColumn = 0.125f;
        float namePassengerColumn = 0.125f;
        float departureColumn = 0.125f;
        float departureAirportColumn = 0.125f;
        float arrivalAirportColumn = 0.125f;
        float emptyAmountColumn = 0.125f;
        float seatNameColumn = 0.125f;
        float priceColumn = 0.125f;


        public void dataLoad()
        {
            String query = "SELECT TICKET_ID, PASSENGER_NAME, DEPARTURE ,SEAT_NAME,PRICE, PASSENGER.passenger_id, a1.airport_name AS DepartureAirport, a2.airport_name AS ArrivalAirport,PASSENGER_ID_NUMBER, PASSENGER_PHONE, FLIGHT.FLIGHT_ID  " +
                 "FROM TICKET JOIN PASSENGER ON TICKET.PASSENGER_ID = PASSENGER.PASSENGER_ID " +
                 "JOIN FLIGHT ON TICKET.FLIGHT_ID = FLIGHT.FLIGHT_ID " +
                 "JOIN ROUTE ON ROUTE.route_id = FLIGHT.route_id " +
                 "JOIN TICKET_PRICE ON TICKET.TICKET_PRICE_ID = TICKET_PRICE.TICKET_PRICE_ID " +
                 "JOIN SEAT_INFO ON seat_info.SEAT_ID = TICKET_PRICE.SEAT_ID " +
                 "JOIN airport a1 ON route.airport_start_id = a1.airport_id " +
                 "JOIN airport a2 ON route.airport_arrive_id = a2.airport_id ";

            DataTable table = sqlFunction.getSqlDataTable(query);
            Ticket_dataGridView.DataSource = table;
            Ticket_dataGridView.Columns["TICKET_ID"].HeaderText = "Mã vé";
            Ticket_dataGridView.Columns["PASSENGER_NAME"].HeaderText = "Tên hành khách";
            Ticket_dataGridView.Columns["DEPARTURE"].HeaderText = "Ngày khởi hành";
            Ticket_dataGridView.Columns["DepartureAirport"].HeaderText = "Điểm khởi hành";
            Ticket_dataGridView.Columns["ArrivalAirport"].HeaderText = "Điểm đến";
            Ticket_dataGridView.Columns["SEAT_NAME"].HeaderText = "Tên ghế";
            Ticket_dataGridView.Columns["PRICE"].HeaderText = "Giá vé";

            Ticket_dataGridView.Columns["PASSENGER_ID_NUMBER"].Visible = false;
            Ticket_dataGridView.Columns["PASSENGER_PHONE"].Visible = false;
            Ticket_dataGridView.Columns["FLIGHT_ID"].Visible = false;
            Ticket_dataGridView.Columns["passenger_id"].Visible = false;


            Ticket_dataGridView.Columns["TICKET_ID"].Width = (int)(Ticket_dataGridView.Width * idTicketColumn);
            Ticket_dataGridView.Columns["PASSENGER_NAME"].Width = (int)(Ticket_dataGridView.Width * namePassengerColumn);
            Ticket_dataGridView.Columns["DEPARTURE"].Width = (int)(Ticket_dataGridView.Width * departureColumn);
            Ticket_dataGridView.Columns["DepartureAirport"].Width = (int)(Ticket_dataGridView.Width * departureAirportColumn);
            Ticket_dataGridView.Columns["ArrivalAirport"].Width = (int)(Ticket_dataGridView.Width * arrivalAirportColumn);

            Ticket_dataGridView.Columns["SEAT_NAME"].Width = (int)(Ticket_dataGridView.Width * seatNameColumn);
            Ticket_dataGridView.Columns["PRICE"].Width = (int)(Ticket_dataGridView.Width * priceColumn);

            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[0].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * idTicketColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[1].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * namePassengerColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[2].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * departureColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[3].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * departureAirportColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[4].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * arrivalAirportColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[5].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * seatNameColumn);
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles[6].Width = (int)(Search_Ticket_Information_tableLayoutPanel.Width * priceColumn);

            Ticket_dataGridView.RowHeadersVisible = false;

        }

        private void TicketManagementForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            //this.SizeChanged += new System.EventHandler(this.TicketManagementForm_SizeChanged);
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
                            case "Search_Ticket_ID_textBox":
                                filter += "CONVERT(TICKET_ID, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Passenger_Name_textBox":
                                filter += "CONVERT(PASSENGER_NAME, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Departure_textBox":
                                filter += "CONVERT(DEPARTURE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_DepartureAP_textBox":
                                filter += "CONVERT(DepartureAirport, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_ArrivalAP_textBox":
                                filter += "CONVERT(ArrivalAirport, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_SeatName_textBox":
                                filter += "CONVERT(SEAT_NAME, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Price_textBox":
                                filter += "CONVERT(PRICE, 'System.String') LIKE '%" + control.Text + "%' AND ";
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

        private void Ticket_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Ticket_dataGridView.Columns["TICKET_ID"].HeaderText = "Ticket ID";
                Ticket_dataGridView.Columns["PASSENGER_NAME"].HeaderText = "Passenger' Name";
                Ticket_dataGridView.Columns["DEPARTURE"].HeaderText = "Departure";
                Ticket_dataGridView.Columns["DepartureAirport"].HeaderText = "Departure Airport";
                Ticket_dataGridView.Columns["ArrivalAirport"].HeaderText = "Arrival Airport";
                Ticket_dataGridView.Columns["SEAT_NAME"].HeaderText = "Seat Name";
                Ticket_dataGridView.Columns["PRICE"].HeaderText = "Ticket Price";

                Ticket_dataGridView.Columns["PASSENGER_ID_NUMBER"].Visible = false;
                Ticket_dataGridView.Columns["PASSENGER_PHONE"].Visible = false;
                Ticket_dataGridView.Columns["FLIGHT_ID"].Visible = false;
                Ticket_dataGridView.Columns["passenger_id"].Visible = false;

                Ticket_ID_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Passenger_Name_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Flight_Departure_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                Flight_DepartureAP_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                Flight_ArrivalAP_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                Seat_Name_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Ticket_Price_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Passenger_ID_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                Passenger_Phone_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                Passenger_IDnumber_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                Flight_ID_textBox.Text = Ticket_dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

                Ticket_ID_textBox.ReadOnly = true;
                Passenger_Name_textBox.ReadOnly = true;
                Flight_Departure_textBox.ReadOnly = true;
                Flight_DepartureAP_textBox.ReadOnly = true;
                Flight_ArrivalAP_textBox.ReadOnly = true;

                Seat_Name_textBox.ReadOnly = true;
                Ticket_Price_textBox.ReadOnly = true;
                Passenger_Name_textBox.ReadOnly = true;
                Passenger_Phone_textBox.ReadOnly = true;
                Passenger_IDnumber_textBox.ReadOnly = true;
                Flight_ID_textBox.ReadOnly = true;
                Passenger_ID_textBox.ReadOnly = true;

                Ticket_ID_textBox.Enabled = false;
                Passenger_Name_textBox.Enabled = false;
                Flight_Departure_textBox.Enabled = false;
                Flight_DepartureAP_textBox.Enabled = false;
                Flight_ArrivalAP_textBox.Enabled = false;

                Seat_Name_textBox.Enabled = false;
                Ticket_Price_textBox.Enabled = false;
                Passenger_Name_textBox.Enabled = false;
                Passenger_Phone_textBox.Enabled = false;
                Passenger_IDnumber_textBox.Enabled = false;
                Flight_ID_textBox.Enabled = false;
                Passenger_ID_textBox.Enabled = false;
            }
        }

        private void Ticket_dataGridView_SizeChanged(object sender, EventArgs e)
        {
            Ticket_dataGridView.Columns["TICKET_ID"].Width = (int)(Ticket_dataGridView.Width * idTicketColumn);
            Ticket_dataGridView.Columns["PASSENGER_NAME"].Width = (int)(Ticket_dataGridView.Width * namePassengerColumn);
            Ticket_dataGridView.Columns["DEPARTURE"].Width = (int)(Ticket_dataGridView.Width * departureColumn);
            Ticket_dataGridView.Columns["DepartureAirport"].Width = (int)(Ticket_dataGridView.Width * departureAirportColumn);
            Ticket_dataGridView.Columns["ArrivalAirport"].Width = (int)(Ticket_dataGridView.Width * arrivalAirportColumn);
            Ticket_dataGridView.Columns["SEAT_NAME"].Width = (int)(Ticket_dataGridView.Width * seatNameColumn);
            Ticket_dataGridView.Columns["PRICE"].Width = (int)(Ticket_dataGridView.Width * priceColumn);
        }
    }
}
