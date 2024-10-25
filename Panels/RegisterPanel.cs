using FlightWizard.Business;
using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;
using FlightWizard.Business.Models;
using FlightWizard.Data.Repositories;

namespace FlightWizard.UI.Panels;
public partial class RegisterPanel : Form, IState
{
	public const int LOGIN_PANEL_CHOICE = 1;
	public const int FLIGHTS_PANEL_CHOICE = 2;

	private readonly Session _session;
	private readonly AuthenticationRepository _authenticationRepository;

	#region Variables
	public string Username { get => usernameTextbox.Text; set => usernameTextbox.Text = value; }
	public string Password { get => passwordTextbox.Text; set => passwordTextbox.Text = value; }
	public string ConfirmPassword { get => confirmPasswordTextbox.Text; set => confirmPasswordTextbox.Text = value; }
	public bool IsAdmin { get => isAdminCheckbox.Checked; set => isAdminCheckbox.Checked = value; }
	#endregion

	public PanelType Id { get; } = PanelType.RegisterPanel;

	public RegisterPanel(Session session, AuthenticationRepository authenticationRepository)
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

	private void OnShowPassword(object sender, EventArgs e)
	{

		if (sender is CheckBox checkbox)
		{
			passwordTextbox.UseSystemPasswordChar = !checkbox.Checked;
			confirmPasswordTextbox.UseSystemPasswordChar = !checkbox.Checked;
		}
	}

	private void OnLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
	{
		_session.ChangePanel(Id, LOGIN_PANEL_CHOICE);
	}

	private void CleanFields()
	{
		Username = "";
		Password = "";
		ConfirmPassword = "";
	}

	private void ShowError(string message)
	{
		MessageBox.Show(message);
		CleanFields();
	}

	private void OnRegister(object sender, EventArgs e)
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

		if (ConfirmPassword != Password)
		{
			ShowError("Passwords do not match!");
			CleanFields();
			return;
		}

		var dbUser = _authenticationRepository.GetByUsername(Username);

		if (dbUser is not null)
		{
			ShowError("User already exists! Please go to login.");
			return;
		}

		var role = IsAdmin ? Role.Admin : Role.Client;
		var user = new User { Username = Username, Password = Password, Role = role };

		var isSuccess = _authenticationRepository.Insert(user);

		if (!isSuccess)
		{
			ShowError("Something went wrong! Please try again later!");
			return;
		}

		_session.SessionData.Add("User", user);

		_session.ChangePanel(Id, FLIGHTS_PANEL_CHOICE);
	}
}
