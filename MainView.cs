using FlightWizard.Business;
using FlightWizard.Business.Domain;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels
{
	public partial class MainView : Form
	{
		public MainView()
		{
			InitializeComponent();

			var ctx = new Data.Contexts.ApplicationContext();
			var authenticationRepository = new AuthenticationRepository(ctx);
			var flightRepository = new FlightRepository(ctx);
			var flightSeatRepository = new FlightSeatRepository(ctx);
			var flightReservationRepository = new FlightReservationRepository(ctx);

			var session = new Session();

			var loginPanel = new LoginPanel(session, authenticationRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var registerPanel = new RegisterPanel(session, authenticationRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var addFlightPanel = new AddFlightPanel(session, flightRepository, flightSeatRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};


			var deleteFlightPanel = new DeleteFlightPanel(session, flightRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var editFlightPanel = new EditFlightPanel(session, flightRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var flightsPanel = new FlightsPanel(session, flightRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var helpPanel = new HelpPanel(session)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var exitPanel = new ExitPanel(session)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			var reserveSeatPanel = new ReserveSeatPanel(session, flightRepository, flightSeatRepository, flightReservationRepository)
			{
				MdiParent = this,
				FormBorderStyle = FormBorderStyle.None,
				Dock = DockStyle.Fill,
			};

			session.AddPanel(loginPanel, PanelType.LoginPanel);
			session.AddPanel(registerPanel, PanelType.RegisterPanel);
			session.AddPanel(addFlightPanel, PanelType.AddFlightPanel);
			session.AddPanel(flightsPanel, PanelType.FlightsPanel);
			session.AddPanel(helpPanel, PanelType.HelpPanel);
			session.AddPanel(exitPanel, PanelType.ExitPanel);
			session.AddPanel(reserveSeatPanel, PanelType.ReserveSeatPanel);
			session.AddPanel(deleteFlightPanel, PanelType.DeleteFlightPanel);
			session.AddPanel(editFlightPanel, PanelType.EditFlightPanel);

			session.AddTransition(PanelType.LoginPanel, LoginPanel.REGISTER_PANEL_CHOICE, PanelType.RegisterPanel);
			session.AddTransition(PanelType.LoginPanel, LoginPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);
			session.AddTransition(PanelType.LoginPanel, LoginPanel.NEED_HELP_PANEL_CHOICE, PanelType.HelpPanel);
			session.AddTransition(PanelType.RegisterPanel, RegisterPanel.LOGIN_PANEL_CHOICE, PanelType.LoginPanel);
			session.AddTransition(PanelType.RegisterPanel, RegisterPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);
			session.AddTransition(PanelType.FlightsPanel, FlightsPanel.ADD_FLIGHT_PANEL_CHOICE, PanelType.AddFlightPanel);
			session.AddTransition(PanelType.FlightsPanel, FlightsPanel.RESERVE_SEAT_PANEL_CHOICE, PanelType.ReserveSeatPanel); 
			session.AddTransition(PanelType.FlightsPanel, FlightsPanel.DELETE_FLIGHT_PANEL_CHOICE, PanelType.DeleteFlightPanel);
			session.AddTransition(PanelType.FlightsPanel, FlightsPanel.EDIT_FLIGHT_PANEL_CHOICE, PanelType.EditFlightPanel);
			session.AddTransition(PanelType.AddFlightPanel, AddFlightPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);
			session.AddTransition(PanelType.DeleteFlightPanel, DeleteFlightPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);
			session.AddTransition(PanelType.EditFlightPanel, EditFlightPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);
			session.AddTransition(PanelType.ReserveSeatPanel, ReserveSeatPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);
			session.AddTransition(PanelType.ReserveSeatPanel, ReserveSeatPanel.EXIT_PANEL_CHOICE, PanelType.ExitPanel);
			session.AddTransition(PanelType.HelpPanel, HelpPanel.LOGIN_PANEL_CHOICE, PanelType.LoginPanel);
			session.AddTransition(PanelType.ExitPanel, ExitPanel.FLIGHTS_PANEL_CHOICE, PanelType.FlightsPanel);

			Session.ShowPanel(loginPanel);
		}
	}
}
