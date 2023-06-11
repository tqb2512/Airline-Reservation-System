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
    public partial class AirportManagementForm : Form
    {
        public AirportManagementForm()
        {
            InitializeComponent();
        }

        private void AddAirportButton_Click(object sender, EventArgs e)
        {
            AddAirportForm form = new AddAirportForm();
            form.ShowDialog();
            dataLoad();
        }

        private void AirportManagementForm_Load(object sender, EventArgs e)
        {
            dataLoad();
            this.SizeChanged += AirportManagementForm_SizeChanged;
        }

        private void dataLoad()
        {
            String query = "Select * from airport";
            DataTable table = sqlFunction.getSqlDataTable(query);
            Airport_dataGridView.DataSource = table;
            Airport_dataGridView.Columns["airport_id"].HeaderText = "Mã sân bay";
            Airport_dataGridView.Columns["airport_name"].HeaderText = "Tên sân bay";
            Airport_dataGridView.Columns["airport_location"].HeaderText = "Địa điểm";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddAirportForm form = new AddAirportForm();
            form.ShowDialog();
        }

        private void Search_Airport_Location_textBox_TextChanged(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in Search_tableLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "Search_Airport_ID_textBox":
                                filter += "CONVERT(airport_id, System.String) LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Airport_Name_textBox":
                                filter += "CONVERT(airport_name, 'System.String') like '%" + control.Text + "%' AND ";
                                break;
                            case "Search_Airport_Location_textBox":
                                filter += "CONVERT(airport_location, 'System.String') like '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }

            if (filter != "")
            {
                filter = filter.Substring(0, filter.Length - 4);
                (Airport_dataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (Airport_dataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void AirportManagementForm_SizeChanged(object sender, EventArgs e)
        {
            Airport_dataGridView.Columns[0].Width = (int)Airport_dataGridView.Width / 3;
            Airport_dataGridView.Columns[1].Width = (int)Airport_dataGridView.Width / 3;
            Airport_dataGridView.Columns[2].Width = (int)Airport_dataGridView.Width / 3;

            Search_tableLayoutPanel.ColumnStyles[0].Width = (int)Search_tableLayoutPanel.Width / 3;
            Search_tableLayoutPanel.ColumnStyles[1].Width = (int)Search_tableLayoutPanel.Width / 3;
            Search_tableLayoutPanel.ColumnStyles[2].Width = (int)Search_tableLayoutPanel.Width / 3;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            String query = "Select * from route where airport_start_id = " + Airport_dataGridView.CurrentRow.Cells[0].Value.ToString() + " OR airport_arrive_id = " + Airport_dataGridView.CurrentRow.Cells[0].Value.ToString();
            if (sqlFunction.getSqlDataTable(query).Rows.Count > 0)
            {
                MessageBox.Show("Can't delete because exist route relate to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "Delete from airport where airport_id = " + Airport_dataGridView.CurrentRow.Cells[0].Value.ToString();
                sqlFunction.sqlQueryExcute(query);
                dataLoad();
            }
        }
    }
}
