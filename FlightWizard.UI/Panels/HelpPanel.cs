using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;

namespace FlightWizard.UI.Panels;
public partial class HelpPanel : Form, IState
{
	public const int LOGIN_PANEL_CHOICE = 1;
	private readonly Session _session;

	public HelpPanel(Session session)
	{
		InitializeComponent();
		_session = session;
	}

	public PanelType Id => PanelType.HelpPanel;

	public void AddToScreen()
	{
		Show();
	}

	public void RemoveFromScreen()
	{
		Hide();
	}

	private void OnBack(object sender, EventArgs e)
	{
		_session.ChangePanel(Id, LOGIN_PANEL_CHOICE);
	}
}
