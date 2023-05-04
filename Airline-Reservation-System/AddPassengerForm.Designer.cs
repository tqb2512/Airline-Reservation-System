namespace Airline_Reservation_System
{
    partial class AddPassengerForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.P_Submit_Button = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P_ID_TextBox = new Krypton.Toolkit.KryptonTextBox();
            this.P_Name_TextBox = new Krypton.Toolkit.KryptonTextBox();
            this.P_Phone_TextBox = new Krypton.Toolkit.KryptonTextBox();
            this.P_IDNumber_TextBox = new Krypton.Toolkit.KryptonTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.P_ID_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.P_Name_TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.P_Phone_TextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.P_IDNumber_TextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.P_Submit_Button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(257, 223);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // P_Submit_Button
            // 
            this.P_Submit_Button.CornerRoundingRadius = -1F;
            this.P_Submit_Button.Location = new System.Drawing.Point(127, 3);
            this.P_Submit_Button.Name = "P_Submit_Button";
            this.P_Submit_Button.Size = new System.Drawing.Size(119, 44);
            this.P_Submit_Button.TabIndex = 0;
            this.P_Submit_Button.Values.Text = "Submit";
            this.P_Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passenger ID:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Number:";
            // 
            // P_ID_TextBox
            // 
            this.P_ID_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.P_ID_TextBox.Location = new System.Drawing.Point(257, 14);
            this.P_ID_TextBox.Name = "P_ID_TextBox";
            this.P_ID_TextBox.Size = new System.Drawing.Size(249, 27);
            this.P_ID_TextBox.TabIndex = 5;
            // 
            // P_Name_TextBox
            // 
            this.P_Name_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Name_TextBox.Location = new System.Drawing.Point(257, 69);
            this.P_Name_TextBox.Name = "P_Name_TextBox";
            this.P_Name_TextBox.Size = new System.Drawing.Size(249, 27);
            this.P_Name_TextBox.TabIndex = 6;
            // 
            // P_Phone_TextBox
            // 
            this.P_Phone_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Phone_TextBox.Location = new System.Drawing.Point(257, 124);
            this.P_Phone_TextBox.Name = "P_Phone_TextBox";
            this.P_Phone_TextBox.Size = new System.Drawing.Size(249, 27);
            this.P_Phone_TextBox.TabIndex = 7;
            // 
            // P_IDNumber_TextBox
            // 
            this.P_IDNumber_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.P_IDNumber_TextBox.Location = new System.Drawing.Point(257, 179);
            this.P_IDNumber_TextBox.Name = "P_IDNumber_TextBox";
            this.P_IDNumber_TextBox.Size = new System.Drawing.Size(249, 27);
            this.P_IDNumber_TextBox.TabIndex = 8;
            // 
            // AddPassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddPassengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassengerForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton P_Submit_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox P_ID_TextBox;
        private Krypton.Toolkit.KryptonTextBox P_Name_TextBox;
        private Krypton.Toolkit.KryptonTextBox P_Phone_TextBox;
        private Krypton.Toolkit.KryptonTextBox P_IDNumber_TextBox;
    }
}