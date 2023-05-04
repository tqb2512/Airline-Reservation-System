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
    public partial class PassengerManagementForm : Form
    {
        public PassengerManagementForm()
        {
            InitializeComponent();
            dataLoad();
        }

        private void dataLoad()
        {
            string query = "select * from Passenger";
            DataTable table = sqlFunction.getSqlDataTable(query);
            passengerDataGridView.DataSource = table;

            passengerDataGridView.Columns["passenger_id"].HeaderText = "Passenger ID";
            passengerDataGridView.Columns["passenger_name"].HeaderText = "Name";
            passengerDataGridView.Columns["passenger_phone"].HeaderText = "Phone Number";
            passengerDataGridView.Columns["passenger_id_number"].HeaderText = "ID Number";
        }

        private void addPassengerButton_Click(object sender, EventArgs e)
        {
            AddPassengerForm addPassengerForm = new AddPassengerForm();
            addPassengerForm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}
