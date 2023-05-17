namespace Airline_Reservation_System
{
    partial class AirportManagementForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            groupBox1 = new GroupBox();
            DetailsAirport_tableLayoutPanel = new TableLayoutPanel();
            Airport_Location_textBox = new TextBox();
            label1 = new Label();
            Airport_ID_textBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Airport_Name_textBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            Airport_Delete_button = new Krypton.Toolkit.KryptonButton();
            Airport_Edit_button = new Krypton.Toolkit.KryptonButton();
            Airport_dataGridView = new Krypton.Toolkit.KryptonDataGridView();
            Search_tableLayoutPanel = new TableLayoutPanel();
            Search_Airport_ID_textBox = new TextBox();
            Search_Airport_Location_textBox = new TextBox();
            Search_Airport_Name_textBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            DetailsAirport_tableLayoutPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Airport_dataGridView).BeginInit();
            Search_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(kryptonButton1, 0, 4);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(Airport_dataGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(Search_tableLayoutPanel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1467, 879);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(1241, 811);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(223, 36);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "Thêm sân bay mới";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(DetailsAirport_tableLayoutPanel);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1461, 130);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sân bay";
            // 
            // DetailsAirport_tableLayoutPanel
            // 
            DetailsAirport_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DetailsAirport_tableLayoutPanel.ColumnCount = 6;
            DetailsAirport_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            DetailsAirport_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            DetailsAirport_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            DetailsAirport_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            DetailsAirport_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            DetailsAirport_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            DetailsAirport_tableLayoutPanel.Controls.Add(Airport_Location_textBox, 5, 0);
            DetailsAirport_tableLayoutPanel.Controls.Add(label1, 0, 0);
            DetailsAirport_tableLayoutPanel.Controls.Add(Airport_ID_textBox, 1, 0);
            DetailsAirport_tableLayoutPanel.Controls.Add(label2, 2, 0);
            DetailsAirport_tableLayoutPanel.Controls.Add(label3, 4, 0);
            DetailsAirport_tableLayoutPanel.Controls.Add(Airport_Name_textBox, 3, 0);
            DetailsAirport_tableLayoutPanel.Location = new Point(3, 54);
            DetailsAirport_tableLayoutPanel.Name = "DetailsAirport_tableLayoutPanel";
            DetailsAirport_tableLayoutPanel.RowCount = 1;
            DetailsAirport_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DetailsAirport_tableLayoutPanel.Size = new Size(1452, 70);
            DetailsAirport_tableLayoutPanel.TabIndex = 0;
            // 
            // Airport_Location_textBox
            // 
            Airport_Location_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Airport_Location_textBox.Location = new Point(1165, 3);
            Airport_Location_textBox.Name = "Airport_Location_textBox";
            Airport_Location_textBox.Size = new Size(284, 39);
            Airport_Location_textBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "   ID Sân bay";
            // 
            // Airport_ID_textBox
            // 
            Airport_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Airport_ID_textBox.Location = new Point(203, 3);
            Airport_ID_textBox.Name = "Airport_ID_textBox";
            Airport_ID_textBox.Size = new Size(275, 39);
            Airport_ID_textBox.TabIndex = 3;
            Airport_ID_textBox.TextChanged += Airport_ID_textBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 1;
            label2.Text = "   Tên Sân bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(965, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 2;
            label3.Text = "   Vị trí";
            // 
            // Airport_Name_textBox
            // 
            Airport_Name_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Airport_Name_textBox.Location = new Point(684, 3);
            Airport_Name_textBox.Name = "Airport_Name_textBox";
            Airport_Name_textBox.Size = new Size(275, 39);
            Airport_Name_textBox.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82363F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17637F));
            tableLayoutPanel3.Controls.Add(Airport_Delete_button, 0, 0);
            tableLayoutPanel3.Controls.Add(Airport_Edit_button, 1, 0);
            tableLayoutPanel3.Location = new Point(1101, 139);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(363, 69);
            tableLayoutPanel3.TabIndex = 5;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // Airport_Delete_button
            // 
            Airport_Delete_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Airport_Delete_button.CornerRoundingRadius = -1F;
            Airport_Delete_button.Location = new Point(20, 3);
            Airport_Delete_button.Name = "Airport_Delete_button";
            Airport_Delete_button.Size = new Size(157, 63);
            Airport_Delete_button.TabIndex = 6;
            Airport_Delete_button.Values.Text = "Xóa";
            Airport_Delete_button.Click += Airport_Delete_button_Click;
            // 
            // Airport_Edit_button
            // 
            Airport_Edit_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Airport_Edit_button.CornerRoundingRadius = -1F;
            Airport_Edit_button.Location = new Point(203, 3);
            Airport_Edit_button.Name = "Airport_Edit_button";
            Airport_Edit_button.Size = new Size(157, 63);
            Airport_Edit_button.TabIndex = 5;
            Airport_Edit_button.Values.Text = "Sửa";
            Airport_Edit_button.Click += Airport_Edit_button_Click;
            // 
            // Airport_dataGridView
            // 
            Airport_dataGridView.ColumnHeadersHeight = 70;
            Airport_dataGridView.Dock = DockStyle.Fill;
            Airport_dataGridView.Location = new Point(3, 264);
            Airport_dataGridView.Name = "Airport_dataGridView";
            Airport_dataGridView.RowHeadersWidth = 72;
            Airport_dataGridView.RowTemplate.Height = 37;
            Airport_dataGridView.Size = new Size(1461, 541);
            Airport_dataGridView.TabIndex = 0;
            Airport_dataGridView.CellClick += ShowDetailAirport;
            // 
            // Search_tableLayoutPanel
            // 
            Search_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_tableLayoutPanel.ColumnCount = 3;
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Search_tableLayoutPanel.Controls.Add(Search_Airport_ID_textBox, 0, 0);
            Search_tableLayoutPanel.Controls.Add(Search_Airport_Location_textBox, 2, 0);
            Search_tableLayoutPanel.Controls.Add(Search_Airport_Name_textBox, 1, 0);
            Search_tableLayoutPanel.Location = new Point(3, 214);
            Search_tableLayoutPanel.Name = "Search_tableLayoutPanel";
            Search_tableLayoutPanel.RowCount = 1;
            Search_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Search_tableLayoutPanel.Size = new Size(1461, 44);
            Search_tableLayoutPanel.TabIndex = 6;
            // 
            // Search_Airport_ID_textBox
            // 
            Search_Airport_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_ID_textBox.Location = new Point(3, 3);
            Search_Airport_ID_textBox.Name = "Search_Airport_ID_textBox";
            Search_Airport_ID_textBox.Size = new Size(481, 39);
            Search_Airport_ID_textBox.TabIndex = 3;
            // 
            // Search_Airport_Location_textBox
            // 
            Search_Airport_Location_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_Location_textBox.Location = new Point(977, 3);
            Search_Airport_Location_textBox.Name = "Search_Airport_Location_textBox";
            Search_Airport_Location_textBox.Size = new Size(481, 39);
            Search_Airport_Location_textBox.TabIndex = 2;
            Search_Airport_Location_textBox.TextChanged += Search_textBox_TextChanged;
            // 
            // Search_Airport_Name_textBox
            // 
            Search_Airport_Name_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_Name_textBox.Location = new Point(490, 3);
            Search_Airport_Name_textBox.Name = "Search_Airport_Name_textBox";
            Search_Airport_Name_textBox.Size = new Size(481, 39);
            Search_Airport_Name_textBox.TabIndex = 1;
            Search_Airport_Name_textBox.TextChanged += Search_textBox_TextChanged;
            // 
            // AirportManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1467, 879);
            Controls.Add(tableLayoutPanel1);
            Name = "AirportManagementForm";
            Text = "AirportManagementForm";
            Load += AirportManagementForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            DetailsAirport_tableLayoutPanel.ResumeLayout(false);
            DetailsAirport_tableLayoutPanel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Airport_dataGridView).EndInit();
            Search_tableLayoutPanel.ResumeLayout(false);
            Search_tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonDataGridView Airport_dataGridView;
        private GroupBox groupBox1;
        private TableLayoutPanel DetailsAirport_tableLayoutPanel;
        private TextBox Airport_Location_textBox;
        private TextBox Airport_Name_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Airport_ID_textBox;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton Airport_Edit_button;
        private Krypton.Toolkit.KryptonButton Airport_Delete_button;
        private TableLayoutPanel Search_tableLayoutPanel;
        private TextBox Search_Airport_Location_textBox;
        private TextBox Search_Airport_Name_textBox;
        private TextBox Search_Airport_ID_textBox;
    }
}