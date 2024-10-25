using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Business.Models;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class FlightsPanel : Form, IState
{
	public const int RESERVE_SEAT_PANEL_CHOICE = 1;
	public const int ADD_FLIGHT_PANEL_CHOICE = 2;
	public const int DELETE_FLIGHT_PANEL_CHOICE = 3;
	public const int EDIT_FLIGHT_PANEL_CHOICE = 4;
	private readonly Session _session;
	private readonly FlightRepository _flightRepository;
	private BindingSource _bindingSource = [];

	#region Variables
	public DateTime DateFrom { get => dateFromPicker.Value; set => dateFromPicker.Value = value; }
	public DateTime DateTo { get => dateToPicker.Value; set => dateToPicker.Value = value; }
	#endregion

	public FlightsPanel(Session session, FlightRepository flightRepository)
	{
		InitializeComponent();
		_session = session;
		_flightRepository = flightRepository;

		FlightsGrid.DataSource = _bindingSource;
		FlightsGrid.AllowUserToDeleteRows = false;
		FlightsGrid.AllowUserToAddRows = false;
		FlightsGrid.AllowUserToOrderColumns = false;
		FlightsGrid.AllowUserToResizeColumns = false;
		FlightsGrid.AllowUserToResizeRows = false;
		FlightsGrid.ShowEditingIcon = false;
		FlightsGrid.ReadOnly = true;
		FlightsGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		FlightsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		FlightsGrid.MultiSelect = false;
		FlightsGrid.ScrollBars = ScrollBars.Vertical;

		GetFlights();
	}

	private void GetFlights()
	{
		_bindingSource.DataSource = _flightRepository.Get();
	}

	public PanelType Id => PanelType.FlightsPanel;

	public void AddToScreen()
	{
		var user = _session.SessionData.Get<User>("User");

		if (user.Role == Role.Client)
		{
			removeFlightButton.Hide();
			editFlightButton.Hide();
			addFlightButton.Hide();
		}

		Show();
		GetFlights();
	}

	public void RemoveFromScreen()
	{
		Hide();
	}

	private void OnNext(object sender, EventArgs e)
	{
		var flight = (Flight?)_bindingSource.Current;

		if (flight is null)
		{
			MessageBox.Show("Please select a flight to reserve before continuing!");
			return;
		}

		_session.SessionData.Add("FlightId", flight.FlightId);

		_session.ChangePanel(Id, RESERVE_SEAT_PANEL_CHOICE);
	}

	private void OnSearch(object sender, EventArgs e)
	{
		_bindingSource.DataSource = _flightRepository.SearchByDate(DateFrom, DateTo);
	}

	private void OnAddFlight(object sender, EventArgs e)
	{
		_session.ChangePanel(Id, ADD_FLIGHT_PANEL_CHOICE);
	}

	private void OnRemoveFlight(object sender, EventArgs e)
	{
		var flight = (Flight?)_bindingSource.Current;

		if (flight is null)
		{
			MessageBox.Show("Please select a flight to delete first!");
			return;
		}

		_session.SessionData.Add("Flight", flight);

		_session.ChangePanel(Id, DELETE_FLIGHT_PANEL_CHOICE);
	}

	private void OnEdit(object sender, EventArgs e)
	{
		var flight = (Flight?)_bindingSource.Current;

		if (flight is null)
		{
			MessageBox.Show("Please select a flight to edit first!");
			return;
		}

		_session.SessionData.Add("Flight", flight);

		_session.ChangePanel(Id, EDIT_FLIGHT_PANEL_CHOICE);
	}

	private void OnExit(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
