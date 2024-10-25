namespace FlightWizard.UI.Panels;

partial class FlightsPanel
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
		DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		label1 = new Label();
		nextButton = new Button();
		searchBtn = new Button();
		FlightsGrid = new DataGridView();
		dateFromPicker = new DateTimePicker();
		dateToPicker = new DateTimePicker();
		label2 = new Label();
		label3 = new Label();
		addFlightButton = new Button();
		removeFlightButton = new Button();
		editFlightButton = new Button();
		button1 = new Button();
		((System.ComponentModel.ISupportInitialize)FlightsGrid).BeginInit();
		SuspendLayout();
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(23, 18);
		label1.Name = "label1";
		label1.Size = new Size(73, 30);
		label1.TabIndex = 8;
		label1.Text = "Flights";
		// 
		// nextButton
		// 
		nextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		nextButton.BackColor = Color.DarkRed;
		nextButton.FlatAppearance.BorderSize = 0;
		nextButton.FlatStyle = FlatStyle.Flat;
		nextButton.ForeColor = Color.White;
		nextButton.Location = new Point(805, 77);
		nextButton.Name = "nextButton";
		nextButton.Size = new Size(143, 25);
		nextButton.TabIndex = 10;
		nextButton.Text = "Reserve Flight";
		nextButton.UseVisualStyleBackColor = false;
		nextButton.Click += OnNext;
		// 
		// searchBtn
		// 
		searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		searchBtn.BackColor = Color.ForestGreen;
		searchBtn.FlatAppearance.BorderSize = 0;
		searchBtn.FlatStyle = FlatStyle.Flat;
		searchBtn.ForeColor = Color.White;
		searchBtn.Location = new Point(699, 78);
		searchBtn.Name = "searchBtn";
		searchBtn.Size = new Size(100, 24);
		searchBtn.TabIndex = 13;
		searchBtn.Text = "Search";
		searchBtn.UseVisualStyleBackColor = false;
		searchBtn.Click += OnSearch;
		// 
		// FlightsGrid
		// 
		dataGridViewCellStyle1.SelectionBackColor = Color.Fuchsia;
		FlightsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
		FlightsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		FlightsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = Color.DarkViolet;
		dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
		dataGridViewCellStyle2.ForeColor = Color.White;
		dataGridViewCellStyle2.SelectionBackColor = Color.DarkViolet;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		FlightsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		FlightsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = SystemColors.Window;
		dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
		dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = Color.Fuchsia;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
		FlightsGrid.DefaultCellStyle = dataGridViewCellStyle3;
		FlightsGrid.EnableHeadersVisualStyles = false;
		FlightsGrid.Location = new Point(23, 107);
		FlightsGrid.Margin = new Padding(2);
		FlightsGrid.Name = "FlightsGrid";
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = SystemColors.Control;
		dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
		dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = Color.Fuchsia;
		dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
		FlightsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		FlightsGrid.RowHeadersWidth = 62;
		FlightsGrid.Size = new Size(776, 351);
		FlightsGrid.TabIndex = 14;
		// 
		// dateFromPicker
		// 
		dateFromPicker.Location = new Point(23, 79);
		dateFromPicker.Name = "dateFromPicker";
		dateFromPicker.Size = new Size(301, 23);
		dateFromPicker.TabIndex = 15;
		// 
		// dateToPicker
		// 
		dateToPicker.AccessibleDescription = "dateToPicker";
		dateToPicker.Location = new Point(376, 79);
		dateToPicker.Name = "dateToPicker";
		dateToPicker.Size = new Size(305, 23);
		dateToPicker.TabIndex = 16;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(23, 59);
		label2.Name = "label2";
		label2.Size = new Size(62, 15);
		label2.TabIndex = 17;
		label2.Text = "Date From";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(376, 59);
		label3.Name = "label3";
		label3.Size = new Size(46, 15);
		label3.TabIndex = 18;
		label3.Text = "Date To";
		// 
		// addFlightButton
		// 
		addFlightButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		addFlightButton.BackColor = Color.MediumBlue;
		addFlightButton.FlatAppearance.BorderSize = 0;
		addFlightButton.FlatStyle = FlatStyle.Flat;
		addFlightButton.ForeColor = Color.White;
		addFlightButton.Location = new Point(804, 107);
		addFlightButton.Name = "addFlightButton";
		addFlightButton.Size = new Size(144, 24);
		addFlightButton.TabIndex = 19;
		addFlightButton.Text = "Add Flight";
		addFlightButton.UseVisualStyleBackColor = false;
		addFlightButton.Click += OnAddFlight;
		// 
		// removeFlightButton
		// 
		removeFlightButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		removeFlightButton.BackColor = Color.SteelBlue;
		removeFlightButton.FlatAppearance.BorderSize = 0;
		removeFlightButton.FlatStyle = FlatStyle.Flat;
		removeFlightButton.ForeColor = Color.White;
		removeFlightButton.Location = new Point(805, 137);
		removeFlightButton.Name = "removeFlightButton";
		removeFlightButton.Size = new Size(144, 24);
		removeFlightButton.TabIndex = 20;
		removeFlightButton.Text = "Remove Flight";
		removeFlightButton.UseVisualStyleBackColor = false;
		removeFlightButton.Click += OnRemoveFlight;
		// 
		// editFlightButton
		// 
		editFlightButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		editFlightButton.BackColor = Color.CadetBlue;
		editFlightButton.FlatAppearance.BorderSize = 0;
		editFlightButton.FlatStyle = FlatStyle.Flat;
		editFlightButton.ForeColor = Color.White;
		editFlightButton.Location = new Point(805, 167);
		editFlightButton.Name = "editFlightButton";
		editFlightButton.Size = new Size(144, 24);
		editFlightButton.TabIndex = 22;
		editFlightButton.Text = "Edit Flight";
		editFlightButton.UseVisualStyleBackColor = false;
		editFlightButton.Click += OnEdit;
		// 
		// button1
		// 
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.BackColor = Color.OrangeRed;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.ForeColor = Color.White;
		button1.Location = new Point(806, 432);
		button1.Name = "button1";
		button1.Size = new Size(143, 25);
		button1.TabIndex = 23;
		button1.Text = "Exit";
		button1.UseVisualStyleBackColor = false;
		button1.Click += OnExit;
		// 
		// FlightsPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(960, 469);
		Controls.Add(button1);
		Controls.Add(editFlightButton);
		Controls.Add(removeFlightButton);
		Controls.Add(addFlightButton);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(dateToPicker);
		Controls.Add(dateFromPicker);
		Controls.Add(FlightsGrid);
		Controls.Add(searchBtn);
		Controls.Add(nextButton);
		Controls.Add(label1);
		FormBorderStyle = FormBorderStyle.None;
		Name = "FlightsPanel";
		Text = "FlightsPanel";
		((System.ComponentModel.ISupportInitialize)FlightsGrid).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
	private Label label1;
	private Button searchBtn;
	private DataGridView FlightsGrid;
	private DateTimePicker dateFromPicker;
	private DateTimePicker dateToPicker;
	private Label label2;
	private Label label3;
	private Button addFlightButton;
	private Button removeFlightButton;
	private Button nextButton;
	private Button editFlightButton;
	private Button button1;
}