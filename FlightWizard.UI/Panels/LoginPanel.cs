using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Business.Models;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class LoginPanel : Form, IState
{
	public const int REGISTER_PANEL_CHOICE = 1;
	public const int FLIGHTS_PANEL_CHOICE = 3;
	public const int NEED_HELP_PANEL_CHOICE = 4;
	public PanelType Id { get; } = PanelType.LoginPanel;

	#region Variables
	public string Username { get => usernameTextbox.Text; set => usernameTextbox.Text = value; }
	public string Password { get => passwordTextbox.Text; set => passwordTextbox.Text = value; }
	#endregion

	private readonly Session _session;
	private readonly AuthenticationRepository _authenticationRepository;

	public LoginPanel(Session session, AuthenticationRepository authenticationRepository)
	{
		InitializeComponent();
		_session = session;
		_authenticationRepository = authenticationRepository;
	}

	public void AddToScreen()
	{
		Show();
	}

	public void RemoveFromScreen()
	{
		Hide();
	}

	private void OnLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
	{
		_session.ChangePanel(Id, REGISTER_PANEL_CHOICE);
	}

	private void OnShowPassword(object sender, EventArgs e)
	{
		if (sender is CheckBox checkbox)
		{
			passwordTextbox.UseSystemPasswordChar = !checkbox.Checked;
		}
	}

	private void CleanFields()
	{
		Username = "";
		Password = "";
	}

	private void ShowError(string message)
	{
		MessageBox.Show(message);
		CleanFields();
	}

	private void OnLogin(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(Username))
		{
			ShowError("Username is required!");
			return;
		}

		if (string.IsNullOrEmpty(Password))
		{
			ShowError("Password is required!");
			CleanFields();
			return;
		}

		var user = _authenticationRepository.GetByUsername(Username);

		if (user is null)
		{
			ShowError("Invalid credentials!");
			return;
		}

		if (user.Password != Password)
		{
			ShowError("Invalid credentials!");
			return;
		}

		_session.SessionData.Add("User", user);

		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}

	private void OnNeedHelp(object sender, LinkLabelLinkClickedEventArgs e)
	{
		_session.ChangePanel(Id, NEED_HELP_PANEL_CHOICE);
	}
}
