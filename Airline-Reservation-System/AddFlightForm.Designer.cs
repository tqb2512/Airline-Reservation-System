namespace Airline_Reservation_System
{
    partial class AddFlightForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.stopOver_grid = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.routeID = new System.Windows.Forms.TextBox();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.flightID = new System.Windows.Forms.TextBox();
            this.flightDeparture = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.class2amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.class1amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.airportArrive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.airportStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flightTime = new System.Windows.Forms.TextBox();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopOver_grid)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 959);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stopover";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.Controls.Add(this.stopOver_grid, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(784, 388);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // stopOver_grid
            // 
            this.stopOver_grid.AllowUserToAddRows = false;
            this.stopOver_grid.AllowUserToDeleteRows = false;
            this.stopOver_grid.AllowUserToResizeColumns = false;
            this.stopOver_grid.AllowUserToResizeRows = false;
            this.stopOver_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopOver_grid.ColumnHeadersHeight = 70;
            this.stopOver_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stopOver_grid.Location = new System.Drawing.Point(3, 53);
            this.stopOver_grid.Name = "stopOver_grid";
            this.stopOver_grid.ReadOnly = true;
            this.stopOver_grid.RowHeadersVisible = false;
            this.stopOver_grid.RowHeadersWidth = 72;
            this.stopOver_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stopOver_grid.RowTemplate.Height = 37;
            this.stopOver_grid.Size = new System.Drawing.Size(778, 332);
            this.stopOver_grid.TabIndex = 1;
            this.stopOver_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stopOver_grid_CellClick);
            this.stopOver_grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stopOver_grid_KeyPress);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel5.Controls.Add(this.kryptonButton1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.kryptonButton4, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(778, 44);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(621, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Add";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton4.CornerRoundingRadius = -1F;
            this.kryptonButton4.Location = new System.Drawing.Point(461, 3);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton4.TabIndex = 1;
            this.kryptonButton4.Values.Text = "Delete";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.flightID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flightDeparture, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.class2amount, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.class1amount, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.airportArrive, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.airportStart, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.flightTime, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 448);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Route ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.routeID, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.kryptonButton2, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(241, 113);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(552, 49);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // routeID
            // 
            this.routeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.routeID.Enabled = false;
            this.routeID.Location = new System.Drawing.Point(3, 7);
            this.routeID.Name = "routeID";
            this.routeID.Size = new System.Drawing.Size(380, 35);
            this.routeID.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton2.CornerRoundingRadius = -1F;
            this.kryptonButton2.Location = new System.Drawing.Point(389, 3);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(160, 43);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "Select";
            this.kryptonButton2.Click += new System.EventHandler(this.selectRouteButton_Click);
            // 
            // flightID
            // 
            this.flightID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flightID.Enabled = false;
            this.flightID.Location = new System.Drawing.Point(241, 10);
            this.flightID.Name = "flightID";
            this.flightID.Size = new System.Drawing.Size(552, 35);
            this.flightID.TabIndex = 8;
            // 
            // flightDeparture
            // 
            this.flightDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flightDeparture.CornerRoundingRadius = -1F;
            this.flightDeparture.Location = new System.Drawing.Point(241, 65);
            this.flightDeparture.Name = "flightDeparture";
            this.flightDeparture.Size = new System.Drawing.Size(552, 35);
            this.flightDeparture.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 63);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class 2 Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // class2amount
            // 
            this.class2amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.class2amount.Location = new System.Drawing.Point(241, 399);
            this.class2amount.Name = "class2amount";
            this.class2amount.Size = new System.Drawing.Size(552, 35);
            this.class2amount.TabIndex = 13;
            this.class2amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.class1amount_KeyDown);
            this.class2amount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.class1amount_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class 1 Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // class1amount
            // 
            this.class1amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.class1amount.Location = new System.Drawing.Point(241, 340);
            this.class1amount.Name = "class1amount";
            this.class1amount.Size = new System.Drawing.Size(552, 35);
            this.class1amount.TabIndex = 12;
            this.class1amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.class1amount_KeyDown);
            this.class1amount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.class1amount_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Airport Arrive";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airportArrive
            // 
            this.airportArrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.airportArrive.Enabled = false;
            this.airportArrive.Location = new System.Drawing.Point(241, 285);
            this.airportArrive.Name = "airportArrive";
            this.airportArrive.Size = new System.Drawing.Size(552, 35);
            this.airportArrive.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airport Start";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airportStart
            // 
            this.airportStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.airportStart.Enabled = false;
            this.airportStart.Location = new System.Drawing.Point(241, 230);
            this.airportStart.Name = "airportStart";
            this.airportStart.Size = new System.Drawing.Size(552, 35);
            this.airportStart.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 55);
            this.label8.TabIndex = 15;
            this.label8.Text = "Flight Time";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flightTime
            // 
            this.flightTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flightTime.Enabled = false;
            this.flightTime.Location = new System.Drawing.Point(241, 175);
            this.flightTime.Name = "flightTime";
            this.flightTime.Size = new System.Drawing.Size(552, 35);
            this.flightTime.TabIndex = 16;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton3.CornerRoundingRadius = -1F;
            this.kryptonButton3.Location = new System.Drawing.Point(641, 911);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(158, 44);
            this.kryptonButton3.TabIndex = 3;
            this.kryptonButton3.Values.Text = "Confirm";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "Airport ID";
            this.ID.MinimumWidth = 9;
            this.ID.Name = "ID";
            this.ID.Width = 175;
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 983);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Flight";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stopOver_grid)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonDataGridView stopOver_grid;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox flightID;
        private TextBox airportStart;
        private TextBox airportArrive;
        private TextBox class1amount;
        private TextBox class2amount;
        private Krypton.Toolkit.KryptonDateTimePicker flightDeparture;
        private DataGridViewTextBoxColumn ID;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private TableLayoutPanel tableLayoutPanel5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox routeID;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Label label8;
        private TextBox flightTime;
    }
}