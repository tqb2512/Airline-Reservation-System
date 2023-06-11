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
            loadData();
            this.SizeChanged += new EventHandler(PassengerManagementForm_SizeChanged);
        }

        float idWidth = 0.15f;
        float nameWidth = 0.35f;
        float phoneNumberWidth = 0.25f;
        float idNumberWidth = 0.25f;

        private void loadData()
        {
            DataTable dt = sqlFunction.getSqlDataTable("select * from passenger");
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Columns[0].HeaderText = "ID";
            kryptonDataGridView1.Columns[1].HeaderText = "Name";
            kryptonDataGridView1.Columns[2].HeaderText = "Phone Number";
            kryptonDataGridView1.Columns[3].HeaderText = "ID Number";
        }

        private void PassengerManagementForm_SizeChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * idWidth);
            kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * nameWidth);
            kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * phoneNumberWidth);
            kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * idNumberWidth);
            search_layout.ColumnStyles[0].Width = (int)(search_layout.Width * idWidth);
            search_layout.ColumnStyles[1].Width = (int)(search_layout.Width * nameWidth);
            search_layout.ColumnStyles[2].Width = (int)(search_layout.Width * phoneNumberWidth);
            search_layout.ColumnStyles[3].Width = (int)(search_layout.Width * idNumberWidth);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            AddPassengerForm addPassengerForm = new AddPassengerForm();
            addPassengerForm.ShowDialog();
            loadData();
        }

        private void SearchTextBox(object sender, EventArgs e)
        {
            string filter = "";
            foreach (Control control in search_layout.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text != "")
                    {
                        switch (control.Name)
                        {
                            case "id":
                                filter += "CONVERT(passenger_id, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "name":
                                filter += "CONVERT(passenger_name, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "phoneNumber":
                                filter += "CONVERT(passenger_phone, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "idNumber":
                                filter += "CONVERT(passenger_id_number, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                        }
                    }
                }
            }

            if (filter != "")
            {
                filter = filter.Remove(filter.Length - 4);
                (kryptonDataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            else
            {
                (kryptonDataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete passenger will delete all tickets relate to", "Delete Passenger", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = kryptonDataGridView1.SelectedRows[0].Index;
                string id = kryptonDataGridView1.Rows[index].Cells[0].Value.ToString();
                sqlFunction.sqlQueryExcute("delete from passenger where passenger_id = " + id);
                loadData();
            }
        }
    }
}
