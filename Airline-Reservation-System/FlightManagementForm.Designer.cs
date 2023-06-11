namespace Airline_Reservation_System
{
    partial class FlightManagementForm
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
            this.flightDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.search_layout = new System.Windows.Forms.TableLayoutPanel();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.dateSearch = new System.Windows.Forms.TextBox();
            this.fromSearch = new System.Windows.Forms.TextBox();
            this.toSearch = new System.Windows.Forms.TextBox();
            this.flyTimeSearch = new System.Windows.Forms.TextBox();
            this.class1search = new System.Windows.Forms.TextBox();
            this.class1reservedSearch = new System.Windows.Forms.TextBox();
            this.class2search = new System.Windows.Forms.TextBox();
            this.class2reservedSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addFlightButton = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
            this.search_layout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightDataGridView
            // 
            this.flightDataGridView.AllowUserToAddRows = false;
            this.flightDataGridView.AllowUserToDeleteRows = false;
            this.flightDataGridView.AllowUserToResizeColumns = false;
            this.flightDataGridView.AllowUserToResizeRows = false;
            this.flightDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightDataGridView.ColumnHeadersHeight = 70;
            this.flightDataGridView.Location = new System.Drawing.Point(3, 103);
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.RowHeadersVisible = false;
            this.flightDataGridView.RowHeadersWidth = 72;
            this.flightDataGridView.RowTemplate.Height = 37;
            this.flightDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.flightDataGridView.Size = new System.Drawing.Size(946, 606);
            this.flightDataGridView.TabIndex = 1;
            // 
            // search_layout
            // 
            this.search_layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_layout.ColumnCount = 9;
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.search_layout.Controls.Add(this.idSearch, 0, 0);
            this.search_layout.Controls.Add(this.dateSearch, 1, 0);
            this.search_layout.Controls.Add(this.fromSearch, 2, 0);
            this.search_layout.Controls.Add(this.toSearch, 3, 0);
            this.search_layout.Controls.Add(this.flyTimeSearch, 4, 0);
            this.search_layout.Controls.Add(this.class1search, 5, 0);
            this.search_layout.Controls.Add(this.class1reservedSearch, 6, 0);
            this.search_layout.Controls.Add(this.class2search, 7, 0);
            this.search_layout.Controls.Add(this.class2reservedSearch, 8, 0);
            this.search_layout.Location = new System.Drawing.Point(3, 53);
            this.search_layout.Name = "search_layout";
            this.search_layout.RowCount = 1;
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.search_layout.Size = new System.Drawing.Size(946, 44);
            this.search_layout.TabIndex = 2;
            // 
            // idSearch
            // 
            this.idSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idSearch.Location = new System.Drawing.Point(3, 3);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(99, 35);
            this.idSearch.TabIndex = 0;
            this.idSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // dateSearch
            // 
            this.dateSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateSearch.Location = new System.Drawing.Point(108, 3);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(99, 35);
            this.dateSearch.TabIndex = 1;
            this.dateSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // fromSearch
            // 
            this.fromSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromSearch.Location = new System.Drawing.Point(213, 3);
            this.fromSearch.Name = "fromSearch";
            this.fromSearch.Size = new System.Drawing.Size(99, 35);
            this.fromSearch.TabIndex = 2;
            this.fromSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // toSearch
            // 
            this.toSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toSearch.Location = new System.Drawing.Point(318, 3);
            this.toSearch.Name = "toSearch";
            this.toSearch.Size = new System.Drawing.Size(99, 35);
            this.toSearch.TabIndex = 3;
            this.toSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // flyTimeSearch
            // 
            this.flyTimeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flyTimeSearch.Location = new System.Drawing.Point(423, 3);
            this.flyTimeSearch.Name = "flyTimeSearch";
            this.flyTimeSearch.Size = new System.Drawing.Size(99, 35);
            this.flyTimeSearch.TabIndex = 4;
            this.flyTimeSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // class1search
            // 
            this.class1search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class1search.Location = new System.Drawing.Point(528, 3);
            this.class1search.Name = "class1search";
            this.class1search.Size = new System.Drawing.Size(99, 35);
            this.class1search.TabIndex = 5;
            this.class1search.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // class1reservedSearch
            // 
            this.class1reservedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class1reservedSearch.Location = new System.Drawing.Point(633, 3);
            this.class1reservedSearch.Name = "class1reservedSearch";
            this.class1reservedSearch.Size = new System.Drawing.Size(99, 35);
            this.class1reservedSearch.TabIndex = 6;
            this.class1reservedSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // class2search
            // 
            this.class2search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class2search.Location = new System.Drawing.Point(738, 3);
            this.class2search.Name = "class2search";
            this.class2search.Size = new System.Drawing.Size(99, 35);
            this.class2search.TabIndex = 7;
            this.class2search.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // class2reservedSearch
            // 
            this.class2reservedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class2reservedSearch.Location = new System.Drawing.Point(843, 3);
            this.class2reservedSearch.Name = "class2reservedSearch";
            this.class2reservedSearch.Size = new System.Drawing.Size(100, 35);
            this.class2reservedSearch.TabIndex = 8;
            this.class2reservedSearch.TextChanged += new System.EventHandler(this.SearchTextBox);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.Controls.Add(this.addFlightButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonButton1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonButton2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(946, 44);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // addFlightButton
            // 
            this.addFlightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFlightButton.CornerRoundingRadius = -1F;
            this.addFlightButton.Location = new System.Drawing.Point(789, 3);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(154, 38);
            this.addFlightButton.TabIndex = 0;
            this.addFlightButton.Values.Text = "Add Flight";
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(629, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Refresh";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.CornerRoundingRadius = -1F;
            this.kryptonButton2.Location = new System.Drawing.Point(469, 3);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(154, 38);
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "Delete";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flightDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.search_layout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 712);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FlightManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 736);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlightManagementForm";
            this.Text = "FlightManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            this.search_layout.ResumeLayout(false);
            this.search_layout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton addFlightButton;
        private Krypton.Toolkit.KryptonDataGridView flightDataGridView;
        private TableLayoutPanel search_layout;
        private TextBox idSearch;
        private TextBox dateSearch;
        private TextBox fromSearch;
        private TextBox toSearch;
        private TextBox flyTimeSearch;
        private TextBox class1search;
        private TextBox class1reservedSearch;
        private TextBox class2search;
        private TextBox class2reservedSearch;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}