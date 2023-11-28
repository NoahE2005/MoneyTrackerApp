using BlazorCharts;
using MoneyTrackerApp.Assests.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyTrackerApp.Tabs
{
  public partial class FormDashboard : Form
  {
    public FormDashboard()
    {
      InitializeComponent();

      Chart Chart = this.chart1;
      Chart.Series["Money"].Color = Color.Green;
      FillChartline(true, Chart);
    }

    private void FormDashboard_Load(object sender, EventArgs e)
    {
      this.ControlBox = false;


    }

    static void FillChartline(bool useMonth, Chart lineChart)
    {
      // Assuming there's a method to initialize the database; you can call DatabaseHandler.InitializeDatabase()
      DatabaseHandler.InitializeDatabase();

      if (useMonth)
      {
        List<string> lineChartX = new List<string>();
        List<double> lineChartY = new List<double>();

        List<ExpenseData> monthlyExpenses = DatabaseHandler.GetAllMonthlyExpenses();

        foreach (ExpenseData expenseData in monthlyExpenses)
        {
          lineChartX.Add(expenseData.MonthName);
          lineChartY.Add(expenseData.Expense);
        }

        lineChart.Series["Money"].Points.DataBindXY(lineChartX, lineChartY);
      }
      else
      {
        List<int> lineChartX = new List<int>();
        List<float> lineChartY = new List<float>();

        Dictionary<int, Tuple<float, int>> yearlyExpenses = DatabaseHandler.GetAllYearlyExpensesWithMonthCount();

        // Prepare data for the line chart with all years
        foreach (var kvp in yearlyExpenses)
        {
          lineChartX.Add(kvp.Key);
          lineChartY.Add(kvp.Value.Item1); // Item1 is the total expense
        }

        lineChart.Series["Money"].Points.DataBindXY(lineChartX, lineChartY);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string? value = this.MonthYearComboBox.SelectedItem?.ToString();
      Chart chart = this.chart1;

      if (value == "Months")
      {
        FillChartline(true, chart);
      }
      else if (value == "Years")
      {
        FillChartline(false, chart);
      }
      else
      {
        MessageBox.Show($"ERROR: Incorrect value; {value}");
      }
    }

  }
}
