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
            prompt = $"Oh, what a challenging year it has been! 😔\nReflecting on the past months, it's clear that this year presented its share of financial hurdles. 💸 Despite the difficulties, acknowledging and learning from these experiences is crucial. Let's delve into the details of the financial journey over the course of {ExpenseFileCount} months, with total expenses amounting to {TotaalSum}.\n\nThroughout this period, the journey was marked by unexpected twists and turns. Each month brought its unique set of financial challenges, testing resilience and adaptability. Despite the tough times, there's value in recognizing the effort put into managing expenses and navigating through uncertainties. 🔄\n\nThe Money Tracker app, a faithful companion in this financial journey, played a vital role in providing insights and helping make informed decisions. Even in challenging times, having a tool that highlights spending patterns and areas for improvement is crucial. 📉\n\nThe total expenses, while higher than desired, tell a story of survival and determination. This is not just about numbers; it's about the lessons learned, the decisions made, and the resilience shown in the face of adversity. 💪\n\nThe app's feature to categorize expenses proved especially useful during challenging times. It allowed for a closer look at where the money was going, helping identify areas for potential savings and optimizations. 💡\n\nFinancial difficulties often come with valuable insights. Perhaps there were months when unexpected expenses took a toll, but these experiences become stepping stones for future financial strategies. The ability to learn and adapt is a testament to financial maturity. 📚\n\nWhile the overall sentiment might not be celebratory, it's essential to acknowledge the progress made in managing expenses and making informed financial decisions. As we bid farewell to this challenging year, let's carry forward the lessons learned and approach the upcoming year with renewed determination. Here's to a more financially resilient future! 🌟💪";
          }
          else
          {
            prompt = $"Wow, what an incredible year it has been! 🎉\nI'm thrilled to share that this financial journey has been nothing short of fantastic. 🚀\nThroughout the year, diligent tracking and smart financial decisions have paved the way for a brighter financial future. 💰\n\nIn the span of {ExpenseFileCount} months, the journey has been enlightening. Each month brought its own set of challenges and triumphs, ultimately contributing to the overall financial narrative. The total expenses for the year, a sum of {TotaalSum}, tell a story of responsible spending and financial awareness. 📊\n\nAs we reflect on the past months, it's essential to acknowledge the effort put into tracking expenses meticulously. The Money Tracker app has proven to be an invaluable companion, providing insights that empower informed financial decisions. 📈\nFrom daily transactions to monthly budgets, the app has played a pivotal role in shaping a financially sound lifestyle.\n\nOne of the standout features of the app is its ability to break down expenses into categories, offering a detailed analysis of where the money is going. Whether it's entertainment, groceries, or utilities, having a comprehensive breakdown allows for a targeted approach to managing finances. 💡\n\nThe journey wasn't just about cutting expenses; it was also about identifying areas of opportunity and making strategic financial investments. Perhaps there were months with unexpected expenses, but those moments served as lessons in adaptability and resilience. 💪\n\nLooking at the bigger picture, the Money Tracker app has not only been a tool for expense tracking but also a source of motivation. Setting financial goals and seeing them gradually materialize is a testament to the power of intentional money management. 🎯\n\nIn the realm of personal finance, knowledge is indeed power. The app's ability to provide financial insights, trends, and forecasts has empowered better decision-making. It's not just about the past expenses but also about preparing for a more secure and prosperous financial future.\n\nAs we bid farewell to this remarkable year, it's worth appreciating the journey and the financial milestones achieved. The Money Tracker app has been a true ally in this pursuit of financial well-being. Here's to more financial success in the upcoming year! 🌟💸";
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
