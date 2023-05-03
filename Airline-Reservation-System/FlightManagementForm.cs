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
        public FlightManagementForm()
        {
            InitializeComponent();
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            AddFlightForm addFlightForm = new AddFlightForm();
            addFlightForm.ShowDialog();
            dataLoad(); 
        }

        private void dataLoad()
        {
            string query = "select * from Flight";
            DataTable table = sqlFunction.getSqlDataTable(query);
            flightDataGridView.DataSource = table;
        }
    }
}
