﻿using System;
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
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void R_Submit_Button_Click(object sender, EventArgs e)
        {
            string tmpDeparture = "'" + R_Departure_TextBox.Text + "'";
            string tmpArrival = "'" + R_Arrival_TextBox.Text + "'";
            string tmpFlightTime = "'" + R_FlightTime_TextBox.Text + "'";

            string query = "INSERT INTO passenger VALUES(" + tmpDeparture + "," + tmpArrival + "," + tmpFlightTime + ")";

            sqlFunction.sqlQueryExcute(query);

            MessageBox.Show("Successful !!", "Notification", MessageBoxButtons.OK);

            this.Close();
        }
    }
}
