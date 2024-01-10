using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyTrackerApp.Assests;
using MoneyTrackerApp.Assests.Expenses;
using MoneyTrackerApp.Assests.Language;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Util;

namespace MoneyTrackerApp.Tabs
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      LoadLocalizedResources();
      RefreshData(this);
    }

    private static dynamic localizedResources;
    private void LoadLocalizedResources()
    {
      //ResourceHandler resourceHandler = new ResourceHandler();
      localizedResources = ResourceHandler.LoadResourceFile();

    }

    static void RefreshData(MainForm frm, StreamReader sr = null)
    {
      #region Basic strings
      frm.TypeNewLabel.Text = localizedResources.TypeNewHere;
      frm.AddDataSubmitButton.Text = localizedResources.ButtonSubmit;
      frm.GoalSubmit.Text = localizedResources.ButtonSubmit;

      #endregion

      #region Money Tables
      ListView PlusTable = frm.listViewPlus;
      ListView MinusTable = frm.listViewMinus;
      Label SumText = frm.MoneySum;

      PlusTable.Items.Clear();
      MinusTable.Items.Clear();

      int totalMoney = 0;
      var currency = new Dictionary<string, string>(SettingsHandler.GetAllConfig());
      string currencyCode = currency["Currency"];

      // Assume there's a method to initialize the database; you can call DatabaseHandler.InitializeDatabase()
      DatabaseHandler.InitializeDatabase();

      using (SQLiteConnection connection = new SQLiteConnection(DatabaseHandler.connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "SELECT Sign, Value, Description FROM Expenses WHERE Date = @Date";
          command.Parameters.AddWithValue("@Date", DatabaseHandler.GetCurrentMonthYear());

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              char sign = Convert.ToChar(reader["Sign"]);
              int value = Convert.ToInt32(reader["Value"]);

              string description = reader.IsDBNull(reader.GetOrdinal("Description"))
                ? string.Empty
                : reader["Description"].ToString();

              if (sign == '+')
              {
                totalMoney += value;
                string convertedLine = $"+{DatabaseHandler.CalculateCurrency(value, currencyCode)} {description}";
                AddDataToListView(PlusTable, convertedLine);
              }
              else if (sign == '-')
              {
                totalMoney -= value;
                string convertedLine = $"-{DatabaseHandler.CalculateCurrency(value, currencyCode)} {description}";
                AddDataToListView(MinusTable, convertedLine);
              }
            }
          }
        }
      }

      double total = (double)totalMoney; // Ensure total is a double
      string convertedAmount = DatabaseHandler.CalculateCurrency(total, currencyCode);
      SumText.Text = $"{localizedResources.Total}: {convertedAmount}";
      #endregion

      #region Goal ProgressBar
      CircleProgressBar GoalProgresbar = frm.GoalProgressBar1;
      Label GoalLabel = frm.GoalLabel;
      System.Windows.Forms.Panel GoalPanel = frm.GoalPanel;

      int goal = DatabaseHandler.GetGoal();

      if (goal > 0)
      {
        double procentGoal = (double)total / goal * 100;
        int procent = (int)Math.Round(procentGoal);
        GoalProgresbar.Value = procent;
        GoalLabel.Text = localizedResources.GoalCloseText;
      }
      else
      {
        GoalLabel.Text = localizedResources.NoGoalText;
      }

      #endregion


      //sr.Close();
    }

    static void AddDataToListView(ListView Table, string line)
    {
      Table.Items.Add(line);
    }


    private void MainForm_Load(object sender, EventArgs e)
    {
      this.ControlBox = false;
    }

    private void AddDataAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
      {
        e.Handled = true;
      }

      // only allow one decimal point
      if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
      {
        e.Handled = true;
      }
    }

    private void AddDataSubmitButton_Click(object sender, EventArgs e)
    {
      ComboBox PlusMinus = this.PlusMinusComboBox;
      TextBox Amount = this.AddDataAmount;
      TextBox Text = this.AddDataText;

      string MinusPlusBox = PlusMinus.SelectedItem.ToString();
      string DataAmount = Amount.Text;
      string DataText = Text.Text;

      // Assuming there's a method to initialize the database; you can call DatabaseHandler.InitializeDatabase()
      DatabaseHandler.InitializeDatabase();
      DatabaseHandler.InsertExpense(MinusPlusBox, int.Parse(DataAmount), DataText);

      RefreshData(this);

      Amount.Text = "";
      Text.Text = "";
    }



    private void GoalSubmit_Click(object sender, EventArgs e)
    {
      TextBox GoalAmount = this.GoalAmount;
      string Amount = GoalAmount.Text;

      DatabaseHandler.SetGoal(int.Parse(Amount));
      RefreshData(this);
    }

    private void GoalAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
      {
        e.Handled = true;
      }

      // only allow one decimal point
      if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
      {
        e.Handled = true;
      }
    }
  }
}
