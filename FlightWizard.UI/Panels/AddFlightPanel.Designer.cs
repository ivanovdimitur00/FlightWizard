﻿namespace FlightWizard.UI.Panels;

partial class AddFlightPanel
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
        label2 = new Label();
        panel1 = new Panel();
        label6 = new Label();
        numberOfSeatsTextbox = new NumericUpDown();
        label5 = new Label();
        priceTextbox = new NumericUpDown();
        label4 = new Label();
        datePicker = new DateTimePicker();
        label3 = new Label();
        toTextbox = new TextBox();
        label1 = new Label();
        fromTextbox = new TextBox();
        addButton = new Button();
        previousButton = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numberOfSeatsTextbox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)priceTextbox).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(12, 9);
        label2.Name = "label2";
        label2.Size = new Size(108, 30);
        label2.TabIndex = 9;
        label2.Text = "Add Flight";
        // 
        // panel1
        // 
        panel1.Controls.Add(label6);
        panel1.Controls.Add(numberOfSeatsTextbox);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(priceTextbox);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(datePicker);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(toTextbox);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(fromTextbox);
        panel1.Location = new Point(12, 54);
        panel1.Name = "panel1";
        panel1.Size = new Size(889, 285);
        panel1.TabIndex = 10;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(17, 202);
        label6.Name = "label6";
        label6.Size = new Size(69, 15);
        label6.TabIndex = 9;
        label6.Text = "No. of seats";
        // 
        // numberOfSeatsTextbox
        // 
        numberOfSeatsTextbox.Location = new Point(17, 220);
        numberOfSeatsTextbox.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numberOfSeatsTextbox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numberOfSeatsTextbox.Name = "numberOfSeatsTextbox";
        numberOfSeatsTextbox.Size = new Size(848, 23);
        numberOfSeatsTextbox.TabIndex = 8;
        numberOfSeatsTextbox.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
        // addButton
        // 
        addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        addButton.BackColor = Color.DarkRed;
        addButton.FlatAppearance.BorderSize = 0;
        addButton.FlatStyle = FlatStyle.Flat;
        addButton.ForeColor = Color.White;
        addButton.Location = new Point(796, 365);
        addButton.Name = "addButton";
        addButton.Size = new Size(105, 29);
        addButton.TabIndex = 11;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = false;
        addButton.Click += OnAdd;
        // 
        // previousButton
        // 
        previousButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        previousButton.BackColor = Color.DimGray;
        previousButton.FlatAppearance.BorderSize = 0;
        previousButton.FlatStyle = FlatStyle.Flat;
        previousButton.ForeColor = Color.White;
        previousButton.Location = new Point(12, 365);
        previousButton.Name = "previousButton";
        previousButton.Size = new Size(76, 29);
        previousButton.TabIndex = 12;
        previousButton.Text = "Previous";
        previousButton.UseVisualStyleBackColor = false;
        previousButton.Click += OnPrevious;
        // 
        // AddFlightPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(944, 430);
        Controls.Add(previousButton);
        Controls.Add(addButton);
        Controls.Add(panel1);
        Controls.Add(label2);
        FormBorderStyle = FormBorderStyle.None;
        Name = "AddFlightPanel";
        Text = "AddFlightPanel";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numberOfSeatsTextbox).EndInit();
        ((System.ComponentModel.ISupportInitialize)priceTextbox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label2;
	private Panel panel1;
	private Button addButton;
	private Button previousButton;
	private Label label1;
	private TextBox fromTextbox;
	private Label label3;
	private TextBox toTextbox;
	private NumericUpDown priceTextbox;
	private Label label4;
	private DateTimePicker datePicker;
	private Label label5;
	private Label label6;
	private NumericUpDown numberOfSeatsTextbox;
}