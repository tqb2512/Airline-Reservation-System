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
    public partial class AddAirportForm : Form
    {
        public AddAirportForm()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Add flight
            try
            {
                string query = "INSERT INTO Airport (airport_name, airport_location) VALUES ('" + airportNameTextBox.Text + "', '" + airportLocationTextBox.Text + "')";
                sqlFunction.sqlQueryExcute(query);
                MessageBox.Show("Airport added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAirportForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
