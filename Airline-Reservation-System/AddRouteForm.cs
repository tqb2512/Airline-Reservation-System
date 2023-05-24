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
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        string startId;
        string arriveId;
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DataTable airport = sqlFunction.getSqlDataTable("select * from airport");
            using (SelectForm selectForm = new SelectForm())
            {
                selectForm.loadData(airport, "Airport");
                selectForm.ShowDialog();
                startId = selectForm.selectedID;
            }
            if (startId == null)
                return;
            DataTable airportName = sqlFunction.getSqlDataTable("select airport_name from airport where airport_id = '" + startId + "'");
            airportStart.Text = airportName.Rows[0][0].ToString();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            DataTable airport = sqlFunction.getSqlDataTable("select * from airport");
            using (SelectForm selectForm = new SelectForm())
            {
                selectForm.loadData(airport, "Airport");
                selectForm.ShowDialog();
                arriveId = selectForm.selectedID;
            }
            if (arriveId == null)
                return;
            DataTable airportName = sqlFunction.getSqlDataTable("select airport_name from airport where airport_id = '" + arriveId + "'");
            airportArrive.Text = airportName.Rows[0][0].ToString();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (startId == null || arriveId == null || flyTime.Text == "" || class1Price.Text == "" || class2Price.Text == "")
            {
                MessageBox.Show("Please fill all information");
                return;
            }
            sqlFunction.sqlQueryExcute("insert into route values (" + startId + ", " + arriveId + ", " + flyTime.Text + ")");
            sqlFunction.sqlQueryExcute("insert into ticket_price values ((select max(route_id) from route), 1, " + class1Price.Text + ")");
            sqlFunction.sqlQueryExcute("insert into ticket_price values ((select max(route_id) from route), 2, " + class2Price.Text + ")");
            MessageBox.Show("Add Route Success");
            this.Close();
        }

        private void flyTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
