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
    public partial class StatisticalForm : Form
    {

        float idWidth = 0.2f;
        float totalWidth = 0.4f;
        float percentWidth = 0.4f;

        public StatisticalForm()
        {
            InitializeComponent();
            dataLoad();
            kryptonDataGridView1.Columns[0].HeaderText = "Flight ID";
            kryptonDataGridView1.Columns[1].HeaderText = "Total Profit";
            kryptonDataGridView1.Columns[2].HeaderText = "Percent";
            kryptonDataGridView2.Columns[0].HeaderText = "Month";
            kryptonDataGridView2.Columns[1].HeaderText = "Total Profit";
            kryptonDataGridView2.Columns[2].HeaderText = "Percent";
            this.SizeChanged += new EventHandler(StatisticalForm_SizeChanged);
        }

        private void dataLoad()
        {
            DataTable yearReport = sqlFunction.getSqlDataTable("select month, sum(total) as total from (select month, sum(total) as total from (select month, sum * price as total from (select month(departure) as month, route_id, sum(reserved_amount) as sum from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id where year(departure) = " + yearPick.Value.Year + " and seat_id = 1 group by month(departure), route_id) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 1) as b group by month union select month, sum(total) as total from (select month, sum * price as total from (select month(departure) as month, route_id, sum(reserved_amount) as sum from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id where year(departure) = " + yearPick.Value.Year + " and seat_id = 2 group by month(departure), route_id) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 2) as b group by month) as b group by month");
            kryptonDataGridView2.DataSource = yearReport;
            yearReport.Columns.Add(new DataColumn("percent", typeof(string)));
            yearPie.Series["Series1"].XValueMember = "month";
            yearPie.Series["Series1"].YValueMembers = "total";
            yearPie.DataSource = yearReport;
            yearPie.DataBind();

            long total = 0;
            for (int i = 0; i < yearReport.Rows.Count; i++)
            {
                total += Convert.ToInt32(yearReport.Rows[i]["total"]);
            }
            for (int i = 0; i < yearReport.Rows.Count; i++)
            {
                yearPie.Series["Series1"].Points[i].Label = string.Format("{0:0.00}%", Convert.ToDouble(yearReport.Rows[i]["total"]) / total * 100);
                yearPie.Series["Series1"].Points[i].LegendText = "Month " + yearReport.Rows[i]["month"].ToString();
            }
            for (int i = 0; i < yearReport.Rows.Count; i++)
            {
                yearReport.Rows[i]["Percent"] = string.Format("{0:0.00}%", Convert.ToDouble(yearReport.Rows[i]["total"]) / total * 100);
            }
            DataTable monthReport = sqlFunction.getSqlDataTable("select flight_id, sum(b.total) as total from (select flight_id, sum * price as total from (select flight.flight_id, route_id, sum(reserved_amount) as sum  from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id where year(departure) = " + monthPick.Value.Year + " and month(departure) = " + monthPick.Value.Month + " and seat_id = 1 group by flight.flight_id, route_id) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 1 union select flight_id, sum * price as total from (select flight.flight_id, route_id, sum(reserved_amount) as sum from flight inner join seat_detail on flight.flight_id = seat_detail.flight_id where year(departure) = " + monthPick.Value.Year + " and month(departure) = " + monthPick.Value.Month + " and seat_id = 2 group by flight.flight_id, route_id) as a inner join ticket_price on a.route_id = ticket_price.route_id and seat_id = 2) as b group by flight_id");
            kryptonDataGridView1.DataSource = monthReport;
            monthReport.Columns.Add(new DataColumn("percent", typeof(string)));
            monthPie.Series["Series1"].XValueMember = "flight_id";
            monthPie.Series["Series1"].YValueMembers = "total";
            monthPie.DataSource = monthReport;
            monthPie.DataBind();

            total = 0;
            for (int i = 0; i < monthReport.Rows.Count; i++)
            {
                total += Convert.ToInt32(monthReport.Rows[i]["total"]);
            }
            for (int i = 0; i < monthReport.Rows.Count; i++)
            {
                monthPie.Series["Series1"].Points[i].Label = string.Format("{0:0.00}%", Convert.ToDouble(monthReport.Rows[i]["total"]) / total * 100);
                monthPie.Series["Series1"].Points[i].LegendText = "ID " + monthReport.Rows[i]["flight_id"].ToString();
            }
            for (int i = 0; i < monthReport.Rows.Count; i++)
            {
                monthReport.Rows[i]["Percent"] = string.Format("{0:0.00}%", Convert.ToDouble(monthReport.Rows[i]["total"]) / total * 100);
            }
            kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * idWidth);
            kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * totalWidth);
            kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * percentWidth);
            kryptonDataGridView2.Columns[0].Width = (int)(kryptonDataGridView2.Width * idWidth);
            kryptonDataGridView2.Columns[1].Width = (int)(kryptonDataGridView2.Width * totalWidth);
            kryptonDataGridView2.Columns[2].Width = (int)(kryptonDataGridView2.Width * percentWidth);

        }
        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void StatisticalForm_SizeChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1.Columns[0].Width = (int)(kryptonDataGridView1.Width * idWidth);
            kryptonDataGridView1.Columns[1].Width = (int)(kryptonDataGridView1.Width * totalWidth);
            kryptonDataGridView1.Columns[2].Width = (int)(kryptonDataGridView1.Width * percentWidth);
            kryptonDataGridView2.Columns[0].Width = (int)(kryptonDataGridView2.Width * idWidth);
            kryptonDataGridView2.Columns[1].Width = (int)(kryptonDataGridView2.Width * totalWidth);
            kryptonDataGridView2.Columns[2].Width = (int)(kryptonDataGridView2.Width * percentWidth);
        }
    }
}
