namespace FlightWizard.UI.Panels;

partial class DeleteFlightPanel
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
		title = new Label();
		yesButton = new Button();
		button1 = new Button();
		SuspendLayout();
		// 
		// title
		// 
		title.AutoSize = true;
		title.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		title.Location = new Point(151, 116);
		title.Name = "title";
		title.Size = new Size(579, 30);
		title.TabIndex = 0;
		title.Text = "Are you sure you want to delete flight from Bucuresti to Cluj?";
		// 
		// yesButton
		// 
		yesButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		yesButton.BackColor = Color.DarkRed;
		yesButton.FlatAppearance.BorderSize = 0;
		yesButton.FlatStyle = FlatStyle.Flat;
		yesButton.ForeColor = Color.White;
		yesButton.Location = new Point(150, 179);
		yesButton.Name = "yesButton";
		yesButton.Size = new Size(287, 33);
		yesButton.TabIndex = 17;
		yesButton.Text = "Yes";
		yesButton.UseVisualStyleBackColor = false;
		yesButton.Click += OnDelete;
		// 
		// button1
		// 
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.BackColor = Color.Gray;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.ForeColor = Color.White;
		button1.Location = new Point(443, 179);
		button1.Name = "button1";
		button1.Size = new Size(287, 33);
		button1.TabIndex = 18;
		button1.Text = "No";
		button1.UseVisualStyleBackColor = false;
		button1.Click += OnCancel;
		// 
		// DeletePanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(928, 391);
		Controls.Add(button1);
		Controls.Add(yesButton);
		Controls.Add(title);
		FormBorderStyle = FormBorderStyle.None;
		Name = "DeletePanel";
		Text = "DeletePanel";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label title;
	private Button yesButton;
	private Button button1;
}