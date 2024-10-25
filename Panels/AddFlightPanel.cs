using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class AddFlightPanel : Form, IState
{
	public const int FLIGHTS_PANEL_CHOICE = 1;
	private readonly Session _session;
	private readonly FlightRepository _flightRepository;
	private readonly FlightSeatRepository _flightSeatRepository;

	#region Variables
	public string From { get => fromTextbox.Text; set => fromTextbox.Text = value; }
	public string To { get => toTextbox.Text; set => toTextbox.Text = value; }
	public decimal Price { get => priceTextbox.Value; set => priceTextbox.Value = value; }
	public DateTime Date { get => datePicker.Value; set => datePicker.Value = value; }
	public decimal NumberOfSeats { get => numberOfSeatsTextbox.Value; set => numberOfSeatsTextbox.Value = value; }
	#endregion

	public AddFlightPanel(Session session, FlightRepository flightRepository, FlightSeatRepository flightSeatRepository)
	{
		InitializeComponent();
		_session = session;
		_flightRepository = flightRepository;
		_flightSeatRepository = flightSeatRepository;
	}

	public PanelType Id => PanelType.AddFlightPanel;

	public void AddToScreen()
	{
		Show();
	}

	public void RemoveFromScreen()
	{
		Hide();
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
		NumberOfSeats = 1;
	}

	private void OnAdd(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(From))
		{
			MessageBox.Show("From is required!");
			return;
		}

		if (string.IsNullOrEmpty(To))
		{
			MessageBox.Show("From is required!");
			return;
		}

		if (Price <= 0)
		{
			MessageBox.Show("Price is required!");
			return;
		}

		if (Price >= 999)
		{
			MessageBox.Show("Price to high!");
			return;
		}

		if (NumberOfSeats <= 0 || NumberOfSeats > 12)
		{
			MessageBox.Show("NumberOfSeats must be between 1 and 12!");
			return;
		}

		var flight = new Flight { Date = Date, Price = Price, From = From, To = To };
		var success = _flightRepository.Insert(flight);

		var flightSeats = Enumerable.Range(0, (int)NumberOfSeats).Select(f => new FlightSeat { IsFree = true, FlightId = flight.FlightId }).ToList();
		success = success && _flightSeatRepository.InsertMany(flightSeats);

		if (!success)
		{
			MessageBox.Show("Something went wrong! Please try again later.");
			return;
		}

		CleanFields();
		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}
}
