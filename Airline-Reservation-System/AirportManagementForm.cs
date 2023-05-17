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

            Airport_ID_textBox.Enabled = true;
            Airport_Name_textBox.Enabled = true;
            Airport_Location_textBox.Enabled = true;

            Airport_ID_textBox.ReadOnly = false;
            Airport_Name_textBox.ReadOnly = false;
            Airport_Location_textBox.ReadOnly = false;
        }

        private void dataLoad()
        {
            //Airport and Route
            //String query = "Select * from airport join route on airport.airport_id = route.airport_start_id";
            String query = "Select * from airport";
            DataTable table = sqlFunction.getSqlDataTable(query);
            Airport_dataGridView.DataSource = table;
            Airport_dataGridView.Columns["airport_id"].HeaderText = "Mã sân bay";
            Airport_dataGridView.Columns["airport_name"].HeaderText = "Tên sân bay";
            Airport_dataGridView.Columns["airport_location"].HeaderText = "Địa điểm";

            Airport_dataGridView.Columns[0].Width = this.Width / 3;
            Airport_dataGridView.Columns[1].Width = this.Width / 3;
            Airport_dataGridView.Columns[2].Width = this.Width / 3;

            Search_Airport_ID_textBox.Width = this.Width / 3;
            Search_Airport_Name_textBox.Width = this.Width / 3;
            Search_Airport_Location_textBox.Width = this.Width / 3;

            Airport_dataGridView.RowHeadersVisible = false;

            Airport_dataGridView.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
            Airport_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowDetailAirport(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Airport_ID_textBox.Text = Airport_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Airport_Name_textBox.Text = Airport_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Airport_Location_textBox.Text = Airport_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                Airport_ID_textBox.Enabled = false;
                Airport_Name_textBox.Enabled = false;
                Airport_Location_textBox.Enabled = false;

                Airport_ID_textBox.ReadOnly = true;
                Airport_Name_textBox.ReadOnly = true;
                Airport_Location_textBox.ReadOnly = true;

            }
        }



        private void Airport_Edit_button_Click(object sender, EventArgs e)
        {
            if (Airport_Edit_button.Text == "Sửa")
            {
                Airport_ID_textBox.Enabled = true;
                Airport_Name_textBox.Enabled = true;
                Airport_Location_textBox.Enabled = true;
                Airport_ID_textBox.ReadOnly = false;
                Airport_Name_textBox.ReadOnly = false;
                Airport_Location_textBox.ReadOnly = false;
                Airport_Edit_button.Text = "Lưu";
            }
            else if (Airport_Edit_button.Text == "Lưu")
            {
                try
                {
                    String query = "update airport set airport_name = '" + Airport_Name_textBox.Text + "', airport_location = '" + Airport_Location_textBox.Text + "' where airport_id = '" + Airport_ID_textBox.Text + "'";
                    sqlFunction sqlFunction = new sqlFunction();
                    sqlFunction.sqlQueryExcute(query);
                    dataLoad();
                    Airport_Edit_button.Text = "Sửa";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void Airport_Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "delete from airport where airport_id = '" + Airport_ID_textBox.Text + "'";
                sqlFunction sqlFunction = new sqlFunction();
                sqlFunction.sqlQueryExcute(query);
                dataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddAirportForm form = new AddAirportForm();
            form.ShowDialog();
            dataLoad();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
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
                filter = filter.Substring(0, filter.Length - 3);
                (Airport_dataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (Airport_dataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void Airport_ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
