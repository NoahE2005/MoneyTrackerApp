using MoneyTrackerApp.Assests;
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
using static System.Net.Mime.MediaTypeNames;

namespace MoneyTrackerApp.Tabs
{
  public partial class FormOptions : Form
  {
    public FormOptions()
    {
      InitializeComponent();
      LoadLocalizedResources();
      SetupOptions();
    }

    private static dynamic localizedResources;
    private void LoadLocalizedResources()
    {
      ResourceHandler resourceHandler = new ResourceHandler();
      localizedResources = resourceHandler.LoadResourceFile();
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

      #region Language input
      ComboBox languageComboBox = this.comboBox1;
      languageComboBox.SelectedValue = Settings.ContainsKey("Language") ? Settings["Language"] : "English";
      #endregion

      #region String Langauge
      this.label1.Text = localizedResources.Currency; //Currency
      this.label2.Text = localizedResources.StartMinimized; //Start minimized
      this.label3.Text = localizedResources.ChooseLanguage; //Choose language
      this.label4.Text = localizedResources.ClearMoney; //Clear money


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

      bool result = SettingsHandler.SetConfig("Currency", Value);
      if (result)
      {
        MessageBox.Show(localizedResources.SettingChanged, localizedResources.CurrencyChanged, MessageBoxButtons.OK);
      }
      else
      {
        MessageBox.Show(localizedResources.ChangeFailed, localizedResources.NoChange, MessageBoxButtons.OK);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      bool result = SettingsHandler.SetConfig("Language", comboBox1.SelectedItem.ToString());
      if (result)
      {
        MessageBox.Show(localizedResources.SettingChanged, localizedResources.LanguageChanged, MessageBoxButtons.OK);
      }
      else
      {
        MessageBox.Show(localizedResources.ChangeFailed, localizedResources.NoChange, MessageBoxButtons.OK);
      }
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
