namespace FlightWizard.UI.Panels;

partial class LoginPanel
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		label1 = new Label();
		panel1 = new Panel();
		loginButton = new Button();
		passwordTextbox = new TextBox();
		showPasswordButton = new CheckBox();
		registerLink = new LinkLabel();
		label3 = new Label();
		label2 = new Label();
		usernameTextbox = new TextBox();
		needHelpLink = new LinkLabel();
		panel1.SuspendLayout();
		SuspendLayout();
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(16, 19);
		label1.Name = "label1";
		label1.Size = new Size(64, 30);
		label1.TabIndex = 0;
		label1.Text = "Login";
		// 
		// panel1
		// 
		panel1.Controls.Add(loginButton);
		panel1.Controls.Add(passwordTextbox);
		panel1.Controls.Add(showPasswordButton);
		panel1.Controls.Add(registerLink);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(usernameTextbox);
		panel1.Controls.Add(label1);
		panel1.Location = new Point(272, 75);
		panel1.Name = "panel1";
		panel1.Size = new Size(436, 321);
		panel1.TabIndex = 1;
		// 
		// loginButton
		// 
		loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		loginButton.BackColor = Color.DarkRed;
		loginButton.FlatAppearance.BorderSize = 0;
		loginButton.FlatStyle = FlatStyle.Flat;
		loginButton.ForeColor = Color.White;
		loginButton.Location = new Point(19, 225);
		loginButton.Name = "loginButton";
		loginButton.Size = new Size(401, 29);
		loginButton.TabIndex = 14;
		loginButton.Text = "Login";
		loginButton.UseVisualStyleBackColor = false;
		loginButton.Click += OnLogin;
		// 
		// passwordTextbox
		// 
		passwordTextbox.Location = new Point(16, 149);
		passwordTextbox.Name = "passwordTextbox";
		passwordTextbox.Size = new Size(404, 23);
		passwordTextbox.TabIndex = 13;
		passwordTextbox.UseSystemPasswordChar = true;
		// 
		// showPasswordButton
		// 
		showPasswordButton.AutoSize = true;
		showPasswordButton.Location = new Point(16, 191);
		showPasswordButton.Name = "showPasswordButton";
		showPasswordButton.Size = new Size(108, 19);
		showPasswordButton.TabIndex = 12;
		showPasswordButton.Text = "Show Password";
		showPasswordButton.UseVisualStyleBackColor = true;
		showPasswordButton.CheckStateChanged += OnShowPassword;
		// 
		// registerLink
		// 
		registerLink.AutoSize = true;
		registerLink.Location = new Point(20, 278);
		registerLink.Name = "registerLink";
		registerLink.Size = new Size(205, 15);
		registerLink.TabIndex = 6;
		registerLink.TabStop = true;
		registerLink.Text = "Don't have an account? Register now.";
		registerLink.LinkClicked += OnLinkClick;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(16, 129);
		label3.Name = "label3";
		label3.Size = new Size(57, 15);
		label3.TabIndex = 4;
		label3.Text = "Password";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(16, 69);
		label2.Name = "label2";
		label2.Size = new Size(60, 15);
		label2.TabIndex = 2;
		label2.Text = "Username";
		// 
		// usernameTextbox
		// 
		usernameTextbox.Location = new Point(16, 87);
		usernameTextbox.Name = "usernameTextbox";
		usernameTextbox.Size = new Size(404, 23);
		usernameTextbox.TabIndex = 1;
		// 
		// needHelpLink
		// 
		needHelpLink.AutoSize = true;
		needHelpLink.Location = new Point(870, 435);
		needHelpLink.Name = "needHelpLink";
		needHelpLink.Size = new Size(68, 15);
		needHelpLink.TabIndex = 15;
		needHelpLink.TabStop = true;
		needHelpLink.Text = "Need Help?";
		needHelpLink.LinkClicked += OnNeedHelp;
		// 
		// LoginPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(960, 469);
		Controls.Add(needHelpLink);
		Controls.Add(panel1);
		FormBorderStyle = FormBorderStyle.None;
		Name = "LoginPanel";
		Text = "LoginPanel";
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label label1;
	private Panel panel1;
	private TextBox usernameTextbox;
	private Label label2;
	private LinkLabel registerLink;
	private Label label3;
	private CheckBox showPasswordButton;
	private TextBox passwordTextbox;
	private Button loginButton;
	private LinkLabel needHelpLink;
}