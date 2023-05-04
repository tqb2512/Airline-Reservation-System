using Airline_Reservation_System.Classes;
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

        Passenger passenger = new Passenger();

        private void dataLoad()
        {
            string query = "select * from Passenger";
            DataTable table = sqlFunction.getSqlDataTable(query);
            passengerDataGridView.DataSource = table;

            passengerDataGridView.Columns["passenger_id"].HeaderText = "Passenger ID";
            passengerDataGridView.Columns["passenger_name"].HeaderText = "Name";
            passengerDataGridView.Columns["passenger_phone"].HeaderText = "Phone Number";
            passengerDataGridView.Columns["passenger_id_number"].HeaderText = "ID Number";

            P_ID_TextBox.ReadOnly = true;
            P_FullName_TextBox.ReadOnly = true;
            P_PhoneNumber_TextBox.ReadOnly = true;
            P_IDNumber_TextBox.ReadOnly = true;

            P_ID_TextBox.Enabled = false;
            P_FullName_TextBox.Enabled = false;
            P_PhoneNumber_TextBox.Enabled = false;
            P_IDNumber_TextBox.Enabled = false;
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

        private void passengerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                P_editButton.Text = "Edit";
                passenger = Functions.PassengerFunction.getPassengerDetail(Convert.ToInt32(passengerDataGridView.Rows[e.RowIndex].Cells["passenger_id"].Value.ToString()));
                
                P_ID_TextBox.Text = passenger.ID.ToString();
                P_FullName_TextBox.Text = passenger.FullName.ToString();
                P_PhoneNumber_TextBox.Text = passenger.PhoneNumber.ToString();
                P_IDNumber_TextBox.Text = passenger.IDNumber.ToString();

                P_ID_TextBox.ReadOnly = true;
                P_FullName_TextBox.ReadOnly = true;
                P_PhoneNumber_TextBox.ReadOnly = true;
                P_IDNumber_TextBox.ReadOnly = true;

                P_ID_TextBox.Enabled = false;
                P_FullName_TextBox.Enabled = false;
                P_PhoneNumber_TextBox.Enabled = false;
                P_IDNumber_TextBox.Enabled = false;
            }
        }

        private void P_deleteButton_Click(object sender, EventArgs e)
        {
            if (P_ID_TextBox.Text != "" || P_ID_TextBox.Text != Convert.ToString(Functions.PassengerFunction.getMaxID()))
            {
                if (Functions.PassengerFunction.deletePassenger(Convert.ToInt32(P_ID_TextBox.Text)) == true)
                {
                    MessageBox.Show("Passenger Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    P_ID_TextBox.Text = "";
                    P_FullName_TextBox.Text = "";
                    P_PhoneNumber_TextBox.Text = "";
                    P_IDNumber_TextBox.Text = "";

                    dataLoad();
                }
                else
                {
                    MessageBox.Show("Deleting Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
