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

        float idColumnWidth = 0.15f;
        float nameColumnWidth = 0.3f;
        float phoneNumColumnWidth = 0.25f;
        float idNumColumnWidth = 0.3f;


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

            passengerDataGridView.Columns["passenger_id"].Width = (int)(passengerDataGridView.Width * idColumnWidth);
            passengerDataGridView.Columns["passenger_name"].Width = (int)(passengerDataGridView.Width * nameColumnWidth);
            passengerDataGridView.Columns["passenger_phone"].Width = (int)(passengerDataGridView.Width * phoneNumColumnWidth);
            passengerDataGridView.Columns["passenger_id_number"].Width = (int)(passengerDataGridView.Width * idNumColumnWidth);

            P_SearchTableLayoutPanel.ColumnStyles[0].Width = (int)(P_SearchTableLayoutPanel.Width * idColumnWidth);
            P_SearchTableLayoutPanel.ColumnStyles[1].Width = (int)(P_SearchTableLayoutPanel.Width * nameColumnWidth);
            P_SearchTableLayoutPanel.ColumnStyles[2].Width = (int)(P_SearchTableLayoutPanel.Width * phoneNumColumnWidth);
            P_SearchTableLayoutPanel.ColumnStyles[3].Width = (int)(P_SearchTableLayoutPanel.Width * idNumColumnWidth);

            P_ID_TextBox.ReadOnly = true;
            P_FullName_TextBox.ReadOnly = true;
            P_PhoneNumber_TextBox.ReadOnly = true;
            P_IDNumber_TextBox.ReadOnly = true;

            P_ID_TextBox.Enabled = false;
            P_FullName_TextBox.Enabled = false;
            P_PhoneNumber_TextBox.Enabled = false;
            P_IDNumber_TextBox.Enabled = false;
        }

        private void P_MainForm_SizeChanged(object sender, EventArgs e)
        {
            passengerDataGridView.Columns["passenger_id"].Width = (int)(passengerDataGridView.Width * idColumnWidth);
            passengerDataGridView.Columns["passenger_name"].Width = (int)(passengerDataGridView.Width * nameColumnWidth);
            passengerDataGridView.Columns["passenger_phone"].Width = (int)(passengerDataGridView.Width * phoneNumColumnWidth);
            passengerDataGridView.Columns["passenger_id_number"].Width = (int)(passengerDataGridView.Width * idNumColumnWidth);

            P_SearchTableLayoutPanel.ColumnStyles[0].Width = (int)(P_SearchTableLayoutPanel.Width * idColumnWidth);
            P_SearchTableLayoutPanel.ColumnStyles[1].Width = (int)(P_SearchTableLayoutPanel.Width * nameColumnWidth);
            P_SearchTableLayoutPanel.ColumnStyles[2].Width = (int)(P_SearchTableLayoutPanel.Width * phoneNumColumnWidth);
            P_SearchTableLayoutPanel.ColumnStyles[3].Width = (int)(P_SearchTableLayoutPanel.Width * idNumColumnWidth);
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in P_SearchTableLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "passengerIDSearchTextBox":
                                filter += "CONVERT(passenger_id, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearchTextBox":
                                filter += "CONVERT(passenger_name, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "phoneNumSearchTextBox":
                                filter += "CONVERT(passenger_phone, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "idNumSearchTextBox":
                                filter += "CONVERT(passenger_id_number, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }
            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (passengerDataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (passengerDataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
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
