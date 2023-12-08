using MoneyTrackerApp.Assests;
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
using static System.Net.Mime.MediaTypeNames;

namespace MoneyTrackerApp.Tabs
{
  public partial class FormOptions : Form
  {
    public FormOptions()
    {
      InitializeComponent();
    }

    private void SetupOptions()
    {
      var Settings = new Dictionary<string, string>(SettingsHandler.GetAllConfig());

      #region Currency
      ComboBox CurrencycomboBox1 = this.CurrencycomboBox;
      CurrencycomboBox1.SelectedValue = Settings.ContainsKey("Currency") ? Settings["Currency"] : "EUR";
      #endregion

      #region StartMinimized
      CheckBox StartMinimizedCheckbox = this.StartMinimizedCheckbox;

      if (Settings["StartMinimized"] == "True")
      {
        StartMinimizedCheckbox.Checked = true;
      }
      else if (Settings["StartMinimized"] == "False")
      {
        StartMinimizedCheckbox.Checked = false;
      }
      #endregion
    }

    private void FormOptions_Load(object sender, EventArgs e)
    {
      this.ControlBox = false;
    }

    private void StartMinimizedCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox StartMinimizedCheckbox = this.StartMinimizedCheckbox;
      SettingsHandler.SetConfig("StartMinimized", StartMinimizedCheckbox.Checked.ToString());
    }

    private void CurrencycomboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox CurrencycomboBox1 = this.CurrencycomboBox;
      string? Value = CurrencycomboBox1.SelectedItem?.ToString();

      SettingsHandler.SetConfig("Currency", Value);
      MessageBox.Show("Please restart the application to apply the changes", "Currency Changed", MessageBoxButtons.OK);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      SettingsHandler.SetConfig("Langauge", comboBox1.SelectedItem.ToString());
    }

    private void ClearMoneyBtn_Click(object sender, EventArgs e)
    {
      // Assuming there's a method to initialize the database; you can call DatabaseHandler.InitializeDatabase()
      DatabaseHandler.InitializeDatabase();

      // Clear the database
      DatabaseHandler.ClearDatabase();
    }
  }
}
