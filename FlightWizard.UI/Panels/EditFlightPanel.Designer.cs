namespace FlightWizard.UI.Panels;

partial class EditFlightPanel
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
		previousButton = new Button();
		addButton = new Button();
		panel1 = new Panel();
		label5 = new Label();
		priceTextbox = new NumericUpDown();
		label4 = new Label();
		datePicker = new DateTimePicker();
		label3 = new Label();
		toTextbox = new TextBox();
		label1 = new Label();
		fromTextbox = new TextBox();
		label2 = new Label();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)priceTextbox).BeginInit();
		SuspendLayout();
		// 
		// previousButton
		// 
		previousButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		previousButton.BackColor = Color.DimGray;
		previousButton.FlatAppearance.BorderSize = 0;
		previousButton.FlatStyle = FlatStyle.Flat;
		previousButton.ForeColor = Color.White;
		previousButton.Location = new Point(39, 293);
		previousButton.Name = "previousButton";
		previousButton.Size = new Size(76, 29);
		previousButton.TabIndex = 16;
		previousButton.Text = "Previous";
		previousButton.UseVisualStyleBackColor = false;
		previousButton.Click += OnPrevious;
		// 
		// addButton
		// 
		addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		addButton.BackColor = Color.DarkRed;
		addButton.FlatAppearance.BorderSize = 0;
		addButton.FlatStyle = FlatStyle.Flat;
		addButton.ForeColor = Color.White;
		addButton.Location = new Point(782, 293);
		addButton.Name = "addButton";
		addButton.Size = new Size(105, 29);
		addButton.TabIndex = 15;
		addButton.Text = "Edit";
		addButton.UseVisualStyleBackColor = false;
		addButton.Click += OnEdit;
		// 
		// panel1
		// 
		panel1.Controls.Add(label5);
		panel1.Controls.Add(priceTextbox);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(datePicker);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(toTextbox);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(fromTextbox);
		panel1.Location = new Point(22, 54);
		panel1.Name = "panel1";
		panel1.Size = new Size(889, 217);
		panel1.TabIndex = 14;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(17, 147);
		label5.Name = "label5";
		label5.Size = new Size(33, 15);
		label5.TabIndex = 7;
		label5.Text = "Price";
		// 
		// priceTextbox
		// 
		priceTextbox.Location = new Point(17, 165);
		priceTextbox.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
		priceTextbox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
		priceTextbox.Name = "priceTextbox";
		priceTextbox.Size = new Size(848, 23);
		priceTextbox.TabIndex = 6;
		priceTextbox.Value = new decimal(new int[] { 1, 0, 0, 0 });
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(17, 91);
		label4.Name = "label4";
		label4.Size = new Size(31, 15);
		label4.TabIndex = 5;
		label4.Text = "Date";
		// 
		// datePicker
		// 
		datePicker.Location = new Point(17, 109);
		datePicker.Name = "datePicker";
		datePicker.Size = new Size(848, 23);
		datePicker.TabIndex = 4;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(454, 26);
		label3.Name = "label3";
		label3.Size = new Size(19, 15);
		label3.TabIndex = 3;
		label3.Text = "To";
		// 
		// toTextbox
		// 
		toTextbox.Location = new Point(454, 44);
		toTextbox.Name = "toTextbox";
		toTextbox.Size = new Size(411, 23);
		toTextbox.TabIndex = 2;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(17, 26);
		label1.Name = "label1";
		label1.Size = new Size(35, 15);
		label1.TabIndex = 1;
		label1.Text = "From";
		// 
		// fromTextbox
		// 
		fromTextbox.Location = new Point(17, 44);
		fromTextbox.Name = "fromTextbox";
		fromTextbox.Size = new Size(411, 23);
		fromTextbox.TabIndex = 0;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(22, 9);
		label2.Name = "label2";
		label2.Size = new Size(105, 30);
		label2.TabIndex = 13;
		label2.Text = "Edit Flight";
		// 
		// EditFlightPanel
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(928, 391);
		Controls.Add(previousButton);
		Controls.Add(addButton);
		Controls.Add(panel1);
		Controls.Add(label2);
		FormBorderStyle = FormBorderStyle.None;
		Name = "EditFlightPanel";
		Text = "EditFlightPanel";
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)priceTextbox).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button previousButton;
	private Button addButton;
	private Panel panel1;
	private Label label5;
	private NumericUpDown priceTextbox;
	private Label label4;
	private DateTimePicker datePicker;
	private Label label3;
	private TextBox toTextbox;
	private Label label1;
	private TextBox fromTextbox;
	private Label label2;
}