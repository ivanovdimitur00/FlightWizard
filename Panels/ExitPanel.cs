using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;

namespace FlightWizard.UI.Panels;
public partial class ExitPanel : Form, IState
{
	public const int FLIGHTS_PANEL_CHOICE = 1;
	private readonly Session _session;

	public ExitPanel(Session session)
	{
		InitializeComponent();
		_session = session;
	}

	public PanelType Id => PanelType.ExitPanel;

	public void AddToScreen()
	{
		Show();
	}

	public void RemoveFromScreen()
	{
		Hide();
	}

	private void OnExit(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void OnBackToFlights(object sender, EventArgs e)
	{
		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}
}
