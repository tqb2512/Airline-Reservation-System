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
    public partial class TicketManagementForm : Form
    {
        public TicketManagementForm()
        {
            InitializeComponent();
        }

        float rowWidth = 0.0083f;

        private void TicketManagementForm_Load(object sender, EventArgs e)
        {
            String query = "SELECT TICKET_ID, flight.FLIGHT_ID, passenger.PASSENGER_ID, PASSENGER_NAME, PASSENGER_PHONE, PASSENGER_ID_NUMBER, flight.ROUTE_ID, DEPARTURE, CLASS_1_AMOUNT, CLASS_2_AMOUNT, SEAT_NAME,PRICE  FROM TICKET JOIN PASSENGER ON TICKET.PASSENGER_ID = PASSENGER.PASSENGER_ID JOIN FLIGHT ON TICKET.FLIGHT_ID = FLIGHT.FLIGHT_ID JOIN TICKET_PRICE ON TICKET.TICKET_PRICE_ID = TICKET_PRICE.TICKET_PRICE_ID JOIN SEAT_INFO ON seat_info.SEAT_ID = TICKET_PRICE.SEAT_ID";
            //String query = "SELECT TICKET_ID, FLIGHT_ID, TICKET_PRICE_ID, PASSENGER.PASSENGER_ID, PASSENGER_NAME FROM TICKET JOIN PASSENGER ON TICKET.PASSENGER_ID = PASSENGER.PASSENGER_ID";
            try
            {
                DataTable table = sqlFunction.getSqlDataTable(query);
                kryptonDataGridView1.DataSource = table;
                kryptonDataGridView1.Columns["TICKET_ID"].HeaderText = "Mã vé";
                kryptonDataGridView1.Columns["FLIGHT_ID"].HeaderText = "Mã chuyến bay";
                kryptonDataGridView1.Columns["PASSENGER_ID"].HeaderText = "Mã hành khách";
                kryptonDataGridView1.Columns["PASSENGER_NAME"].HeaderText = "Tên hành khách";
                kryptonDataGridView1.Columns["PASSENGER_PHONE"].HeaderText = "Số điện thoại";
                kryptonDataGridView1.Columns["PASSENGER_ID_NUMBER"].HeaderText = "Số CMND";
                kryptonDataGridView1.Columns["ROUTE_ID"].HeaderText = "Mã tuyến bay";
                kryptonDataGridView1.Columns["DEPARTURE"].HeaderText = "Ngày khởi hành";
                kryptonDataGridView1.Columns["CLASS_1_AMOUNT"].HeaderText = "Số vé hạng 1";
                kryptonDataGridView1.Columns["CLASS_2_AMOUNT"].HeaderText = "Số vé hạng 2";
                kryptonDataGridView1.Columns["SEAT_NAME"].HeaderText = "Tên ghế";
                kryptonDataGridView1.Columns["PRICE"].HeaderText = "Giá vé";

                kryptonDataGridView1.Columns["TICKET_ID"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["FLIGHT_ID"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["PASSENGER_ID"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["PASSENGER_NAME"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["PASSENGER_PHONE"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["PASSENGER_ID_NUMBER"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["ROUTE_ID"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["DEPARTURE"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["CLASS_1_AMOUNT"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["CLASS_2_AMOUNT"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["SEAT_NAME"].Width = this.Width / 12;
                kryptonDataGridView1.Columns["PRICE"].Width = this.Width / 12;

                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[0].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[1].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[2].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[3].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[4].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[5].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[6].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[7].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[8].Width = (int)this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[9].Width = this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[10].Width = this.Width * 0.0833f;
                Search_Ticket_Information_tableLayoutPanel.ColumnStyles[11].Width = this.Width * 0.0833f;

                kryptonDataGridView1.RowHeadersVisible = false;
                kryptonDataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
                kryptonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void ShowDetailTicketInformation(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Ticket_ID_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Flight_ID_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Passenger_ID_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Passenger_Name_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Passenger_Phone_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Passenger_IDnumber_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Flight_Route_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Flight_Departure_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Flight_class1_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                Flight_class2_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                Seat_Name_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                Ticket_Price_textBox.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

                Ticket_ID_textBox.Enabled = false;
                Flight_ID_textBox.Enabled = false;
                Passenger_ID_textBox.Enabled = false;
                Passenger_Name_textBox.Enabled = false;
                Passenger_Phone_textBox.Enabled = false;
                Passenger_IDnumber_textBox.Enabled = false;
                Flight_Route_textBox.Enabled = false;
                Flight_Departure_textBox.Enabled = false;
                Flight_class1_textBox.Enabled = false;
                Flight_class2_textBox.Enabled = false;
                Seat_Name_textBox.Enabled = false;
                Ticket_Price_textBox.Enabled = false;

                Ticket_ID_textBox.ReadOnly = true;
                Flight_ID_textBox.ReadOnly = true;
                Passenger_ID_textBox.ReadOnly = true;
                Passenger_Name_textBox.ReadOnly = true;
                Passenger_Phone_textBox.ReadOnly = true;
                Passenger_IDnumber_textBox.ReadOnly = true;
                Flight_Route_textBox.ReadOnly = true;
                Flight_Departure_textBox.ReadOnly = true;
                Flight_class1_textBox.ReadOnly = true;
                Flight_class2_textBox.ReadOnly = true;
                Seat_Name_textBox.ReadOnly = true;
                Ticket_Price_textBox.ReadOnly = true;
            }
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
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
                            case "Search_Flight_ID_textBox":
                                filter += "CONVERT(FLIGHT_ID, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Passenger_ID_textBox":
                                filter += "CONVERT(PASSENGER_ID, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Passenger_Name_textBox":
                                filter += "CONVERT(PASSENGER_NAME, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Passenger_Phone_textBox":
                                filter += "CONVERT(PASSENGER_PHONE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Passenger_IDnumber_textBox":
                                filter += "CONVERT(PASSENGER_IDNUMBER, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Flight_Route_textBox":
                                filter += "CONVERT(FLIGHT_ROUTE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Flight_Departure_textBox":
                                filter += "CONVERT(FLIGHT_DEPARTURE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Flight_class1_textBox":
                                filter += "CONVERT(FLIGHT_CLASS1, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "":
                                filter += "CONVERT(FLIGHT_CLASS2, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Seat_Name_textBox":
                                filter += "CONVERT(SEAT_NAME, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Ticket_Price_textBox":
                                filter += "CONVERT(TICKET_PRICE, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }

            if (filter != "")
            {
                filter = filter.Remove(filter.Length - 4);
                (kryptonDataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (kryptonDataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }
    }
}
