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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void addToTabControl(Form form, string tabName)
        {

            Krypton.Navigator.KryptonPage tabPage = new Krypton.Navigator.KryptonPage();
            tabPage.Text = tabName;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            tabPage.Controls.Add(form);
            mainTabControl.Pages.Add(tabPage);
            form.Show();
            mainTabControl.SelectedPage = tabPage;
        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new FlightManagementForm(), "Flight");
        }

        private void airportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new AirportManagementForm(), "Airport");
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new TicketManagementForm(), "Ticket");
        }

        private void passengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new PassengerManagementForm(), "Passenger");
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToTabControl(new RouteManagementForm(), "Route");
        }
    }
}
