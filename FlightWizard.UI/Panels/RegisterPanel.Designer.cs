namespace FlightWizard.UI.Panels;

partial class RegisterPanel
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
		panel1 = new Panel();
		confirmPasswordTextbox = new TextBox();
		passwordTextbox = new TextBox();
		isAdminCheckbox = new CheckBox();
		checkBox1 = new CheckBox();
		label4 = new Label();
		loginLink = new LinkLabel();
		label3 = new Label();
		label2 = new Label();
		usernameTextbox = new TextBox();
		label1 = new Label();
		registerButton = new Button();
		panel1.SuspendLayout();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.Controls.Add(registerButton);
		panel1.Controls.Add(confirmPasswordTextbox);
		panel1.Controls.Add(passwordTextbox);
		panel1.Controls.Add(isAdminCheckbox);
		panel1.Controls.Add(checkBox1);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(loginLink);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(usernameTextbox);
		panel1.Controls.Add(label1);
		panel1.Location = new Point(256, 27);
		panel1.Name = "panel1";
		panel1.Size = new Size(436, 412);
		panel1.TabIndex = 2;
		// 
		// confirmPasswordTextbox
		// 
		confirmPasswordTextbox.Location = new Point(20, 201);
		confirmPasswordTextbox.Name = "confirmPasswordTextbox";
		confirmPasswordTextbox.Size = new Size(404, 23);
		confirmPasswordTextbox.TabIndex = 14;
		confirmPasswordTextbox.UseSystemPasswordChar = true;
		// 
		// passwordTextbox
		// 
		passwordTextbox.Location = new Point(20, 147);
		passwordTextbox.Name = "passwordTextbox";
		passwordTextbox.Size = new Size(404, 23);
		passwordTextbox.TabIndex = 13;
		passwordTextbox.UseSystemPasswordChar = true;
		// 
		// isAdminCheckbox
		// 
		isAdminCheckbox.AutoSize = true;
		isAdminCheckbox.Location = new Point(20, 278);
		isAdminCheckbox.Name = "isAdminCheckbox";
		isAdminCheckbox.Size = new Size(73, 19);
		isAdminCheckbox.TabIndex = 12;
		isAdminCheckbox.Text = "Is Admin";
		isAdminCheckbox.UseVisualStyleBackColor = true;
		// 
		// checkBox1
		// 
		checkBox1.AutoSize = true;
		checkBox1.Location = new Point(20, 241);
		checkBox1.Name = "checkBox1";
		checkBox1.Size = new Size(108, 19);
		checkBox1.TabIndex = 11;
		checkBox1.Text = "Show Password";
		checkBox1.UseVisualStyleBackColor = true;
		checkBox1.CheckedChanged += OnShowPassword;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(16, 183);
		label4.Name = "label4";
		label4.Size = new Size(104, 15);
		label4.TabIndex = 8;
		label4.Text = "Confirm Password";
		// 
		// loginLink
		// 
		loginLink.AutoSize = true;
		loginLink.Location = new Point(20, 361);
		loginLink.Name = "loginLink";
		loginLink.Size = new Size(205, 15);
		loginLink.TabIndex = 6;
		loginLink.TabStop = true;
		loginLink.Text = "Don't have an account? Register now.";
		loginLink.LinkClicked += OnLinkClick;
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
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(16, 19);
		label1.Name = "label1";
		label1.Size = new Size(87, 30);
		label1.TabIndex = 0;
		label1.Text = "Register";
		// 
		// registerButton
		// 
		registerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		registerButton.BackColor = Color.DarkRed;
		registerButton.FlatAppearance.BorderSize = 0;
		registerButton.FlatStyle = FlatStyle.Flat;
		registerButton.ForeColor = Color.White;
		registerButton.Location = new Point(19, 314);
		registerButton.Name = "registerButton";
		registerButton.Size = new Size(405, 29);
		registerButton.TabIndex = 15;
		registerButton.Text = "Register";
		registerButton.UseVisualStyleBackColor = false;
		registerButton.Click += OnRegister;
		// 
		// RegisterPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(960, 469);
		Controls.Add(panel1);
		FormBorderStyle = FormBorderStyle.None;
		Name = "RegisterPanel";
		Text = "RegisterPanel";
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private Panel panel1;
	private Label label4;
	private LinkLabel loginLink;
	private Label label3;
	private Label label2;
	private TextBox usernameTextbox;
	private Label label1;
	private CheckBox isAdminCheckbox;
	private CheckBox checkBox1;
	private TextBox confirmPasswordTextbox;
	private TextBox passwordTextbox;
	private Button registerButton;
}