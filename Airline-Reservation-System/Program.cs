namespace Airline_Reservation_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AddFlightForm addFlightForm = new AddFlightForm();
            addFlightForm.Show();
            FlightManagementForm flightManagementForm = new FlightManagementForm();
            flightManagementForm.Show();
            AddAirportForm addAirportForm = new AddAirportForm();
            addAirportForm.Show();
            AirportManagementForm airportManagementForm = new AirportManagementForm();
            airportManagementForm.Show();
            AddRouteForm addRouteForm = new AddRouteForm();
            addRouteForm.Show();
            RouteManagementForm routeManagementForm = new RouteManagementForm();
            routeManagementForm.Show();
            TicketManagementForm ticketManagementForm = new TicketManagementForm();
            ticketManagementForm.Show();
            PassengerManagementForm passengerManagementForm = new PassengerManagementForm();
            passengerManagementForm.Show();
            Application.Run(new LoginForm());
        }
    }
}