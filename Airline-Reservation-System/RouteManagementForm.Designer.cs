namespace Airline_Reservation_System
{
    partial class RouteManagementForm
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
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.searchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.airportStartSearch = new System.Windows.Forms.TextBox();
            this.airportStartLocationSearch = new System.Windows.Forms.TextBox();
            this.airportArriveSearch = new System.Windows.Forms.TextBox();
            this.airportArriveLocationSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.routeId = new System.Windows.Forms.TextBox();
            this.airportStart = new System.Windows.Forms.TextBox();
            this.airportArrive = new System.Windows.Forms.TextBox();
            this.class1Price = new System.Windows.Forms.TextBox();
            this.startLocation = new System.Windows.Forms.TextBox();
            this.class2Price = new System.Windows.Forms.TextBox();
            this.arriveLocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.searchLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonDataGridView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.searchLayout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToOrderColumns = true;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.ColumnHeadersHeight = 70;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 327);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 72;
            this.kryptonDataGridView1.RowTemplate.Height = 37;
            this.kryptonDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1046, 332);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            // 
            // searchLayout
            // 
            this.searchLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLayout.ColumnCount = 5;
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchLayout.Controls.Add(this.idSearch, 0, 0);
            this.searchLayout.Controls.Add(this.airportStartSearch, 1, 0);
            this.searchLayout.Controls.Add(this.airportStartLocationSearch, 2, 0);
            this.searchLayout.Controls.Add(this.airportArriveSearch, 3, 0);
            this.searchLayout.Controls.Add(this.airportArriveLocationSearch, 4, 0);
            this.searchLayout.Location = new System.Drawing.Point(3, 277);
            this.searchLayout.Name = "searchLayout";
            this.searchLayout.RowCount = 1;
            this.searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchLayout.Size = new System.Drawing.Size(1046, 44);
            this.searchLayout.TabIndex = 2;
            // 
            // idSearch
            // 
            this.idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch.Location = new System.Drawing.Point(3, 3);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(203, 35);
            this.idSearch.TabIndex = 0;
            // 
            // airportStartSearch
            // 
            this.airportStartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airportStartSearch.Location = new System.Drawing.Point(212, 3);
            this.airportStartSearch.Name = "airportStartSearch";
            this.airportStartSearch.Size = new System.Drawing.Size(203, 35);
            this.airportStartSearch.TabIndex = 1;
            // 
            // airportStartLocationSearch
            // 
            this.airportStartLocationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airportStartLocationSearch.Location = new System.Drawing.Point(421, 3);
            this.airportStartLocationSearch.Name = "airportStartLocationSearch";
            this.airportStartLocationSearch.Size = new System.Drawing.Size(203, 35);
            this.airportStartLocationSearch.TabIndex = 2;
            // 
            // airportArriveSearch
            // 
            this.airportArriveSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airportArriveSearch.Location = new System.Drawing.Point(630, 3);
            this.airportArriveSearch.Name = "airportArriveSearch";
            this.airportArriveSearch.Size = new System.Drawing.Size(203, 35);
            this.airportArriveSearch.TabIndex = 3;
            // 
            // airportArriveLocationSearch
            // 
            this.airportArriveLocationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airportArriveLocationSearch.Location = new System.Drawing.Point(839, 3);
            this.airportArriveLocationSearch.Name = "airportArriveLocationSearch";
            this.airportArriveLocationSearch.Size = new System.Drawing.Size(204, 35);
            this.airportArriveLocationSearch.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Route Detail";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.routeId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.airportStart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.airportArrive, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.class1Price, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.startLocation, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.class2Price, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.arriveLocation, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1034, 178);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airport Start";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Airport Arrive";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Class 1 Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class 2 Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // routeId
            // 
            this.routeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.routeId.Enabled = false;
            this.routeId.Location = new System.Drawing.Point(158, 4);
            this.routeId.Name = "routeId";
            this.routeId.Size = new System.Drawing.Size(355, 35);
            this.routeId.TabIndex = 7;
            // 
            // airportStart
            // 
            this.airportStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.airportStart.Enabled = false;
            this.airportStart.Location = new System.Drawing.Point(158, 48);
            this.airportStart.Name = "airportStart";
            this.airportStart.Size = new System.Drawing.Size(355, 35);
            this.airportStart.TabIndex = 8;
            // 
            // airportArrive
            // 
            this.airportArrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.airportArrive.Enabled = false;
            this.airportArrive.Location = new System.Drawing.Point(158, 92);
            this.airportArrive.Name = "airportArrive";
            this.airportArrive.Size = new System.Drawing.Size(355, 35);
            this.airportArrive.TabIndex = 9;
            // 
            // class1Price
            // 
            this.class1Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.class1Price.Enabled = false;
            this.class1Price.Location = new System.Drawing.Point(158, 137);
            this.class1Price.Name = "class1Price";
            this.class1Price.Size = new System.Drawing.Size(355, 35);
            this.class1Price.TabIndex = 10;
            // 
            // startLocation
            // 
            this.startLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startLocation.Enabled = false;
            this.startLocation.Location = new System.Drawing.Point(674, 48);
            this.startLocation.Name = "startLocation";
            this.startLocation.Size = new System.Drawing.Size(357, 35);
            this.startLocation.TabIndex = 11;
            // 
            // class2Price
            // 
            this.class2Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.class2Price.Enabled = false;
            this.class2Price.Location = new System.Drawing.Point(674, 137);
            this.class2Price.Name = "class2Price";
            this.class2Price.Size = new System.Drawing.Size(357, 35);
            this.class2Price.TabIndex = 13;
            // 
            // arriveLocation
            // 
            this.arriveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.arriveLocation.Enabled = false;
            this.arriveLocation.Location = new System.Drawing.Point(674, 92);
            this.arriveLocation.Name = "arriveLocation";
            this.arriveLocation.Size = new System.Drawing.Size(357, 35);
            this.arriveLocation.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.Controls.Add(this.kryptonButton1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.kryptonButton2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.kryptonButton3, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 227);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1046, 44);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(889, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Add Route";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.CornerRoundingRadius = -1F;
            this.kryptonButton2.Location = new System.Drawing.Point(729, 3);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "Refresh";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.CornerRoundingRadius = -1F;
            this.kryptonButton3.Location = new System.Drawing.Point(569, 3);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton3.TabIndex = 3;
            this.kryptonButton3.Values.Text = "Delete";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // RouteManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RouteManagementForm";
            this.Text = "RouteManagementForm";
            this.SizeChanged += new System.EventHandler(this.RouteManagementForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.searchLayout.ResumeLayout(false);
            this.searchLayout.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TableLayoutPanel searchLayout;
        private TextBox idSearch;
        private TextBox airportStartSearch;
        private TextBox airportStartLocationSearch;
        private TextBox airportArriveSearch;
        private TextBox airportArriveLocationSearch;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox routeId;
        private TextBox airportStart;
        private TextBox airportArrive;
        private TextBox class1Price;
        private TextBox startLocation;
        private TextBox class2Price;
        private TextBox arriveLocation;
        private TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}