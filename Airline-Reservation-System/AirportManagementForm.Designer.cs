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
            this.pos_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.Airport_dataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.search_layout = new System.Windows.Forms.TableLayoutPanel();
            this.Search_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Search_Airport_ID_textBox = new System.Windows.Forms.TextBox();
            this.Search_Airport_Location_textBox = new System.Windows.Forms.TextBox();
            this.Search_Airport_Name_textBox = new System.Windows.Forms.TextBox();
            this.pos_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Airport_dataGridView)).BeginInit();
            this.search_layout.SuspendLayout();
            this.Search_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pos_tableLayoutPanel
            // 
            this.pos_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pos_tableLayoutPanel.ColumnCount = 1;
            this.pos_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pos_tableLayoutPanel.Controls.Add(this.kryptonButton1, 0, 2);
            this.pos_tableLayoutPanel.Controls.Add(this.Airport_dataGridView, 0, 1);
            this.pos_tableLayoutPanel.Controls.Add(this.search_layout, 0, 0);
            this.pos_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pos_tableLayoutPanel.Name = "pos_tableLayoutPanel";
            this.pos_tableLayoutPanel.RowCount = 4;
            this.pos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.pos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.pos_tableLayoutPanel.Size = new System.Drawing.Size(1354, 824);
            this.pos_tableLayoutPanel.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.CornerRoundingRadius = -1F;
            this.kryptonButton1.Location = new System.Drawing.Point(1146, 761);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(205, 41);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "Thêm sân bay mới";
            // 
            // Airport_dataGridView
            // 
            this.Airport_dataGridView.ColumnHeadersHeight = 70;
            this.Airport_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Airport_dataGridView.Location = new System.Drawing.Point(3, 50);
            this.Airport_dataGridView.Name = "Airport_dataGridView";
            this.Airport_dataGridView.RowHeadersWidth = 72;
            this.Airport_dataGridView.RowTemplate.Height = 37;
            this.Airport_dataGridView.Size = new System.Drawing.Size(1348, 705);
            this.Airport_dataGridView.TabIndex = 0;
            // 
            // search_layout
            // 
            this.search_layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_layout.ColumnCount = 1;
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.search_layout.Controls.Add(this.Search_tableLayoutPanel, 0, 0);
            this.search_layout.Location = new System.Drawing.Point(3, 3);
            this.search_layout.Name = "search_layout";
            this.search_layout.RowCount = 1;
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.search_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.search_layout.Size = new System.Drawing.Size(1348, 41);
            this.search_layout.TabIndex = 5;
            // 
            // Search_tableLayoutPanel
            // 
            this.Search_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_tableLayoutPanel.AutoSize = true;
            this.Search_tableLayoutPanel.ColumnCount = 3;
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.Search_tableLayoutPanel.Controls.Add(this.Search_Airport_ID_textBox, 0, 0);
            this.Search_tableLayoutPanel.Controls.Add(this.Search_Airport_Location_textBox, 2, 0);
            this.Search_tableLayoutPanel.Controls.Add(this.Search_Airport_Name_textBox, 1, 0);
            this.Search_tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.Search_tableLayoutPanel.Name = "Search_tableLayoutPanel";
            this.Search_tableLayoutPanel.RowCount = 1;
            this.Search_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Search_tableLayoutPanel.Size = new System.Drawing.Size(1342, 35);
            this.Search_tableLayoutPanel.TabIndex = 8;
            // 
            // Search_Airport_ID_textBox
            // 
            this.Search_Airport_ID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Airport_ID_textBox.Location = new System.Drawing.Point(3, 3);
            this.Search_Airport_ID_textBox.Name = "Search_Airport_ID_textBox";
            this.Search_Airport_ID_textBox.Size = new System.Drawing.Size(441, 35);
            this.Search_Airport_ID_textBox.TabIndex = 3;
            // 
            // Search_Airport_Location_textBox
            // 
            this.Search_Airport_Location_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Airport_Location_textBox.Location = new System.Drawing.Point(897, 3);
            this.Search_Airport_Location_textBox.Name = "Search_Airport_Location_textBox";
            this.Search_Airport_Location_textBox.Size = new System.Drawing.Size(442, 35);
            this.Search_Airport_Location_textBox.TabIndex = 2;
            // 
            // Search_Airport_Name_textBox
            // 
            this.Search_Airport_Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Airport_Name_textBox.Location = new System.Drawing.Point(450, 3);
            this.Search_Airport_Name_textBox.Name = "Search_Airport_Name_textBox";
            this.Search_Airport_Name_textBox.Size = new System.Drawing.Size(441, 35);
            this.Search_Airport_Name_textBox.TabIndex = 1;
            // 
            // AirportManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 824);
            this.Controls.Add(this.pos_tableLayoutPanel);
            this.Name = "AirportManagementForm";
            this.Text = "AirportManagementForm";
            this.Load += new System.EventHandler(this.AirportManagementForm_Load);
            this.pos_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Airport_dataGridView)).EndInit();
            this.search_layout.ResumeLayout(false);
            this.search_layout.PerformLayout();
            this.Search_tableLayoutPanel.ResumeLayout(false);
            this.Search_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel pos_tableLayoutPanel;
        private Krypton.Toolkit.KryptonDataGridView Airport_dataGridView;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TableLayoutPanel search_layout;
        private TableLayoutPanel Search_tableLayoutPanel;
        private TextBox Search_Airport_ID_textBox;
        private TextBox Search_Airport_Location_textBox;
        private TextBox Search_Airport_Name_textBox;
    }
}