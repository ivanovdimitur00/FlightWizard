namespace FlightWizard.UI.Panels;

partial class HelpPanel
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
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		label9 = new Label();
		label10 = new Label();
		label11 = new Label();
		loginButton = new Button();
		SuspendLayout();
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(12, 9);
		label1.Name = "label1";
		label1.Size = new Size(271, 30);
		label1.TabIndex = 0;
		label1.Text = "Welcome to the Help Panel!";
		// 
		// label2
		// 
		label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(12, 50);
		label2.Name = "label2";
		label2.Size = new Size(906, 50);
		label2.TabIndex = 1;
		label2.Text = "In this panel, you will find useful information on how to use our flight reservation application. Please refer to the instructions below to guide you through the various functionalities available.";
		// 
		// label3
		// 
		label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(12, 100);
		label3.Name = "label3";
		label3.Size = new Size(906, 34);
		label3.TabIndex = 2;
		label3.Text = "1. Login and Registration:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(31, 134);
		label4.Name = "label4";
		label4.Size = new Size(724, 15);
		label4.TabIndex = 3;
		label4.Text = "1.1 To log in to your existing account, enter your email address and password associated with your account and click the \"Login\" button.";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(31, 160);
		label5.Name = "label5";
		label5.Size = new Size(810, 15);
		label5.TabIndex = 4;
		label5.Text = "1.2 If you don't have an account yet, you can register by clicking the \"Register\" button and filling out the registration form with the required information.";
		// 
		// label6
		// 
		label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label6.Location = new Point(12, 185);
		label6.Name = "label6";
		label6.Size = new Size(906, 34);
		label6.TabIndex = 5;
		label6.Text = "2. Administrator Functionalities:";
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Location = new Point(31, 219);
		label7.Name = "label7";
		label7.Size = new Size(657, 15);
		label7.TabIndex = 6;
		label7.Text = "2.1 Administrators have access to advanced functionalities such as adding, modifying, and deleting flights from the system.";
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Location = new Point(31, 243);
		label8.Name = "label8";
		label8.Size = new Size(543, 15);
		label8.TabIndex = 7;
		label8.Text = "2.2 To add a new flight, navigate to the \"Add Flights\" panel and fill in the necessary details in the form.";
		// 
		// label9
		// 
		label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.Location = new Point(12, 269);
		label9.Name = "label9";
		label9.Size = new Size(906, 34);
		label9.TabIndex = 8;
		label9.Text = "3. Client Functionalities:";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Location = new Point(31, 303);
		label10.Name = "label10";
		label10.Size = new Size(558, 15);
		label10.TabIndex = 9;
		label10.Text = "3.1 Regular users can search for available flights, make reservations, and manage their reservation details.";
		// 
		// label11
		// 
		label11.AutoSize = true;
		label11.Location = new Point(31, 330);
		label11.Name = "label11";
		label11.Size = new Size(474, 15);
		label11.TabIndex = 10;
		label11.Text = "3.2 Access the \"Search Flight\" panel to find available flights based on your search criteria.";
		// 
		// loginButton
		// 
		loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		loginButton.BackColor = Color.DarkRed;
		loginButton.FlatAppearance.BorderSize = 0;
		loginButton.FlatStyle = FlatStyle.Flat;
		loginButton.ForeColor = Color.White;
		loginButton.Location = new Point(21, 379);
		loginButton.Name = "loginButton";
		loginButton.Size = new Size(104, 29);
		loginButton.TabIndex = 15;
		loginButton.Text = "Back";
		loginButton.UseVisualStyleBackColor = false;
		loginButton.Click += OnBack;
		// 
		// HelpPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(944, 430);
		Controls.Add(loginButton);
		Controls.Add(label11);
		Controls.Add(label10);
		Controls.Add(label9);
		Controls.Add(label8);
		Controls.Add(label7);
		Controls.Add(label6);
		Controls.Add(label5);
		Controls.Add(label4);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		FormBorderStyle = FormBorderStyle.None;
		Name = "HelpPanel";
		Text = "HelpPanel";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label label1;
	private Label label2;
	private Label label3;
	private Label label4;
	private Label label5;
	private Label label6;
	private Label label7;
	private Label label8;
	private Label label9;
	private Label label10;
	private Label label11;
	private Button loginButton;
}