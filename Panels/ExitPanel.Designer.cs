namespace FlightWizard.UI.Panels;

partial class ExitPanel
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
		exitButton = new Button();
		pictureBox1 = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		backToFlightsButton = new Button();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		// 
		// exitButton
		// 
		exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		exitButton.BackColor = Color.DarkRed;
		exitButton.FlatAppearance.BorderSize = 0;
		exitButton.FlatStyle = FlatStyle.Flat;
		exitButton.ForeColor = Color.White;
		exitButton.Location = new Point(173, 343);
		exitButton.Name = "exitButton";
		exitButton.Size = new Size(587, 29);
		exitButton.TabIndex = 19;
		exitButton.Text = "Exit";
		exitButton.UseVisualStyleBackColor = false;
		exitButton.Click += OnExit;
		// 
		// pictureBox1
		// 
		pictureBox1.Image = Properties.Resources.attendant;
		pictureBox1.Location = new Point(173, 78);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(587, 247);
		pictureBox1.TabIndex = 18;
		pictureBox1.TabStop = false;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(50, 195);
		label2.Name = "label2";
		label2.Size = new Size(0, 50);
		label2.TabIndex = 17;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(190, 9);
		label1.Name = "label1";
		label1.Size = new Size(544, 50);
		label1.TabIndex = 16;
		label1.Text = "Thank you for reserving a flight!";
		// 
		// backToFlightsButton
		// 
		backToFlightsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		backToFlightsButton.BackColor = Color.DarkGreen;
		backToFlightsButton.FlatAppearance.BorderSize = 0;
		backToFlightsButton.FlatStyle = FlatStyle.Flat;
		backToFlightsButton.ForeColor = Color.White;
		backToFlightsButton.Location = new Point(173, 378);
		backToFlightsButton.Name = "backToFlightsButton";
		backToFlightsButton.Size = new Size(587, 29);
		backToFlightsButton.TabIndex = 20;
		backToFlightsButton.Text = "Back to flights";
		backToFlightsButton.UseVisualStyleBackColor = false;
		backToFlightsButton.Click += OnBackToFlights;
		// 
		// ExitPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(944, 430);
		Controls.Add(backToFlightsButton);
		Controls.Add(exitButton);
		Controls.Add(pictureBox1);
		Controls.Add(label2);
		Controls.Add(label1);
		FormBorderStyle = FormBorderStyle.None;
		Name = "ExitPanel";
		Text = "ExitPanel";
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button exitButton;
	private PictureBox pictureBox1;
	private Label label2;
	private Label label1;
	private Button backToFlightsButton;
}