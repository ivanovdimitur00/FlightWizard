using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Business.Models;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class ReserveSeatPanel : Form, IState
{
	public const int FLIGHTS_PANEL_CHOICE = 1;
	public const int EXIT_PANEL_CHOICE = 2;
	private readonly Session _session;
	private readonly FlightRepository _flightRepository;
	private readonly FlightSeatRepository _flightSeatRepository;
	private readonly FlightReservationRepository _flightReservationRepository;
	private BindingSource _bindingSource = [];
	private Flight? _flight;

	public ReserveSeatPanel(Session session, FlightRepository flightRepository, FlightSeatRepository flightSeatRepository, FlightReservationRepository flightReservationRepository)
	{
		InitializeComponent();
		_session = session;
		_flightRepository = flightRepository;
		_flightSeatRepository = flightSeatRepository;
		_flightReservationRepository = flightReservationRepository;

		SeatsGrid.DataSource = _bindingSource;
		SeatsGrid.AllowUserToDeleteRows = false;
		SeatsGrid.AllowUserToAddRows = false;
		SeatsGrid.AllowUserToOrderColumns = false;
		SeatsGrid.AllowUserToResizeColumns = false;
		SeatsGrid.AllowUserToResizeRows = false;
		SeatsGrid.ShowEditingIcon = false;
		SeatsGrid.ReadOnly = true;
		SeatsGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		SeatsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		SeatsGrid.MultiSelect = false;
		SeatsGrid.ScrollBars = ScrollBars.Vertical;
	}

	public void GetFlightSeats(int flightId)
	{
		var flight = _flightRepository.GetById(flightId);
		title.Text = $"Seats - Flight from {flight?.From} to {flight?.To}";
		_flight = flight;
		_bindingSource.DataSource = flight?.FlightSeats ?? [];
		SeatsGrid.Columns[^1].Visible = false;
		SeatsGrid.Columns[^2].Visible = false;
	}

	public PanelType Id => PanelType.ReserveSeatPanel;

	public void AddToScreen()
	{
		var flightId = _session.SessionData.Get<int>("FlightId");
		GetFlightSeats(flightId);
		Show();
	}

	public void RemoveFromScreen()
	{
		_session.SessionData.Remove("FlightId");
		Hide();
	}

	private void OnPrevious(object sender, EventArgs e)
	{
		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}

	private void OnReserveSeat(object sender, EventArgs e)
	{
		var seat = (FlightSeat?)_bindingSource.Current;

		if (_flight is null)
		{
			MessageBox.Show("Please select a flight before making a reservation!");
			return;
		}

		if (seat is null)
		{
			MessageBox.Show("Please select a seat before making a reservation!");
			return;
		}

		if (!seat.IsFree)
		{
			MessageBox.Show("Please select a seat that is not already taken!");
			return;
		}

		var user = _session.SessionData.Get<User>("User");

		seat.IsFree = false;
		_flightSeatRepository.Update(seat);
		var flightReservation = new FlightReservation { Date = _flight.Date, ExpirationDate = _flight.Date + TimeSpan.FromDays(4), UserId = user.UserId };
		var success = _flightReservationRepository.Insert(flightReservation);

		if (!success)
		{
			MessageBox.Show("Something went wrong! Please try again later");
			return;
		}

		_session.ChangePanel(Id, EXIT_PANEL_CHOICE);
	}
}
