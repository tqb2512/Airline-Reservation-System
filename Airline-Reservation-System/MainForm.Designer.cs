namespace Airline_Reservation_System
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new Krypton.Navigator.KryptonNavigator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.statisticalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightToolStripMenuItem,
            this.airportToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.passengerToolStripMenuItem,
            this.routeToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.flightToolStripMenuItem.Text = "Flight";
            this.flightToolStripMenuItem.Click += new System.EventHandler(this.flightToolStripMenuItem_Click);
            // 
            // airportToolStripMenuItem
            // 
            this.airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            this.airportToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.airportToolStripMenuItem.Text = "Airport";
            this.airportToolStripMenuItem.Click += new System.EventHandler(this.airportToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // passengerToolStripMenuItem
            // 
            this.passengerToolStripMenuItem.Name = "passengerToolStripMenuItem";
            this.passengerToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.passengerToolStripMenuItem.Text = "Passenger";
            this.passengerToolStripMenuItem.Click += new System.EventHandler(this.passengerToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.routeToolStripMenuItem.Text = "Route";
            this.routeToolStripMenuItem.Click += new System.EventHandler(this.routeToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // statisticalToolStripMenuItem
            // 
            this.statisticalToolStripMenuItem.Name = "statisticalToolStripMenuItem";
            this.statisticalToolStripMenuItem.Size = new System.Drawing.Size(118, 34);
            this.statisticalToolStripMenuItem.Text = "Statistical";
            this.statisticalToolStripMenuItem.Click += new System.EventHandler(this.statisticalToolStripMenuItem_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 41);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.mainTabControl.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.mainTabControl.Size = new System.Drawing.Size(1576, 883);
            this.mainTabControl.TabIndex = 4;
            this.mainTabControl.Text = "kryptonNavigator1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1576, 936);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem flightToolStripMenuItem;
        private ToolStripMenuItem airportToolStripMenuItem;
        private ToolStripMenuItem ticketToolStripMenuItem;
        private ToolStripMenuItem passengerToolStripMenuItem;
        private ToolStripMenuItem routeToolStripMenuItem;
        private Krypton.Navigator.KryptonNavigator mainTabControl;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem statisticalToolStripMenuItem;
    }
}