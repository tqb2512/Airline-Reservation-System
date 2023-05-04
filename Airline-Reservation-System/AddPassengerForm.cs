using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Airline_Reservation_System
{
    public partial class AddPassengerForm : Form
    {
        public AddPassengerForm()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string tmp_name = "'" + P_Name_TextBox.Text + "'";
            string tmp_phone = "'" + P_Phone_TextBox.Text + "'";
            string tmp_idnumber = "'" + P_IDNumber_TextBox.Text + "'";

            string query = "INSERT INTO passenger VALUES(" + tmp_name + "," + tmp_phone + "," + tmp_idnumber + ")";

            sqlFunction.sqlQueryExcute(query);

            MessageBox.Show("Successful !!", "Notification", MessageBoxButtons.OK);

            this.Close();
        }
    }
}
