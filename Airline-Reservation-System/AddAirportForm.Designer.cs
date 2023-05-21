namespace Airline_Reservation_System
{
    partial class AddAirportForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            airportIdTextBox = new Krypton.Toolkit.KryptonTextBox();
            airportNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            airportLocationTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(airportIdTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(airportNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(airportLocationTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(kryptonButton1, 1, 3);
            tableLayoutPanel1.Location = new Point(13, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(841, 454);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 113);
            label1.TabIndex = 0;
            label1.Text = "ID Sân Bay";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 113);
            label2.Name = "label2";
            label2.Size = new Size(246, 113);
            label2.TabIndex = 1;
            label2.Text = "Tên Sân Bay";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 226);
            label3.Name = "label3";
            label3.Size = new Size(246, 113);
            label3.TabIndex = 2;
            label3.Text = "Vị Trí";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // airportIdTextBox
            // 
            airportIdTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            airportIdTextBox.Location = new Point(255, 37);
            airportIdTextBox.Name = "airportIdTextBox";
            airportIdTextBox.Size = new Size(583, 39);
            airportIdTextBox.TabIndex = 3;
            // 
            // airportNameTextBox
            // 
            airportNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            airportNameTextBox.Location = new Point(255, 150);
            airportNameTextBox.Name = "airportNameTextBox";
            airportNameTextBox.Size = new Size(583, 39);
            airportNameTextBox.TabIndex = 4;
            // 
            // airportLocationTextBox
            // 
            airportLocationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            airportLocationTextBox.Location = new Point(255, 263);
            airportLocationTextBox.Name = "airportLocationTextBox";
            airportLocationTextBox.Size = new Size(583, 39);
            airportLocationTextBox.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(667, 342);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(171, 47);
            kryptonButton1.TabIndex = 6;
            kryptonButton1.Values.Text = "Xác Nhận";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // AddAirportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(867, 480);
            Controls.Add(tableLayoutPanel1);
            Name = "AddAirportForm";
            Text = "AddAirportForm";
            FormClosed += AddAirportForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox airportIdTextBox;
        private Krypton.Toolkit.KryptonTextBox airportNameTextBox;
        private Krypton.Toolkit.KryptonTextBox airportLocationTextBox;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}