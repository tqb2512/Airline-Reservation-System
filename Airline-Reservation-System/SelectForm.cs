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

        struct Airport
        {
            public double idWidth;
            public double nameWidth;
            public double cityWidth;
            public Airport()
            {
                idWidth = 0.2;
                nameWidth = 0.4;
                cityWidth = 0.4;
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
                    idSearch.TextChanged += new EventHandler(SearchTextBox);
                    nameSearch.TextChanged += new EventHandler(SearchTextBox);
                    phoneSearch.TextChanged += new EventHandler(SearchTextBox);
                    idNumberSearch.TextChanged += new EventHandler(SearchTextBox);
                    idSearch.Name = "idSearch";
                    nameSearch.Name = "nameSearch";
                    phoneSearch.Name = "phoneSearch";
                    idNumberSearch.Name = "idNumberSearch";
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
                    idSearch1.TextChanged += new EventHandler(SearchTextBox);
                    fromSearch.TextChanged += new EventHandler(SearchTextBox);
                    toSearch.TextChanged += new EventHandler(SearchTextBox);
                    dateSearch.TextChanged += new EventHandler(SearchTextBox);
                    timeSearch.TextChanged += new EventHandler(SearchTextBox);
                    class1seatSearch.TextChanged += new EventHandler(SearchTextBox);
                    class2seatSearch.TextChanged += new EventHandler(SearchTextBox);
                    idSearch1.Name = "idSearch1";
                    fromSearch.Name = "fromSearch";
                    toSearch.Name = "toSearch";
                    dateSearch.Name = "dateSearch";
                    timeSearch.Name = "timeSearch";
                    class1seatSearch.Name = "class1seatSearch";
                    class2seatSearch.Name = "class2seatSearch";
                    break;
                case "Route":
                    Route route = new Route();
                    search_layout.Controls.Clear();
                    search_layout.ColumnCount = 4;
                    for (int i = 0; i < search_layout.ColumnCount; i++)
                    {
                        search_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    }
                    TextBox idSearch3 = new TextBox();
                    idSearch3.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(idSearch3, 0, 0);
                    TextBox fromSearch1 = new TextBox();
                    fromSearch1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(fromSearch1, 1, 0);
                    TextBox toSearch1 = new TextBox();
                    toSearch1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(toSearch1, 2, 0);
                    TextBox durationSearch = new TextBox();
                    durationSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(durationSearch, 3, 0);
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * route.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * route.fromWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * route.toWidth);
                    kryptonDataGridView1.Columns[3].Width = (int)(kryptonDataGridView1.Width * route.durationWidth);
                    search_layout.ColumnStyles[0].Width = (int)(search_layout.Width * route.idWidth);
                    search_layout.ColumnStyles[1].Width = (int)(search_layout.Width * route.fromWidth);
                    search_layout.ColumnStyles[2].Width = (int)(search_layout.Width * route.toWidth);
                    search_layout.ColumnStyles[3].Width = (int)(search_layout.Width * route.durationWidth);
                    kryptonDataGridView1.Columns[0].HeaderText = "ID";
                    kryptonDataGridView1.Columns[1].HeaderText = "From";
                    kryptonDataGridView1.Columns[2].HeaderText = "To";
                    kryptonDataGridView1.Columns[3].HeaderText = "Fly Time";
                    idSearch3.TextChanged += new EventHandler(SearchTextBox);
                    fromSearch1.TextChanged += new EventHandler(SearchTextBox);
                    toSearch1.TextChanged += new EventHandler(SearchTextBox);
                    durationSearch.TextChanged += new EventHandler(SearchTextBox);
                    idSearch3.Name = "idSearch3";
                    fromSearch1.Name = "fromSearch1";
                    toSearch1.Name = "toSearch1";
                    durationSearch.Name = "durationSearch";
                    break;
                case "Airport":
                    Airport airport = new Airport();
                    search_layout.Controls.Clear();
                    search_layout.ColumnCount = 3;
                    for (int i = 0; i < search_layout.ColumnCount; i++)
                    {
                        search_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                    }
                    TextBox idSearch2 = new TextBox();
                    idSearch2.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(idSearch2, 0, 0);
                    TextBox nameSearch2 = new TextBox();
                    nameSearch2.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(nameSearch2, 1, 0);
                    TextBox citySearch = new TextBox();
                    citySearch.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
                    search_layout.Controls.Add(citySearch, 2, 0);
                    kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * airport.idWidth);
                    kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * airport.nameWidth);
                    kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * airport.cityWidth);
                    search_layout.ColumnStyles[0].Width = (int)(search_layout.Width * airport.idWidth);
                    search_layout.ColumnStyles[1].Width = (int)(search_layout.Width * airport.nameWidth);
                    search_layout.ColumnStyles[2].Width = (int)(search_layout.Width * airport.cityWidth);
                    kryptonDataGridView1.Columns["airport_id"].HeaderText = "ID";
                    kryptonDataGridView1.Columns["airport_name"].HeaderText = "Airport Name";
                    kryptonDataGridView1.Columns["airport_location"].HeaderText = "Location";
                    idSearch2.TextChanged += new EventHandler(SearchTextBox);
                    nameSearch2.TextChanged += new EventHandler(SearchTextBox);
                    citySearch.TextChanged += new EventHandler(SearchTextBox);
                    idSearch2.Name = "idSearch2";
                    nameSearch2.Name = "nameSearch2";
                    citySearch.Name = "citySearch";
                    break;
            }
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            selectedID = kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                            case "idSearch":
                                filter += "CONVERT(passenger_id, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch":
                                filter += "CONVERT(passenger_name, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "phoneSearch":
                                filter += "CONVERT(passenger_phone, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "idNumberSearch":
                                filter += "CONVERT(passenger_id_number, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "idSearch1":
                                filter += "CONVERT(flight_id, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "fromSearch":
                                filter += "CONVERT(start, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "toSearch":
                                filter += "CONVERT(arrive, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "dateSearch":
                                filter += "CONVERT(departure, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "timeSearch":
                                filter += "CONVERT(flight_time, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "class1seatSearch":
                                filter += "CONVERT(class1_empty, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "class2seatSearch":
                                filter += "CONVERT(class2_empty, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "idSearch2":
                                filter += "CONVERT(airport_id, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "nameSearch2":
                                filter += "CONVERT(airport_name, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "citySearch":
                                filter += "CONVERT(airport_location, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "idSearch3":
                                filter += "CONVERT(route_id, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "fromSearch1":
                                filter += "CONVERT(start_location, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "toSearch1":
                                filter += "CONVERT(arrive_location, 'System.String') LIKE '%" + control.Text + "%' AND ";
                                break;
                            case "durationSearch":
                                filter += "CONVERT(flight_time, 'System.String') LIKE '%" + control.Text + "%' AND ";
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
