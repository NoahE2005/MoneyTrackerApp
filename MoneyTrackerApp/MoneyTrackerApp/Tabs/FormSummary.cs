using MoneyTrackerApp.Assests.Expenses;
using MoneyTrackerApp.Assests.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTrackerApp.Tabs
{
  public partial class FormSummary : Form
  {
    public FormSummary()
    {
      InitializeComponent();

      DirectoryInfo[] diArr = TextFileHandler.GetAllTextFileFolder();

      #region Setup Combobox
      ComboBox YearCombobox = this.YearComboBox;

      HashSet<string> uniqueYears = new HashSet<string>();

      foreach (DirectoryInfo Testdi in diArr)
      {
        string[] parts = Testdi.Name.Split('-');
        if (parts.Length == 2)
        {
          string year = parts[1];
          if (!uniqueYears.Contains(year))
          {
            YearCombobox.Items.Add(year);
            uniqueYears.Add(year);
          }
        }
      }
      #endregion
      LoadLocalizedResources();
    }

    private static dynamic localizedResources;

    private void LoadLocalizedResources()
    {
      //ResourceHandler resourceHandler = new ResourceHandler();
      localizedResources = ResourceHandler.LoadResourceFile();
    }
    private void FormSummary_Load(object sender, EventArgs e)
    {
      this.ControlBox = false;
    }

    private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      #region YearComboBox Code
      string selectedYear = YearComboBox.SelectedItem?.ToString();
      Label SummaryLabel = this.SummaryLabel;

      if (selectedYear != null)
      {
        try
        {
          Dictionary<int, Tuple<float, int>> yearlyExpenses = DatabaseHandler.GetAllYearlyExpensesWithMonthCount();

          int TotaalPlus = 0;
          int TotaalMinus = 0;
          int ExpenseFileCount = 0;

          foreach (var yearExpense in yearlyExpenses)
          {
            int year = yearExpense.Key;
            float expense = yearExpense.Value.Item1; // Item1 is the total expense

            if (year == int.Parse(selectedYear))
            {
              if (expense > 0)
              {
                TotaalPlus += (int)expense;
              }
              else
              {
                TotaalMinus -= (int)Math.Abs(expense);
              }

              ExpenseFileCount += yearExpense.Value.Item2; // Item2 is the count of months
            }
          }

          int TotaalSum = TotaalPlus - TotaalMinus;
          double average = ExpenseFileCount > 0 ? (double)TotaalSum / ExpenseFileCount : 0.0;

          string prompt;
          if (average < 100) // Adjust this threshold as needed
          {
            prompt = $"{localizedResources.SummaryBad.Replace("\\n", "\n").Replace("{ExpenseFileCount}", ExpenseFileCount.ToString()).Replace("{TotaalSum}", TotaalSum.ToString())}";
          }
          else
          {
            prompt = $"{localizedResources.SummaryGood.Replace("\\n", "\n").Replace("{ExpenseFileCount}", ExpenseFileCount.ToString()).Replace("{TotaalSum}", TotaalSum.ToString())}";
          }

          SummaryLabel.Text = prompt;
          //MessageBox.Show(prompt);

          // Ai generate text using prompt
        }
        catch (Exception ex)
        {
          // Handle the exception or log it for debugging.
          MessageBox.Show($"An error occurred: {ex.Message}");
        }
      }
      #endregion
    }



  }
}
