using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MoneyTrackerApp.Assests
{
  public class SettingsHandler
  {
    public static dynamic GetAllConfig()
    {
      string jsonFileName = "settings.json";
      string AssestsFolder = Path.Combine(GetProjectDirectory(), "Assests/");
      string jsonFilePath = Path.Combine(AssestsFolder, jsonFileName);

      IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile(jsonFilePath)
    .Build();

      Dictionary<string, string> AllSettings = new Dictionary<string, string>();

      // Retrieve settings from the configuration file and store them in the dictionary
      AllSettings["Currency"] = config["Currency"];
      AllSettings["StartMinimized"] = config["StartMinimized"];

      return AllSettings;
    }

    public static void SetConfig(string key, string value)
    {
      // Create a dictionary to hold the existing settings
      var existingSettings = new Dictionary<string, string>(GetAllConfig());

      // Modify the desired key-value pair
      existingSettings[key] = value;

      // Write the updated configuration back to the JSON file
      var configBuilder = new ConfigurationBuilder();
      configBuilder.AddInMemoryCollection(existingSettings);
      var newConfig = configBuilder.Build();
      var updatedSettingsArray = existingSettings.Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value)).ToArray();

      string jsonFileName = "settings.json";
      string AssestsFolder = Path.Combine(GetProjectDirectory(), "Assests/");
      string jsonFilePath = Path.Combine(AssestsFolder, jsonFileName);

      // Write the updated configuration back to the JSON file
      using (var streamWriter = new StreamWriter(jsonFilePath))
      {
        streamWriter.WriteLine("{");
        for (int i = 0; i < updatedSettingsArray.Length; i++)
        {
          var setting = updatedSettingsArray[i];
          string line = $"\"{setting.Key}\": \"{setting.Value}\"";
          if (i < updatedSettingsArray.Length - 1)
          {
            line += ",";
          }
          streamWriter.WriteLine(line);
        }
        streamWriter.WriteLine("}");
        streamWriter.Close();
      }
    }

    static private string GetProjectDirectory()
    {
      string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
      string projectDirectory = Directory.GetParent(currentDirectory)?.FullName;
      string projectDirectory2 = Directory.GetParent(projectDirectory)?.FullName;
      string projectDirectory3 = Directory.GetParent(projectDirectory2)?.FullName;
      string projectDirectory4 = Directory.GetParent(projectDirectory3)?.FullName;

      return projectDirectory4;
    }

  }
}
