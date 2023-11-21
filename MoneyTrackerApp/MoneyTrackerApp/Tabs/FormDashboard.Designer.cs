using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyTrackerApp.Tabs
{
  partial class FormDashboard
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
      ChartArea chartArea2 = new ChartArea();
      Legend legend2 = new Legend();
      Series series2 = new Series();
      panel1 = new Panel();
      tableLayoutPanel1 = new TableLayoutPanel();
      chart1 = new Chart();
      MonthYearComboBox = new ComboBox();
      panel1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
      tableLayoutPanel1.Controls.Add(chart1, 1, 0);
      tableLayoutPanel1.Controls.Add(MonthYearComboBox, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(10);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(800, 450);
      tableLayoutPanel1.TabIndex = 3;
      // 
      // chart1
      // 
      chart1.BackColor = Color.DimGray;
      chart1.BorderlineColor = Color.Black;
      chartArea2.BackColor = Color.FromArgb(84, 84, 84);
      chartArea2.BorderColor = Color.DimGray;
      chartArea2.Name = "ChartArea1";
      chart1.ChartAreas.Add(chartArea2);
      chart1.Dock = DockStyle.Fill;
      legend2.BackColor = Color.FromArgb(90, 90, 90);
      legend2.Name = "Legend1";
      chart1.Legends.Add(legend2);
      chart1.Location = new Point(175, 15);
      chart1.Margin = new Padding(15, 15, 15, 20);
      chart1.Name = "chart1";
      chart1.Palette = ChartColorPalette.Berry;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = SeriesChartType.Spline;
      series2.LabelBackColor = Color.FromArgb(64, 64, 64);
      series2.Legend = "Legend1";
      series2.Name = "Money";
      chart1.Series.Add(series2);
      chart1.Size = new Size(610, 415);
      chart1.TabIndex = 2;
      chart1.Text = "chart1";
      // 
      // MonthYearComboBox
      // 
      MonthYearComboBox.BackColor = Color.FromArgb(64, 64, 64);
      MonthYearComboBox.Cursor = Cursors.Hand;
      MonthYearComboBox.Dock = DockStyle.Top;
      MonthYearComboBox.Font = new Font("Franklin Gothic Demi Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
      MonthYearComboBox.ForeColor = Color.White;
      MonthYearComboBox.FormattingEnabled = true;
      MonthYearComboBox.Items.AddRange(new object[] { "Months", "Years" });
      MonthYearComboBox.Location = new Point(10, 15);
      MonthYearComboBox.Margin = new Padding(10, 15, 10, 10);
      MonthYearComboBox.Name = "MonthYearComboBox";
      MonthYearComboBox.Size = new Size(140, 24);
      MonthYearComboBox.TabIndex = 1;
      MonthYearComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // FormDashboard
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "FormDashboard";
      Text = "FormDashboard";
      Load += FormDashboard_Load;
      panel1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private ComboBox MonthYearComboBox;
    private Chart chart1;
    private TableLayoutPanel tableLayoutPanel1;
  }
}