using MoneyTrackerApp.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MoneyTrackerApp.Assests.Language
{
  internal class ResourceHandler
  {
    public dynamic LoadResourceFile()
    {
      string language = SettingsHandler.GetLanguage();
      string languageFolder = Path.Combine(SettingsHandler.GetProjectDirectory(), "Assets/Language/");
      string resourceFileName = $"Resources.{language}.resx";
      string fullPath = Path.Combine(languageFolder, resourceFileName);
      string resource = $"MoneyTrackerApp.Assests.Language.LangaugeResource.{language}";

      // Map full language names to culture codes
      string shortLanguage = MapToCultureCode(language);

      try
      {
        ResourceManager resourceManager = new ResourceManager(resource, Assembly.GetExecutingAssembly());
        ResourceSet resourceSet = resourceManager.GetResourceSet(new CultureInfo(shortLanguage), true, true);

        // Convert ResourceSet to a dynamic object
        dynamic resources = new ExpandoObject();
        foreach (DictionaryEntry entry in resourceSet)
        {
          ((IDictionary<string, object>)resources)[(string)entry.Key] = entry.Value;
        }

        return resources;
      }
      catch (CultureNotFoundException ex)
      {
        Console.WriteLine($"Error loading resources for language '{language}': {ex.Message}");
        return null;
      }
    }

    private string MapToCultureCode(string language)
    {
      // Map full language names to culture codes
      switch (language.ToLower())
      {
        case "english":
          return "en";
        case "dutch":
          return "nl";
        default:
          return "en";
      }
    }

  }
}

