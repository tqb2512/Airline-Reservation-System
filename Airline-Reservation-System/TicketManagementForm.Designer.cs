namespace Airline_Reservation_System
{
    partial class TicketManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            Detail_tableLayoutPanel = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            Ticket_Price_textBox = new TextBox();
            Seat_Name_textBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            Ticket_ID_textBox = new TextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            Flight_DepartureAP_textBox = new TextBox();
            Flight_Departure_textBox = new TextBox();
            label8 = new Label();
            Flight_ID_textBox = new TextBox();
            Flight_ArrivalAP_textBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            Passenger_IDnumber_textBox = new TextBox();
            Passenger_Name_textBox = new TextBox();
            label4 = new Label();
            Passenger_Name_label = new Label();
            Passenger_ID_textBox = new TextBox();
            Passenger_Phone_textBox = new TextBox();
            label7 = new Label();
            label5 = new Label();
            Ticket_dataGridView = new Krypton.Toolkit.KryptonDataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            Search_Ticket_Information_tableLayoutPanel = new TableLayoutPanel();
            Search_Departure_textBox = new TextBox();
            Search_PasengerName_textBox = new TextBox();
            Search_ArrivalAP_textBox = new TextBox();
            Search_DepartureAP_textBox = new TextBox();
            Search_Ticket_ID_textBox = new TextBox();
            Search_SeatName_textBox = new TextBox();
            Search_TicketPrice_textBox = new TextBox();
            Search_tableLayoutPanel = new TableLayoutPanel();
            Search_Airport_Location_textBox = new TextBox();
            Search_Airport_Name_textBox = new TextBox();
            Detail_tableLayoutPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ticket_dataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            Search_Ticket_Information_tableLayoutPanel.SuspendLayout();
            Search_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Detail_tableLayoutPanel
            // 
            Detail_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Detail_tableLayoutPanel.ColumnCount = 3;
            Detail_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.27592F));
            Detail_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.37926F));
            Detail_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34481F));
            Detail_tableLayoutPanel.Controls.Add(groupBox1, 0, 0);
            Detail_tableLayoutPanel.Controls.Add(groupBox3, 2, 0);
            Detail_tableLayoutPanel.Controls.Add(groupBox2, 1, 0);
            Detail_tableLayoutPanel.Location = new Point(3, 3);
            Detail_tableLayoutPanel.Name = "Detail_tableLayoutPanel";
            Detail_tableLayoutPanel.RowCount = 1;
            Detail_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Detail_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 317F));
            Detail_tableLayoutPanel.Size = new Size(1936, 318);
            Detail_tableLayoutPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 312);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ticket Details";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel4.Controls.Add(Ticket_Price_textBox, 1, 2);
            tableLayoutPanel4.Controls.Add(Seat_Name_textBox, 1, 1);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(Ticket_ID_textBox, 1, 0);
            tableLayoutPanel4.Location = new Point(11, 65);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(633, 334);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // Ticket_Price_textBox
            // 
            Ticket_Price_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ticket_Price_textBox.Location = new Point(224, 135);
            Ticket_Price_textBox.Name = "Ticket_Price_textBox";
            Ticket_Price_textBox.Size = new Size(406, 39);
            Ticket_Price_textBox.TabIndex = 5;
            // 
            // Seat_Name_textBox
            // 
            Seat_Name_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Seat_Name_textBox.Location = new Point(224, 69);
            Seat_Name_textBox.Name = "Seat_Name_textBox";
            Seat_Name_textBox.Size = new Size(406, 39);
            Seat_Name_textBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 66);
            label1.TabIndex = 0;
            label1.Text = "Ticket ID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Size = new Size(215, 66);
            label3.TabIndex = 2;
            label3.Text = "Ticket Price";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 66);
            label2.Name = "label2";
            label2.Size = new Size(215, 66);
            label2.TabIndex = 1;
            label2.Text = "Seatname";
            // 
            // Ticket_ID_textBox
            // 
            Ticket_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ticket_ID_textBox.Location = new Point(224, 3);
            Ticket_ID_textBox.Name = "Ticket_ID_textBox";
            Ticket_ID_textBox.Size = new Size(406, 39);
            Ticket_ID_textBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(1293, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(640, 312);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel6.Controls.Add(Flight_DepartureAP_textBox, 1, 2);
            tableLayoutPanel6.Controls.Add(Flight_Departure_textBox, 1, 1);
            tableLayoutPanel6.Controls.Add(label8, 0, 0);
            tableLayoutPanel6.Controls.Add(Flight_ID_textBox, 1, 0);
            tableLayoutPanel6.Controls.Add(Flight_ArrivalAP_textBox, 1, 3);
            tableLayoutPanel6.Controls.Add(label11, 0, 3);
            tableLayoutPanel6.Controls.Add(label10, 0, 2);
            tableLayoutPanel6.Controls.Add(label9, 0, 1);
            tableLayoutPanel6.Location = new Point(6, 65);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Size = new Size(638, 334);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // Flight_DepartureAP_textBox
            // 
            Flight_DepartureAP_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Flight_DepartureAP_textBox.Location = new Point(226, 135);
            Flight_DepartureAP_textBox.Name = "Flight_DepartureAP_textBox";
            Flight_DepartureAP_textBox.Size = new Size(409, 39);
            Flight_DepartureAP_textBox.TabIndex = 5;
            // 
            // Flight_Departure_textBox
            // 
            Flight_Departure_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Flight_Departure_textBox.Location = new Point(226, 69);
            Flight_Departure_textBox.Name = "Flight_Departure_textBox";
            Flight_Departure_textBox.Size = new Size(409, 39);
            Flight_Departure_textBox.TabIndex = 4;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(217, 66);
            label8.TabIndex = 0;
            label8.Text = "Flight ID";
            // 
            // Flight_ID_textBox
            // 
            Flight_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Flight_ID_textBox.Location = new Point(226, 3);
            Flight_ID_textBox.Name = "Flight_ID_textBox";
            Flight_ID_textBox.Size = new Size(409, 39);
            Flight_ID_textBox.TabIndex = 3;
            // 
            // Flight_ArrivalAP_textBox
            // 
            Flight_ArrivalAP_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Flight_ArrivalAP_textBox.Location = new Point(226, 201);
            Flight_ArrivalAP_textBox.Name = "Flight_ArrivalAP_textBox";
            Flight_ArrivalAP_textBox.Size = new Size(409, 39);
            Flight_ArrivalAP_textBox.TabIndex = 7;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(3, 198);
            label11.Name = "label11";
            label11.Size = new Size(217, 66);
            label11.TabIndex = 6;
            label11.Text = "Arrival Airport";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(3, 132);
            label10.Name = "label10";
            label10.Size = new Size(217, 66);
            label10.TabIndex = 1;
            label10.Text = "Departure Airport";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 66);
            label9.Name = "label9";
            label9.Size = new Size(217, 66);
            label9.TabIndex = 2;
            label9.Text = "Departure";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(tableLayoutPanel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(647, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 312);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel5.Controls.Add(Passenger_IDnumber_textBox, 1, 2);
            tableLayoutPanel5.Controls.Add(Passenger_Name_textBox, 1, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(Passenger_Name_label, 0, 1);
            tableLayoutPanel5.Controls.Add(Passenger_ID_textBox, 1, 0);
            tableLayoutPanel5.Controls.Add(Passenger_Phone_textBox, 1, 3);
            tableLayoutPanel5.Controls.Add(label7, 0, 3);
            tableLayoutPanel5.Controls.Add(label5, 0, 2);
            tableLayoutPanel5.Location = new Point(6, 65);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(633, 334);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // Passenger_IDnumber_textBox
            // 
            Passenger_IDnumber_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passenger_IDnumber_textBox.Location = new Point(224, 135);
            Passenger_IDnumber_textBox.Name = "Passenger_IDnumber_textBox";
            Passenger_IDnumber_textBox.Size = new Size(406, 39);
            Passenger_IDnumber_textBox.TabIndex = 5;
            // 
            // Passenger_Name_textBox
            // 
            Passenger_Name_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passenger_Name_textBox.Location = new Point(224, 69);
            Passenger_Name_textBox.Name = "Passenger_Name_textBox";
            Passenger_Name_textBox.Size = new Size(406, 39);
            Passenger_Name_textBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(215, 66);
            label4.TabIndex = 0;
            label4.Text = "Passenger ID";
            // 
            // Passenger_Name_label
            // 
            Passenger_Name_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passenger_Name_label.AutoSize = true;
            Passenger_Name_label.Location = new Point(3, 66);
            Passenger_Name_label.Name = "Passenger_Name_label";
            Passenger_Name_label.Size = new Size(215, 66);
            Passenger_Name_label.TabIndex = 1;
            Passenger_Name_label.Text = "Passenger' Name";
            // 
            // Passenger_ID_textBox
            // 
            Passenger_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passenger_ID_textBox.Location = new Point(224, 3);
            Passenger_ID_textBox.Name = "Passenger_ID_textBox";
            Passenger_ID_textBox.Size = new Size(406, 39);
            Passenger_ID_textBox.TabIndex = 3;
            // 
            // Passenger_Phone_textBox
            // 
            Passenger_Phone_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passenger_Phone_textBox.Location = new Point(224, 201);
            Passenger_Phone_textBox.Name = "Passenger_Phone_textBox";
            Passenger_Phone_textBox.Size = new Size(406, 39);
            Passenger_Phone_textBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 198);
            label7.Name = "label7";
            label7.Size = new Size(215, 66);
            label7.TabIndex = 6;
            label7.Text = "Phone ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(215, 66);
            label5.TabIndex = 2;
            label5.Text = "ID number";
            // 
            // Ticket_dataGridView
            // 
            Ticket_dataGridView.AllowUserToAddRows = false;
            Ticket_dataGridView.AllowUserToDeleteRows = false;
            Ticket_dataGridView.AllowUserToResizeColumns = false;
            Ticket_dataGridView.AllowUserToResizeRows = false;
            Ticket_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ticket_dataGridView.ColumnHeadersHeight = 70;
            Ticket_dataGridView.Location = new Point(3, 53);
            Ticket_dataGridView.Name = "Ticket_dataGridView";
            Ticket_dataGridView.ReadOnly = true;
            Ticket_dataGridView.RowHeadersVisible = false;
            Ticket_dataGridView.RowHeadersWidth = 72;
            Ticket_dataGridView.RowTemplate.Height = 37;
            Ticket_dataGridView.ScrollBars = ScrollBars.Vertical;
            Ticket_dataGridView.Size = new Size(1930, 910);
            Ticket_dataGridView.TabIndex = 0;
            Ticket_dataGridView.CellClick += Ticket_dataGridView_CellClick_1;
            Ticket_dataGridView.SizeChanged += Ticket_dataGridView_SizeChanged_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Detail_tableLayoutPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel1.Location = new Point(13, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(1942, 1296);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(Search_Ticket_Information_tableLayoutPanel, 0, 0);
            tableLayoutPanel7.Controls.Add(Ticket_dataGridView, 0, 1);
            tableLayoutPanel7.Location = new Point(3, 327);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1936, 966);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // Search_Ticket_Information_tableLayoutPanel
            // 
            Search_Ticket_Information_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Ticket_Information_tableLayoutPanel.ColumnCount = 7;
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_Ticket_Information_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_Departure_textBox, 2, 0);
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_PasengerName_textBox, 1, 0);
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_ArrivalAP_textBox, 4, 0);
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_DepartureAP_textBox, 3, 0);
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_Ticket_ID_textBox, 0, 0);
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_SeatName_textBox, 5, 0);
            Search_Ticket_Information_tableLayoutPanel.Controls.Add(Search_TicketPrice_textBox, 6, 0);
            Search_Ticket_Information_tableLayoutPanel.Location = new Point(3, 3);
            Search_Ticket_Information_tableLayoutPanel.Name = "Search_Ticket_Information_tableLayoutPanel";
            Search_Ticket_Information_tableLayoutPanel.RowCount = 1;
            Search_Ticket_Information_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Search_Ticket_Information_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            Search_Ticket_Information_tableLayoutPanel.Size = new Size(1930, 44);
            Search_Ticket_Information_tableLayoutPanel.TabIndex = 2;
            // 
            // Search_Departure_textBox
            // 
            Search_Departure_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Departure_textBox.Location = new Point(553, 4);
            Search_Departure_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_Departure_textBox.Name = "Search_Departure_textBox";
            Search_Departure_textBox.Size = new Size(269, 39);
            Search_Departure_textBox.TabIndex = 7;
            // 
            // Search_PasengerName_textBox
            // 
            Search_PasengerName_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_PasengerName_textBox.Location = new Point(278, 4);
            Search_PasengerName_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_PasengerName_textBox.Name = "Search_PasengerName_textBox";
            Search_PasengerName_textBox.Size = new Size(269, 39);
            Search_PasengerName_textBox.TabIndex = 6;
            // 
            // Search_ArrivalAP_textBox
            // 
            Search_ArrivalAP_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_ArrivalAP_textBox.Location = new Point(1103, 4);
            Search_ArrivalAP_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_ArrivalAP_textBox.Name = "Search_ArrivalAP_textBox";
            Search_ArrivalAP_textBox.Size = new Size(269, 39);
            Search_ArrivalAP_textBox.TabIndex = 2;
            // 
            // Search_DepartureAP_textBox
            // 
            Search_DepartureAP_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_DepartureAP_textBox.Location = new Point(828, 4);
            Search_DepartureAP_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_DepartureAP_textBox.Name = "Search_DepartureAP_textBox";
            Search_DepartureAP_textBox.Size = new Size(269, 39);
            Search_DepartureAP_textBox.TabIndex = 1;
            // 
            // Search_Ticket_ID_textBox
            // 
            Search_Ticket_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Ticket_ID_textBox.Location = new Point(3, 4);
            Search_Ticket_ID_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_Ticket_ID_textBox.Name = "Search_Ticket_ID_textBox";
            Search_Ticket_ID_textBox.Size = new Size(269, 39);
            Search_Ticket_ID_textBox.TabIndex = 0;
            // 
            // Search_SeatName_textBox
            // 
            Search_SeatName_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_SeatName_textBox.Location = new Point(1378, 4);
            Search_SeatName_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_SeatName_textBox.Name = "Search_SeatName_textBox";
            Search_SeatName_textBox.Size = new Size(269, 39);
            Search_SeatName_textBox.TabIndex = 4;
            // 
            // Search_TicketPrice_textBox
            // 
            Search_TicketPrice_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_TicketPrice_textBox.Location = new Point(1653, 4);
            Search_TicketPrice_textBox.Margin = new Padding(3, 4, 3, 4);
            Search_TicketPrice_textBox.Name = "Search_TicketPrice_textBox";
            Search_TicketPrice_textBox.Size = new Size(274, 39);
            Search_TicketPrice_textBox.TabIndex = 5;
            // 
            // Search_tableLayoutPanel
            // 
            Search_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_tableLayoutPanel.ColumnCount = 3;
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            Search_tableLayoutPanel.Controls.Add(Search_Airport_Location_textBox, 2, 0);
            Search_tableLayoutPanel.Location = new Point(0, 0);
            Search_tableLayoutPanel.Name = "Search_tableLayoutPanel";
            Search_tableLayoutPanel.RowCount = 1;
            Search_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.Size = new Size(200, 100);
            Search_tableLayoutPanel.TabIndex = 0;
            // 
            // Search_Airport_Location_textBox
            // 
            Search_Airport_Location_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_Location_textBox.Location = new Point(135, 3);
            Search_Airport_Location_textBox.Name = "Search_Airport_Location_textBox";
            Search_Airport_Location_textBox.Size = new Size(62, 39);
            Search_Airport_Location_textBox.TabIndex = 2;
            // 
            // Search_Airport_Name_textBox
            // 
            Search_Airport_Name_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_Name_textBox.Location = new Point(69, 3);
            Search_Airport_Name_textBox.Name = "Search_Airport_Name_textBox";
            Search_Airport_Name_textBox.Size = new Size(60, 39);
            Search_Airport_Name_textBox.TabIndex = 1;
            // 
            // TicketManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1968, 1322);
            Controls.Add(tableLayoutPanel1);
            Name = "TicketManagementForm";
            Text = "TicketManagementForm";
            Load += TicketManagementForm_Load;
            Detail_tableLayoutPanel.ResumeLayout(false);
            Detail_tableLayoutPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Ticket_dataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            Search_Ticket_Information_tableLayoutPanel.ResumeLayout(false);
            Search_Ticket_Information_tableLayoutPanel.PerformLayout();
            Search_tableLayoutPanel.ResumeLayout(false);
            Search_tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel Detail_tableLayoutPanel;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox Ticket_Price_textBox;
        private TextBox Seat_Name_textBox;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox Ticket_ID_textBox;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox Flight_DepartureAP_textBox;
        private TextBox Flight_Departure_textBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Flight_ID_textBox;
        private TextBox Flight_ArrivalAP_textBox;
        private Label label11;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox Passenger_IDnumber_textBox;
        private TextBox Passenger_Name_textBox;
        private Label label4;
        private Label label5;
        private Label Passenger_Name_label;
        private TextBox Passenger_ID_textBox;
        private TextBox Passenger_Phone_textBox;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel Search_tableLayoutPanel;
        private TextBox Search_Airport_Location_textBox;
        private TextBox Search_Airport_Name_textBox;
        private TextBox Search_Price_textBox;
        private TextBox Search_Route_ID_textBox;
        public Krypton.Toolkit.KryptonDataGridView Ticket_dataGridView;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel Search_Ticket_Information_tableLayoutPanel;
        private TextBox Search_Departure_textBox;
        private TextBox Search_PasengerName_textBox;
        private TextBox Search_TicketPrice_textBox;
        private TextBox Search_SeatName_textBox;
        private TextBox Search_ArrivalAP_textBox;
        private TextBox Search_DepartureAP_textBox;
        private TextBox Search_Ticket_ID_textBox;
    }
}