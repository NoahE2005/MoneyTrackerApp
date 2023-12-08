namespace MoneyTrackerApp.Tabs
{
  partial class FormSummary
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
      panel3 = new Panel();
      tableLayoutPanel2 = new TableLayoutPanel();
      YearComboBox = new ComboBox();
      label1 = new Label();
      panel2 = new Panel();
      SummaryLabel = new Label();
      panel1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      panel3.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      panel2.SuspendLayout();
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
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(panel3, 0, 1);
      tableLayoutPanel1.Controls.Add(panel2, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      tableLayoutPanel1.Size = new Size(800, 450);
      tableLayoutPanel1.TabIndex = 3;
      // 
      // panel3
      // 
      panel3.Controls.Add(tableLayoutPanel2);
      panel3.Dock = DockStyle.Fill;
      panel3.Location = new Point(3, 363);
      panel3.Name = "panel3";
      panel3.Size = new Size(794, 84);
      panel3.TabIndex = 4;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 2;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Controls.Add(YearComboBox, 1, 0);
      tableLayoutPanel2.Controls.Add(label1, 0, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new Point(0, 0);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 1;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Size = new Size(794, 84);
      tableLayoutPanel2.TabIndex = 3;
      // 
      // YearComboBox
      // 
      YearComboBox.BackColor = Color.FromArgb(64, 64, 64);
      YearComboBox.Dock = DockStyle.Left;
      YearComboBox.ForeColor = Color.White;
      YearComboBox.FormattingEnabled = true;
      YearComboBox.Location = new Point(400, 3);
      YearComboBox.Name = "YearComboBox";
      YearComboBox.Size = new Size(121, 23);
      YearComboBox.TabIndex = 1;
      YearComboBox.SelectedIndexChanged += YearComboBox_SelectedIndexChanged;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Dock = DockStyle.Right;
      label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
      label1.ForeColor = Color.White;
      label1.Location = new Point(294, 0);
      label1.Name = "label1";
      label1.Size = new Size(100, 84);
      label1.TabIndex = 2;
      label1.Text = "Select year:";
      // 
      // panel2
      // 
      panel2.BackColor = Color.FromArgb(34, 34, 34);
      panel2.Controls.Add(SummaryLabel);
      panel2.Dock = DockStyle.Fill;
      panel2.Location = new Point(10, 10);
      panel2.Margin = new Padding(10);
      panel2.Name = "panel2";
      panel2.Size = new Size(780, 340);
      panel2.TabIndex = 0;
      // 
      // SummaryLabel
      // 
      SummaryLabel.AutoEllipsis = true;
      SummaryLabel.AutoSize = true;
      SummaryLabel.ForeColor = Color.White;
      SummaryLabel.Location = new Point(3, 9);
      SummaryLabel.MaximumSize = new Size(760, 0);
      SummaryLabel.Name = "SummaryLabel";
      SummaryLabel.Size = new Size(0, 15);
      SummaryLabel.TabIndex = 0;
      // 
      // FormSummary
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "FormSummary";
      Text = "FormSummary";
      Load += FormSummary_Load;
      panel1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      panel3.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
      panel2.ResumeLayout(false);
      panel2.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private ComboBox YearComboBox;
    private Panel panel2;
    private Label label1;
    private Label SummaryLabel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel3;
    private TableLayoutPanel tableLayoutPanel2;
  }
}