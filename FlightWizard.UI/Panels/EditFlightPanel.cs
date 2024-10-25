using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class EditFlightPanel : Form, IState
{
	public PanelType Id => PanelType.EditFlightPanel;
	public const int FLIGHTS_PANEL_CHOICE = 1;
	private readonly Session _session;
	private readonly FlightRepository _flightRepository;

	#region Variables
	public string From { get => fromTextbox.Text; set => fromTextbox.Text = value; }
	public string To { get => toTextbox.Text; set => toTextbox.Text = value; }
	public decimal Price { get => priceTextbox.Value; set => priceTextbox.Value = value; }
	public DateTime Date { get => datePicker.Value; set => datePicker.Value = value; }
	#endregion
	public EditFlightPanel(Session session, FlightRepository flightRepository)
	{
		InitializeComponent();
		_session = session;
		_flightRepository = flightRepository;
	}

	private void OnPrevious(object sender, EventArgs e)
	{
		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}

	private void CleanFields()
	{
		From = "";
		To = "";
		Price = 1;
		Date = DateTime.Now;
	}

	private void OnEdit(object sender, EventArgs e)
	{
		var flight = _session.SessionData.Get<Flight>("Flight");

		flight.From = From;
		flight.To = To;
		flight.Price = Price;
		flight.Date = Date;

		var success = _flightRepository.Update(flight);

		if (!success)
		{
			MessageBox.Show("Failed to update flight! Please try again later.");
			return;
		}

		CleanFields();
		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}

	public void AddToScreen()
	{
		var flight = _session.SessionData.Get<Flight>("Flight");

		From = flight.From;
		To = flight.To;
		Price = flight.Price;
		Date = flight.Date;

		Show();
	}

	public void RemoveFromScreen()
	{
		_session.SessionData.Remove("Flight");
		Hide();
	}
}
