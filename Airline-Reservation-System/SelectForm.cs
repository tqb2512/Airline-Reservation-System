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
            public double class1seatWidth;
            public double class2seatWidth;

            public Flight()
            {
                idWidth = 0.1;
                fromWidth = 0.2;
                toWidth = 0.2;
                dateWidth = 0.2;
                timeWidth = 0.1;
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
                    this.Size = new Size(1000, 600);
                    search_layout.Controls.Clear();
                    search_layout.ColumnCount = 4;
                    for (int i = 0; i < search_layout.ColumnCount; i++)
                    {
                        search_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    }
                    TextBox idSearch = new TextBox();
                    idSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(idSearch, 0, 0);
                    TextBox nameSearch = new TextBox();
                    nameSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(nameSearch, 1, 0);
                    TextBox phoneSearch = new TextBox();
                    phoneSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(phoneSearch, 2, 0);
                    TextBox idNumberSearch = new TextBox();
                    idNumberSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(idNumberSearch, 3, 0);
                    Passenger passenger = new Passenger();
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * passenger.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * passenger.nameWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * passenger.phoneWidth);
                    kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * passenger.idNumberWidth);
                    search_layout.ColumnStyles[0].Width = (int)(search_layout.Width * passenger.idWidth);
                    search_layout.ColumnStyles[1].Width = (int)(search_layout.Width * passenger.nameWidth);
                    search_layout.ColumnStyles[2].Width = (int)(search_layout.Width * passenger.phoneWidth);
                    search_layout.ColumnStyles[3].Width = (int)(search_layout.Width * passenger.idNumberWidth);
                    kryptonDataGridView1.Columns["passenger_id"].HeaderText = "ID";
                    kryptonDataGridView1.Columns["passenger_name"].HeaderText = "Name";
                    kryptonDataGridView1.Columns["passenger_phone"].HeaderText = "Phone";
                    kryptonDataGridView1.Columns["passenger_id_number"].HeaderText = "ID Number";
                    break;
                case "Flight":
                    this.Size = new Size(1200, 700);
                    search_layout.Controls.Clear();
                    search_layout.ColumnCount = 7;
                    for (int i = 0; i < search_layout.ColumnCount; i++)
                    {
                        search_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    }
                    TextBox idSearch1 = new TextBox();
                    idSearch1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(idSearch1, 0, 0);
                    TextBox fromSearch = new TextBox();
                    fromSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(fromSearch, 1, 0);
                    TextBox toSearch = new TextBox();
                    toSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(toSearch, 2, 0);
                    TextBox dateSearch = new TextBox();
                    dateSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(dateSearch, 3, 0);
                    TextBox timeSearch = new TextBox();
                    timeSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(timeSearch, 4, 0);
                    TextBox class1seatSearch = new TextBox();
                    class1seatSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(class1seatSearch, 5, 0);
                    TextBox class2seatSearch = new TextBox();
                    class2seatSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(class2seatSearch, 6, 0);
                    Flight flight = new Flight();
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * flight.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * flight.fromWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * flight.toWidth);
                    kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * flight.dateWidth);
                    kryptonDataGridView1.Columns[4].Width = (int)(kryptonDataGridView1.Width * flight.timeWidth);
                    kryptonDataGridView1.Columns[5].Width = (int)(kryptonDataGridView1.Width * flight.class1seatWidth);
                    kryptonDataGridView1.Columns[6].Width = (int)(kryptonDataGridView1.Width * flight.class2seatWidth);
                    search_layout.ColumnStyles[0].Width = (int)(search_layout.Width * flight.idWidth);
                    search_layout.ColumnStyles[1].Width = (int)(search_layout.Width * flight.fromWidth);
                    search_layout.ColumnStyles[2].Width = (int)(search_layout.Width * flight.toWidth);
                    search_layout.ColumnStyles[3].Width = (int)(search_layout.Width * flight.dateWidth);
                    search_layout.ColumnStyles[4].Width = (int)(search_layout.Width * flight.timeWidth);
                    search_layout.ColumnStyles[5].Width = (int)(search_layout.Width * flight.class1seatWidth);
                    search_layout.ColumnStyles[6].Width = (int)(search_layout.Width * flight.class2seatWidth);
                    kryptonDataGridView1.Columns["flight_id"].HeaderText = "ID";
                    kryptonDataGridView1.Columns["start"].HeaderText = "From";
                    kryptonDataGridView1.Columns["arrive"].HeaderText = "To";
                    kryptonDataGridView1.Columns["departure"].HeaderText = "Departure Date";
                    kryptonDataGridView1.Columns["flight_time"].HeaderText = "Fly Time";
                    kryptonDataGridView1.Columns["class1_empty"].HeaderText = "Class 1";
                    kryptonDataGridView1.Columns["class2_empty"].HeaderText = "Class 2";
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
