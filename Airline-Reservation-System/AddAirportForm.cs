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
            airportIdTextBox.Text = sqlFunction.getSqlDataTable("select max(airport_id) from airport").Rows[0][0].ToString();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (airportNameTextBox.Text == "" || airportLocationTextBox.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            sqlFunction.sqlQueryExcute("insert into airport values (N'" + airportNameTextBox.Text + "', N'" + airportLocationTextBox.Text + "')");
            MessageBox.Show("Add Airport Success");
            this.Close();
        }

        private void AddAirportForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
