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
    public partial class AddPassengerForm : Form
    {
        public AddPassengerForm()
        {
            InitializeComponent();
            id.Text = sqlFunction.getSqlDataTable("select max(passenger_id) from passenger").Rows[0][0].ToString();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phoneNumber.Text == "" || idNumber.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            sqlFunction.sqlQueryExcute("insert into passenger (passenger_name, passenger_phone, passenger_id_number) values (N' " + name.Text + "', '" + phoneNumber.Text + "', '" + idNumber.Text + "')");
            MessageBox.Show("Passenger Added Successfully");
            this.Close();
        }

        private void phoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(Char.IsNumber((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
