namespace FlightWizard.UI.Panels;

partial class ReserveSeatPanel
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
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
		title = new Label();
		SeatsGrid = new DataGridView();
		nextButton = new Button();
		previousBtn = new Button();
		((System.ComponentModel.ISupportInitialize)SeatsGrid).BeginInit();
		SuspendLayout();
		// 
		// title
		// 
		title.AutoSize = true;
		title.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		title.Location = new Point(12, 9);
		title.Name = "title";
		title.Size = new Size(62, 30);
		title.TabIndex = 9;
		title.Text = "Seats";
		// 
		// SeatsGrid
		// 
		dataGridViewCellStyle5.SelectionBackColor = Color.Fuchsia;
		SeatsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
		SeatsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		SeatsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = Color.DarkViolet;
		dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
		dataGridViewCellStyle6.ForeColor = Color.White;
		dataGridViewCellStyle6.SelectionBackColor = Color.DarkViolet;
		dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
		SeatsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
		SeatsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle7.BackColor = SystemColors.Window;
		dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
		dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle7.SelectionBackColor = Color.Fuchsia;
		dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
		SeatsGrid.DefaultCellStyle = dataGridViewCellStyle7;
		SeatsGrid.EnableHeadersVisualStyles = false;
		SeatsGrid.Location = new Point(12, 52);
		SeatsGrid.Margin = new Padding(2);
		SeatsGrid.Name = "SeatsGrid";
		dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = SystemColors.Control;
		dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
		dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle8.SelectionBackColor = Color.Fuchsia;
		dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
		SeatsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
		SeatsGrid.RowHeadersWidth = 62;
		SeatsGrid.Size = new Size(907, 304);
		SeatsGrid.TabIndex = 15;
		// 
		// nextButton
		// 
		nextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		nextButton.BackColor = Color.DarkRed;
		nextButton.FlatAppearance.BorderSize = 0;
		nextButton.FlatStyle = FlatStyle.Flat;
		nextButton.ForeColor = Color.White;
		nextButton.Location = new Point(776, 385);
		nextButton.Name = "nextButton";
		nextButton.Size = new Size(143, 33);
		nextButton.TabIndex = 16;
		nextButton.Text = "Reserve Seat";
		nextButton.UseVisualStyleBackColor = false;
		nextButton.Click += OnReserveSeat;
		// 
		// previousBtn
		// 
		previousBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		previousBtn.BackColor = Color.Gray;
		previousBtn.FlatAppearance.BorderSize = 0;
		previousBtn.FlatStyle = FlatStyle.Flat;
		previousBtn.ForeColor = Color.White;
		previousBtn.Location = new Point(12, 385);
		previousBtn.Name = "previousBtn";
		previousBtn.Size = new Size(143, 33);
		previousBtn.TabIndex = 17;
		previousBtn.Text = "Previous";
		previousBtn.UseVisualStyleBackColor = false;
		previousBtn.Click += OnPrevious;
		// 
		// ReserveSeatPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(944, 430);
		Controls.Add(previousBtn);
		Controls.Add(nextButton);
		Controls.Add(SeatsGrid);
		Controls.Add(title);
		FormBorderStyle = FormBorderStyle.None;
		Name = "ReserveSeatPanel";
		Text = "ReserveSeatPanel";
		((System.ComponentModel.ISupportInitialize)SeatsGrid).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label title;
	private DataGridView SeatsGrid;
	private Button nextButton;
	private Button previousBtn;
}