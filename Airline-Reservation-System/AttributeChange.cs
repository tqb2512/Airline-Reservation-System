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
    public partial class AttributeChange : Form
    {
        public AttributeChange()
        {
            InitializeComponent();
            DataTable attribute = sqlFunction.getSqlDataTable("select * from attribute");
            textBox1.Text = attribute.Rows[0]["max_stop_over"].ToString();
            textBox2.Text = attribute.Rows[0]["min_stop_over_time"].ToString();
            textBox3.Text = attribute.Rows[0]["max_stop_over_time"].ToString();
            textBox4.Text = attribute.Rows[0]["min_flight_time"].ToString();
            textBox5.Text = attribute.Rows[0]["booking_deadline"].ToString();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string query = "update attribute set max_stop_over = '" + textBox1.Text + "', min_stop_over_time = '" + textBox2.Text + "', max_stop_over_time = '" + textBox3.Text + "', min_flight_time = '" + textBox4.Text + "', booking_deadline = '" + textBox5.Text + "'";
            sqlFunction.sqlQueryExcute(query);
            MessageBox.Show("Change Attribute Success");
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
