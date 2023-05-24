namespace Airline_Reservation_System
{
    partial class StatisticalForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.monthPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthPick = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.yearPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearPick = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDataGridView2 = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 792);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.monthPie, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.monthPick, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.kryptonDataGridView1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 786);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // monthPie
            // 
            this.monthPie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.monthPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthPie.Legends.Add(legend1);
            this.monthPie.Location = new System.Drawing.Point(3, 3);
            this.monthPie.Name = "monthPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.monthPie.Series.Add(series1);
            this.monthPie.Size = new System.Drawing.Size(548, 362);
            this.monthPie.TabIndex = 0;
            this.monthPie.Text = "chart1";
            // 
            // monthPick
            // 
            this.monthPick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthPick.CornerRoundingRadius = -1F;
            this.monthPick.CustomFormat = "MM/yyyy";
            this.monthPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPick.Location = new System.Drawing.Point(3, 371);
            this.monthPick.Name = "monthPick";
            this.monthPick.Size = new System.Drawing.Size(548, 44);
            this.monthPick.TabIndex = 1;
            this.monthPick.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.ColumnHeadersHeight = 70;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 421);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 72;
            this.kryptonDataGridView1.RowTemplate.Height = 37;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(548, 362);
            this.kryptonDataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.yearPie, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.yearPick, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonDataGridView2, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(563, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(555, 786);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // yearPie
            // 
            this.yearPie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.yearPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.yearPie.Legends.Add(legend2);
            this.yearPie.Location = new System.Drawing.Point(3, 3);
            this.yearPie.Name = "yearPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.yearPie.Series.Add(series2);
            this.yearPie.Size = new System.Drawing.Size(549, 362);
            this.yearPie.TabIndex = 0;
            this.yearPie.Text = "chart2";
            // 
            // yearPick
            // 
            this.yearPick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearPick.CornerRoundingRadius = -1F;
            this.yearPick.CustomFormat = "yyyy";
            this.yearPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPick.Location = new System.Drawing.Point(3, 371);
            this.yearPick.Name = "yearPick";
            this.yearPick.Size = new System.Drawing.Size(549, 44);
            this.yearPick.TabIndex = 1;
            this.yearPick.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.AllowUserToAddRows = false;
            this.kryptonDataGridView2.AllowUserToDeleteRows = false;
            this.kryptonDataGridView2.AllowUserToResizeColumns = false;
            this.kryptonDataGridView2.AllowUserToResizeRows = false;
            this.kryptonDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView2.ColumnHeadersHeight = 70;
            this.kryptonDataGridView2.Location = new System.Drawing.Point(3, 421);
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.RowHeadersVisible = false;
            this.kryptonDataGridView2.RowHeadersWidth = 72;
            this.kryptonDataGridView2.RowTemplate.Height = 37;
            this.kryptonDataGridView2.Size = new System.Drawing.Size(549, 362);
            this.kryptonDataGridView2.TabIndex = 2;
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 816);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatisticalForm";
            this.Text = "StatisticalForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthPie;
        private Krypton.Toolkit.KryptonDateTimePicker monthPick;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearPie;
        private Krypton.Toolkit.KryptonDateTimePicker yearPick;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
    }
}