using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyTrackerApp.Assests;
using MoneyTrackerApp.Assests.Expenses;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Util;

namespace MoneyTrackerApp.Tabs
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      RefreshData(this);
    }

    static void RefreshData(MainForm frm, StreamReader sr = null)
    {
      #region Money Tables
      ListView PlusTable = frm.listViewPlus;
      ListView MinusTable = frm.listViewMinus;
      Label SumText = frm.MoneySum;

      PlusTable.Items.Clear();
      MinusTable.Items.Clear();

      int TotaalMoney = 0;
      string textFilePath = TextFileHandler.GetTextFilePath()[0];
      var Currency = new Dictionary<string, string>(SettingsHandler.GetAllConfig());
      string currencyCode = Currency["Currency"];
      if (sr == null)
      {
        sr = new StreamReader(textFilePath);
      }
      string line;

      while ((line = sr.ReadLine()) != null)
      {
        if (line.StartsWith("+"))
        {
          String?[] Newline = line.Split(" ");
          string number = Newline[1];
          TotaalMoney += int.Parse(number);
          string convertedLine = $"{Newline[0]}{TextFileHandler.CalculateCurrency(double.Parse(number), currencyCode)} {Newline[2]} {Newline[3]}";
          AddDataToListView(PlusTable, convertedLine);
        }
        else
        {
          if (line.StartsWith('-'))
          {
            String?[] Newline = line.Split(" ");
            string number = Newline[1];
            TotaalMoney -= int.Parse(number);
            string convertedLine = $"{Newline[0]}{TextFileHandler.CalculateCurrency(double.Parse(number), currencyCode)} {Newline[2]} {Newline[3]}";
            AddDataToListView(MinusTable, convertedLine);
          }
        }
      }
      double Totaal = (double)TotaalMoney; // Ensure Totaal is a double
      string convertedAmount = TextFileHandler.CalculateCurrency(Totaal, currencyCode);
      SumText.Text = $"Totaal: {convertedAmount}";
      #endregion

      #region Goal ProgressBar
      CircleProgressBar GoalProgresbar = frm.GoalProgressBar1;
      Label GoalLabel = frm.GoalLabel;
      System.Windows.Forms.Panel GoalPanel = frm.GoalPanel;

      string GoalFilePath = TextFileHandler.GetTextFilePath()[1];
      StreamReader GoalReader = new StreamReader(GoalFilePath);
      string GoalLine = GoalReader.ReadLine();

      if (GoalLine != null)
      {
        int Goal = int.Parse(GoalLine);
        double ProcentGoal = (double)TotaalMoney / Goal * 100;
        int Procent = (int)Math.Round(ProcentGoal);
        GoalProgresbar.Value = Procent;
        //GoalPanel.
      }
      else
      {
        GoalLabel.Text = "Oops, you dont have a goal yet. Write one down";
      }

      #endregion

      sr.Close();
      GoalReader.Close();
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

      string textFilePath = TextFileHandler.GetTextFilePath()[0];
      int retryCount = 3;
      int retryDelayMs = 100;

      while (retryCount > 0)
      {
        try
        {
          using (StreamWriter w = File.AppendText(textFilePath))
          {
            string TextToWrite = $"{MinusPlusBox} {DataAmount} | {DataText}";
            w.WriteLine();
            w.Write(TextToWrite);
            w.Close();
          }

          break;
        }
        catch (IOException ex)
        {
          retryCount--;
          Thread.Sleep(retryDelayMs);
          if (retryCount == 0)
          {
            MessageBox.Show($"Unable to access the file after multiple retries. Error: {ex.Message}");
          }
        }
      }
      RefreshData(this);

      Amount.Text = "";
      Text.Text = "";
    }

    private void GoalSubmit_Click(object sender, EventArgs e)
    {
      TextBox GoalAmount = this.GoalAmount;
      string Amount = GoalAmount.Text;

      string textFilePath = TextFileHandler.GetTextFilePath()[1];
      int retryCount = 3;
      int retryDelayMs = 100;

      while (retryCount > 0)
      {
        try
        {
          using (StreamWriter w = new StreamWriter(textFilePath, false))
          {
            string TextToWrite = Amount;
            w.WriteLine(TextToWrite);
            w.Close();
          }

          break;
        }
        catch (IOException ex)
        {
          retryCount--;
          Thread.Sleep(retryDelayMs);
          if (retryCount == 0)
          {
            MessageBox.Show($"Unable to access the file after multiple retries. Error: {ex.Message}");
          }
        }
      }
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
