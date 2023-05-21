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
    public partial class SelectForm : Form
    {
        struct Passenger
        {
            public double idWidth;
            public double nameWidth;
            public double phoneWidth;
            public double idNumberWidth;

            public Passenger()
            {
                idWidth = 0.1;
                nameWidth = 0.3;
                phoneWidth = 0.3;
                idNumberWidth = 0.3;
            }
        }

        struct Flight
        {
            public double idWidth;
            public double fromWidth;
            public double toWidth;
            public double dateWidth;
            public double timeWidth;
            public double priceWidth;
            public double class1seatWidth;
            public double class2seatWidth;

            public Flight()
            {
                idWidth = 0.1;
                fromWidth = 0.15;
                toWidth = 0.15;
                dateWidth = 0.15;
                timeWidth = 0.1;
                priceWidth = 0.15;
                class1seatWidth = 0.1;
                class2seatWidth = 0.1;
            }
        }

        struct Route
        {
            public double idWidth;
            public double fromWidth;
            public double toWidth;
            public double durationWidth;
            public Route()
            {
                idWidth = 0.1;
                fromWidth = 0.3;
                toWidth = 0.3;
                durationWidth = 0.3;
            }
        }


        public SelectForm()
        {
            InitializeComponent();
        }

        internal string selectedID;
        private string type;
        public void loadData(DataTable tb, string type)
        {
            kryptonDataGridView1.DataSource = tb;
            this.type = type;
            dataGridWidthChange();
        }

        private void dataGridWidthChange()
        {
            switch (type)
            {
                case "Passenger":
                    Passenger passenger = new Passenger();
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * passenger.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * passenger.nameWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * passenger.phoneWidth);
                    kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * passenger.idNumberWidth);
                    break;
                case "Flight":
                    this.Size = new Size(1200, 500);
                    Flight flight = new Flight();
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * flight.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * flight.fromWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * flight.toWidth);
                    kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * flight.dateWidth);
                    kryptonDataGridView1.Columns[4].Width = (int)(kryptonDataGridView1.Width * flight.timeWidth);
                    kryptonDataGridView1.Columns[5].Width = (int)(kryptonDataGridView1.Width * flight.priceWidth);
                    kryptonDataGridView1.Columns[6].Width = (int)(kryptonDataGridView1.Width * flight.class1seatWidth);
                    kryptonDataGridView1.Columns[7].Width = (int)(kryptonDataGridView1.Width * flight.class2seatWidth);
                    break;
                case "Route":
                    Route route = new Route();
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * route.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * route.fromWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * route.toWidth);
                    kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * route.durationWidth);
                    break;
            }
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
