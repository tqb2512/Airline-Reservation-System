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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        double class1Price = 0;
        double class2Price = 0;
        int newPassenger = 0;

        private void selectPassengerButton_Click(object sender, EventArgs e)
        {
            string passengerId;
            DataTable passenger = sqlFunction.getSqlDataTable("SELECT * FROM PASSENGER");
            using (SelectForm selectForm= new SelectForm())
            {
                selectForm.loadData(passenger, "Passenger");
                selectForm.ShowDialog();
                passengerId = selectForm.selectedID;
            }
            if (passengerId != null)
            {
                DataTable passengerInfo = sqlFunction.getSqlDataTable("SELECT * FROM PASSENGER WHERE PASSENGER_ID = '" + passengerId + "'");
                passengerID.Text = passengerInfo.Rows[0]["passenger_id"].ToString();
                passengerName.Text = passengerInfo.Rows[0]["passenger_name"].ToString();
                passengerPhoneNumber.Text = passengerInfo.Rows[0]["passenger_phone"].ToString();
                passengerIDNumber.Text = passengerInfo.Rows[0]["passenger_id_number"].ToString();
                return;
            }
        }

        private void newPassengerButton_Click(object sender, EventArgs e)
        {
            newPassenger = 1;
            passengerID.Text = "";
            passengerName.Text = "";
            passengerPhoneNumber.Text = "";
            passengerIDNumber.Text = "";
            passengerName.Enabled = true;
            passengerPhoneNumber.Enabled = true;
            passengerIDNumber.Enabled = true;
        }

        private void selectFlightButton_Click(object sender, EventArgs e)
        {
            string FlightId;
            DataTable flight = sqlFunction.getSqlDataTable("select c.flight_id, start, arrive, departure, flight_time, class1_empty, empty_amount as class2_empty from (select b.flight_id, route_id, departure, start, arrive, flight_time, empty_amount as class1_empty, reserved_amount as class1_reserved from (select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time from (select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id) as a inner join airport on airport_arrive_id = airport_id) as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1) as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2");
            using (SelectForm selectForm = new SelectForm())
            {
                selectForm.loadData(flight, "Flight");
                selectForm.ShowDialog();
                FlightId = selectForm.selectedID;
            }
            if (FlightId != null)
            {
                DataTable flightInfo = sqlFunction.getSqlDataTable("select c.flight_id, departure, start, arrive, flight_time, class1_empty, class1_reserved, empty_amount as class2_empty, reserved_amount as class2_reserved from (select b.flight_id, route_id, departure, start, arrive, flight_time, empty_amount as class1_empty, reserved_amount as class1_reserved from (select flight_id, route_id, departure, airport_location as start, airport_location as arrive, flight_time from (select flight_id, flight.route_id, departure, airport_location as start, airport_arrive_id, flight_time from flight inner join route on flight.route_id = route.route_id inner join airport on airport_start_id = airport_id) as a inner join airport on airport_arrive_id = airport_id) as b inner join seat_detail on b.flight_id = seat_detail.flight_id where seat_id = 1) as c inner join seat_detail on c.flight_id = seat_detail.flight_id where seat_id = 2 and c.flight_id = '" + FlightId + "'");
                flightID.Text = flightInfo.Rows[0]["flight_id"].ToString();
                flightStart.Text = flightInfo.Rows[0]["start"].ToString();
                flightDate.Text = flightInfo.Rows[0]["departure"].ToString();
                flightArrive.Text = flightInfo.Rows[0]["arrive"].ToString();
                DataTable price = sqlFunction.getSqlDataTable("select * from (select price as class1price from flight inner join ticket_price on flight.route_id = ticket_price.route_id where flight.flight_id = " + FlightId + " and seat_id = 1) as a inner join (select price as class2price from flight inner join ticket_price on flight.route_id = ticket_price.route_id where flight.flight_id = " + FlightId + " and seat_id = 2) as b on 1 = 1");
                class1Price = Convert.ToDouble(price.Rows[0]["class1price"]);
                class2Price = Convert.ToDouble(price.Rows[0]["class2price"]);
                DataTable StopOver = sqlFunction.getSqlDataTable("select airport_name, airport_location from (select flight.flight_id, stopover from flight inner join flight_detail on flight.flight_id = flight_detail.flight_id) as a inner join airport on a.stopover = airport_id where flight_id = '" + FlightId + "'");
                if (StopOver.Rows.Count != 0)
                {
                    stopOver.DataSource = StopOver;
                }
                return;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (passengerID.Text == "")
            {
                MessageBox.Show("Please select passenger");
                return;
            }
            if (flightID.Text == "")
            {
                MessageBox.Show("Please select flight");
                return;
            }
            if (class1amount.Text == "" && class2amount.Text == "" || class1amount.Text == "0" && class2amount.Text == "0")
            {
                MessageBox.Show("Please select ticket amount");
                return;
            }
            if (newPassenger == 1)
            {
                sqlFunction.sqlQueryExcute("insert into passenger (passenger_name, passenger_phone, passenger_id_number) values ('" + passengerName.Text + "', '" + passengerPhoneNumber.Text + "', '" + passengerIDNumber.Text + "')");
                for (int i = 0; i < Convert.ToInt32(class1amount.Text); i++)
                {
                    sqlFunction.sqlQueryExcute("insert into ticket (passenger_id, flight_id, ticket_price_id) values ((select max(passenger_id) from passenger), '" + flightID.Text + "', 1)");
                }
                for (int i = 0; i < Convert.ToInt32(class2amount.Text); i++)
                {
                    sqlFunction.sqlQueryExcute("insert into ticket (passenger_id, flight_id, ticket_price_id) values ((select max(passenger_id) from passenger), '" + flightID.Text + "', 2)");
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(class1amount.Text); i++)
                {
                    sqlFunction.sqlQueryExcute("insert into ticket (passenger_id, flight_id, ticket_price_id) values ('" + passengerID.Text + "', '" + flightID.Text + "', 1)");
                }
                for (int i = 0; i < Convert.ToInt32(class2amount.Text); i++)
                {
                    sqlFunction.sqlQueryExcute("insert into ticket (passenger_id, flight_id, ticket_price_id) values ('" + passengerID.Text + "', '" + flightID.Text + "', 2)");
                }
            }
            this.Close();
            MessageBox.Show("Booking Success");
        }

        private void class1amount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void class1amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;                
            }
            decimal total = 0;
            if (class1amount.Text != "")
            {
                total += Convert.ToInt32(class1amount.Text) * Convert.ToDecimal(class1Price);
            }
            if (class2amount.Text != "")
            {
                total += Convert.ToInt32(class2amount.Text) * Convert.ToDecimal(class2Price);
            }
            priceBox.Text = total.ToString();
            priceBox.Text = string.Format("{0:#,##}", decimal.Parse(priceBox.Text));
        }
    }
}
