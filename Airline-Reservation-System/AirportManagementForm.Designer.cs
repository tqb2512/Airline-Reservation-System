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
            pos_tableLayoutPanel = new TableLayoutPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            Airport_dataGridView = new Krypton.Toolkit.KryptonDataGridView();
            tableLayoutPanel = new TableLayoutPanel();
            Search_tableLayoutPanel = new TableLayoutPanel();
            Search_Airport_ID_textBox = new TextBox();
            Search_Airport_Location_textBox = new TextBox();
            Search_Airport_Name_textBox = new TextBox();
            pos_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Airport_dataGridView).BeginInit();
            tableLayoutPanel.SuspendLayout();
            Search_tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pos_tableLayoutPanel
            // 
            pos_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pos_tableLayoutPanel.ColumnCount = 1;
            pos_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pos_tableLayoutPanel.Controls.Add(kryptonButton1, 0, 2);
            pos_tableLayoutPanel.Controls.Add(Airport_dataGridView, 0, 1);
            pos_tableLayoutPanel.Controls.Add(tableLayoutPanel, 0, 0);
            pos_tableLayoutPanel.Location = new Point(0, 0);
            pos_tableLayoutPanel.Name = "pos_tableLayoutPanel";
            pos_tableLayoutPanel.RowCount = 4;
            pos_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pos_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pos_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pos_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pos_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pos_tableLayoutPanel.Size = new Size(1467, 879);
            pos_tableLayoutPanel.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(1242, 812);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(222, 44);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "Thêm sân bay mới";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // Airport_dataGridView
            // 
            Airport_dataGridView.ColumnHeadersHeight = 70;
            Airport_dataGridView.Dock = DockStyle.Fill;
            Airport_dataGridView.Location = new Point(3, 53);
            Airport_dataGridView.Name = "Airport_dataGridView";
            Airport_dataGridView.RowHeadersWidth = 72;
            Airport_dataGridView.RowTemplate.Height = 37;
            Airport_dataGridView.Size = new Size(1461, 753);
            Airport_dataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(Search_tableLayoutPanel, 0, 0);
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1461, 44);
            tableLayoutPanel.TabIndex = 5;
            // 
            // Search_tableLayoutPanel
            // 
            Search_tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_tableLayoutPanel.AutoSize = true;
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
            Search_tableLayoutPanel.Location = new Point(3, 3);
            Search_tableLayoutPanel.Name = "Search_tableLayoutPanel";
            Search_tableLayoutPanel.RowCount = 1;
            Search_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Search_tableLayoutPanel.Size = new Size(1455, 38);
            Search_tableLayoutPanel.TabIndex = 8;
            // 
            // Search_Airport_ID_textBox
            // 
            Search_Airport_ID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_ID_textBox.Location = new Point(3, 3);
            Search_Airport_ID_textBox.Name = "Search_Airport_ID_textBox";
            Search_Airport_ID_textBox.Size = new Size(479, 39);
            Search_Airport_ID_textBox.TabIndex = 3;
            Search_Airport_ID_textBox.TextChanged += Search_Airport_Location_textBox_TextChanged;
            // 
            // Search_Airport_Location_textBox
            // 
            Search_Airport_Location_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_Location_textBox.Location = new Point(973, 3);
            Search_Airport_Location_textBox.Name = "Search_Airport_Location_textBox";
            Search_Airport_Location_textBox.Size = new Size(479, 39);
            Search_Airport_Location_textBox.TabIndex = 2;
            Search_Airport_Location_textBox.TextChanged += Search_Airport_Location_textBox_TextChanged;
            // 
            // Search_Airport_Name_textBox
            // 
            Search_Airport_Name_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Search_Airport_Name_textBox.Location = new Point(488, 3);
            Search_Airport_Name_textBox.Name = "Search_Airport_Name_textBox";
            Search_Airport_Name_textBox.Size = new Size(479, 39);
            Search_Airport_Name_textBox.TabIndex = 1;
            Search_Airport_Name_textBox.TextChanged += Search_Airport_Location_textBox_TextChanged;
            // 
            // AirportManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1467, 879);
            Controls.Add(pos_tableLayoutPanel);
            Name = "AirportManagementForm";
            Text = "AirportManagementForm";
            Load += AirportManagementForm_Load;
            pos_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Airport_dataGridView).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            Search_tableLayoutPanel.ResumeLayout(false);
            Search_tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pos_tableLayoutPanel;
        private Krypton.Toolkit.KryptonDataGridView Airport_dataGridView;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel Search_tableLayoutPanel;
        private TextBox Search_Airport_ID_textBox;
        private TextBox Search_Airport_Location_textBox;
        private TextBox Search_Airport_Name_textBox;
    }
}