namespace MoneyTrackerApp.Tabs
{
  partial class FormOptions
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
      tableLayoutPanel1 = new TableLayoutPanel();
      label4 = new Label();
      comboBox1 = new ComboBox();
      label3 = new Label();
      label2 = new Label();
      label1 = new Label();
      StartMinimizedCheckbox = new CheckBox();
      CurrencycomboBox = new ComboBox();
      ClearMoneyBtn = new Button();
      panel1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = Color.FromArgb(44, 44, 44);
      panel1.Controls.Add(tableLayoutPanel1);
      panel1.Dock = DockStyle.Fill;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(800, 450);
      panel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoScroll = true;
      tableLayoutPanel1.BackColor = Color.FromArgb(44, 44, 44);
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.Controls.Add(label4, 0, 3);
      tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
      tableLayoutPanel1.Controls.Add(label3, 0, 2);
      tableLayoutPanel1.Controls.Add(label2, 0, 1);
      tableLayoutPanel1.Controls.Add(label1, 0, 0);
      tableLayoutPanel1.Controls.Add(StartMinimizedCheckbox, 1, 1);
      tableLayoutPanel1.Controls.Add(CurrencycomboBox, 1, 0);
      tableLayoutPanel1.Controls.Add(ClearMoneyBtn, 1, 3);
      tableLayoutPanel1.Location = new Point(12, 12);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 6;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
      tableLayoutPanel1.Size = new Size(776, 417);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Dock = DockStyle.Left;
      label4.Font = new Font("Segoe UI", 37F, FontStyle.Regular, GraphicsUnit.Point);
      label4.ForeColor = Color.White;
      label4.ImageAlign = ContentAlignment.MiddleLeft;
      label4.Location = new Point(3, 207);
      label4.Name = "label4";
      label4.Size = new Size(315, 69);
      label4.TabIndex = 6;
      label4.Text = "Clear money:";
      // 
      // comboBox1
      // 
      comboBox1.Dock = DockStyle.Fill;
      comboBox1.FormattingEnabled = true;
      comboBox1.Items.AddRange(new object[] { "English", "Dutch" });
      comboBox1.Location = new Point(597, 153);
      comboBox1.Margin = new Padding(15);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(164, 23);
      comboBox1.TabIndex = 5;
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Dock = DockStyle.Left;
      label3.Font = new Font("Segoe UI", 37F, FontStyle.Regular, GraphicsUnit.Point);
      label3.ForeColor = Color.White;
      label3.ImageAlign = ContentAlignment.MiddleLeft;
      label3.Location = new Point(3, 138);
      label3.Name = "label3";
      label3.Size = new Size(420, 69);
      label3.TabIndex = 4;
      label3.Text = "Choose language:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Dock = DockStyle.Left;
      label2.Font = new Font("Segoe UI", 37F, FontStyle.Regular, GraphicsUnit.Point);
      label2.ForeColor = Color.White;
      label2.ImageAlign = ContentAlignment.MiddleLeft;
      label2.Location = new Point(3, 69);
      label2.Name = "label2";
      label2.Size = new Size(383, 69);
      label2.TabIndex = 1;
      label2.Text = "Start minimized:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Dock = DockStyle.Left;
      label1.Font = new Font("Segoe UI", 37F, FontStyle.Regular, GraphicsUnit.Point);
      label1.ForeColor = Color.White;
      label1.ImageAlign = ContentAlignment.MiddleLeft;
      label1.Location = new Point(3, 0);
      label1.Name = "label1";
      label1.Size = new Size(234, 69);
      label1.TabIndex = 0;
      label1.Text = "Currency:";
      // 
      // StartMinimizedCheckbox
      // 
      StartMinimizedCheckbox.AutoSize = true;
      StartMinimizedCheckbox.Dock = DockStyle.Fill;
      StartMinimizedCheckbox.Location = new Point(602, 69);
      StartMinimizedCheckbox.Margin = new Padding(20, 0, 20, 0);
      StartMinimizedCheckbox.Name = "StartMinimizedCheckbox";
      StartMinimizedCheckbox.Size = new Size(154, 69);
      StartMinimizedCheckbox.TabIndex = 2;
      StartMinimizedCheckbox.TextAlign = ContentAlignment.MiddleCenter;
      StartMinimizedCheckbox.UseVisualStyleBackColor = true;
      StartMinimizedCheckbox.CheckedChanged += StartMinimizedCheckbox_CheckedChanged;
      // 
      // CurrencycomboBox
      // 
      CurrencycomboBox.Dock = DockStyle.Fill;
      CurrencycomboBox.FormattingEnabled = true;
      CurrencycomboBox.Items.AddRange(new object[] { "EUR", "USD", "GBP", "JPY" });
      CurrencycomboBox.Location = new Point(597, 15);
      CurrencycomboBox.Margin = new Padding(15);
      CurrencycomboBox.Name = "CurrencycomboBox";
      CurrencycomboBox.Size = new Size(164, 23);
      CurrencycomboBox.TabIndex = 3;
      CurrencycomboBox.SelectedIndexChanged += CurrencycomboBox1_SelectedIndexChanged;
      // 
      // ClearMoneyBtn
      // 
      ClearMoneyBtn.Dock = DockStyle.Fill;
      ClearMoneyBtn.Location = new Point(596, 221);
      ClearMoneyBtn.Margin = new Padding(14);
      ClearMoneyBtn.Name = "ClearMoneyBtn";
      ClearMoneyBtn.Size = new Size(166, 41);
      ClearMoneyBtn.TabIndex = 7;
      ClearMoneyBtn.Text = "Clear";
      ClearMoneyBtn.UseVisualStyleBackColor = true;
      ClearMoneyBtn.Click += ClearMoneyBtn_Click;
      // 
      // FormOptions
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "FormOptions";
      Text = "FormOptions";
      Load += FormOptions_Load;
      panel1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private Label label2;
    private CheckBox StartMinimizedCheckbox;
    private ComboBox CurrencycomboBox;
    private Label label3;
    private ComboBox comboBox1;
    private Label label4;
    private Button ClearMoneyBtn;
  }
}