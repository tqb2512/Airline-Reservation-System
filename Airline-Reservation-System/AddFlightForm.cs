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
    public partial class AddFlightForm : Form
    {
        public AddFlightForm()
        {
            InitializeComponent();
        }

        private void selectRouteButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Route";
            DataTable route = sqlFunction.getSqlDataTable(query);
            using (SelectForm selectForm = new SelectForm()) 
            {
                selectForm.loadData(route);
                selectForm.ShowDialog();
                routeTextBox.Text = selectForm.selectedID;
            }
        }
    }
}
