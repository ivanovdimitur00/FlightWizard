using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class DeleteFlightPanel : Form, IState
{
	public const int FLIGHTS_PANEL_CHOICE = 1;
	private readonly Session _session;
	private readonly FlightRepository _flightRepository;

	public PanelType Id => PanelType.DeleteFlightPanel;

	public DeleteFlightPanel(Session session, FlightRepository flightRepository)
	{
		InitializeComponent();
		_session = session;
		_flightRepository = flightRepository;
	}

	private void OnDelete(object sender, EventArgs e)
	{
		var flight = _session.SessionData.Get<Flight>("Flight");

		var success = _flightRepository.Delete(flight.FlightId);

		if (!success)
		{
			MessageBox.Show("Failed to delete flight! Please try again later.");
			return;
		}

		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}

	private void OnCancel(object sender, EventArgs e)
	{
		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}

	public void AddToScreen()
	{
		var flight = _session.SessionData.Get<Flight>("Flight");

		title.Text = $"Are you sure you want to cancel flight from {flight.From} to {flight.To}";

		Show();
	}

	public void RemoveFromScreen()
	{
		_session.SessionData.Remove("Flight");
		Hide();
	}
}
