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

    static void FillChartline(bool UseMonth, Chart LineChart)
    {
      if (UseMonth)
      {
        DirectoryInfo[] Folders = TextFileHandler.GetAllTextFileFolder();

        int Index = 0;
        foreach (DirectoryInfo Folder in Folders)
        {
          if (!Folder.Name.EndsWith(DateTime.Now.ToString("yyyy")))
          {
            Folders = TextFileHandler.RemoveIndices(Folders, Index);
          }
          Index++;
        }

        List<string> lineChartX = new List<string>();
        List<double> lineChartY = new List<double>();
        int monthIndex = 1;

        foreach (DirectoryInfo Folder in Folders)
        {
          double expense = TextFileHandler.ProcessExpenseFile(Folder);
          lineChartY.Add(expense);

          string[] folderNameParts = Folder.Name.Split('-');
          if (folderNameParts.Length >= 2)
          {
            int monthNumber = int.Parse(folderNameParts[0].Trim());

            DateTimeFormatInfo dateFormatInfo = DateTimeFormatInfo.CurrentInfo;
            string MonthName = dateFormatInfo.GetMonthName(monthNumber);
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            lineChartX.Add(textInfo.ToTitleCase(MonthName));
          }
          else
          {
            // Handle the case where the folder name doesn't contain a valid month
            lineChartX.Add("Unknown");
          }

          // Increment the month index
          monthIndex++;
        }

        LineChart.Series["Money"].Points.DataBindXY(lineChartX, lineChartY);
      }
      else
      {
        DirectoryInfo[] Folders = TextFileHandler.GetAllTextFileFolder();
        Dictionary<int, float> YearlyExpenses = new Dictionary<int, float>();

        // Initialize the dictionary with all years found in folders
        foreach (DirectoryInfo Folder in Folders)
        {
          string[] FolderName = Folder.Name.Split('-');
          if (int.TryParse(FolderName[1], out int folderYear))
          {
            YearlyExpenses[folderYear] = 0;
          }
        }

        // Accumulate expenses for folders with the same year
        foreach (DirectoryInfo Folder in Folders)
        {
          string[] FolderName = Folder.Name.Split('-');
          if (int.TryParse(FolderName[1], out int folderYear))
          {
            float expense = TextFileHandler.ProcessExpenseFile(Folder);

            // Instead of assigning the expense directly, accumulate it.
            YearlyExpenses[folderYear] += expense;
          }
        }

        // Prepare data for the line chart with all years
        List<int> lineChartX = new List<int>();
        List<float> lineChartY = new List<float>();

        // Find the minimum and maximum years
        int minYear = YearlyExpenses.Keys.Min();
        int maxYear = YearlyExpenses.Keys.Max();

        // Fill in the years within the range
        for (int year = minYear; year <= maxYear; year++)
        {
          lineChartX.Add(year);
          if (YearlyExpenses.ContainsKey(year))
          {
            lineChartY.Add(YearlyExpenses[year]);
          }
          else
          {
            lineChartY.Add(0);
          }
        }

        LineChart.Series["Money"].Points.DataBindXY(lineChartX, lineChartY);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string? Value = this.MonthYearComboBox.SelectedItem?.ToString();
      Chart Chart = this.chart1;

      if (Value == "Months")
      {
        FillChartline(true, Chart);
      }
      else if (Value == "Years")
      {
        FillChartline(false, Chart);
      }
      else
      {
        MessageBox.Show($"ERROR: Incorrect value; {Value}");
      }
    }

  }
}
