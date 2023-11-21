using MoneyTrackerApp.Assests.Expenses;
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
        DirectoryInfo[] diArr = TextFileHandler.GetAllTextFileFolder();

        int TotaalPlus = 0;
        int TotaalMinus = 0;
        int ExpenseFileCount = 0;

        try
        {
          foreach (DirectoryInfo Testdi in diArr)
          {
            if (Testdi.Name.EndsWith(selectedYear))
            {
              FileInfo[] txtFiles = Testdi.GetFiles("Exspense.txt");
              foreach (FileInfo txtFile in txtFiles)
              {
                using (StreamReader sr = txtFile.OpenText())
                {
                  string line;
                  while ((line = sr.ReadLine()) != null)
                  {
                    if (line.Length >= 5)
                    {
                      char sign = line[0];
                      if (sign == '+' || sign == '-')
                      {
                        int value;
                        if (int.TryParse(line.Split(' ')[1], out value))
                        {
                          if (sign == '+')
                          {
                            TotaalPlus += value;
                          }
                          else if (sign == '-')
                          {
                            TotaalMinus += value;
                          }
                        }
                      }
                    }
                  }
                }
                ExpenseFileCount++;
              }
            }
          }

          int TotaalSum = TotaalPlus - TotaalMinus;
          double average = ExpenseFileCount > 0 ? (double)TotaalSum / ExpenseFileCount : 0.0;

          string prompt;
          if (average < 100) // Adjust this threshold as needed
          {
            prompt = $"It hasn't been a good year. The total expenses were {TotaalSum} for {ExpenseFileCount} months.";
          }
          else
          {
            prompt = $"This year was fantastic! The total expenses were {TotaalSum} for {ExpenseFileCount} months.";
          }

          SummaryLabel.Text = prompt;
          //MessageBox.Show(prompt);

          //Ai generate text using prompt
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
