using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MoneyTrackerApp.Assests.Expenses
{
  public class TextFileHandler
  {
    private static string baseDirectory = null;
    private static string FileFormat = "MM-yyyy";
    private static string[] fileNames = { "Exspense.txt", "Goals.txt" };

    public static string GetCurrentMonthYear()
    {
      DateTime currentDate = DateTime.Now;
      return $"{currentDate.ToString(FileFormat)}";
    }

    public static string[] GetTextFilePath()
    {
      // Get the current directory.
      string currentDirectory = Directory.GetCurrentDirectory();

      // Go up three parent directories from the current directory.
      for (int i = 0; i < 3; i++)
      {
        currentDirectory = Directory.GetParent(currentDirectory)?.FullName;
        if (currentDirectory == null)
        {
          throw new Exception("Unable to determine the base directory.");
        }
      }

      baseDirectory = Path.Combine(currentDirectory, "Assests\\Expenses\\Text\\");
      string monthYear = GetCurrentMonthYear();
      string monthYearWithUppercase = char.ToUpper(monthYear[0]) + monthYear.Substring(1);

      string folderPath = Path.Combine(baseDirectory, monthYearWithUppercase);

      Directory.CreateDirectory(folderPath);

      foreach (var fileName in fileNames)
      {
        string filePath = Path.Combine(folderPath, fileName);

        if (!File.Exists(filePath))
        {
          File.Create(filePath).Dispose();
        }
      }
      string[] FileFull = { Path.Combine(folderPath, fileNames[0]), Path.Combine(folderPath, fileNames[1]) };
      CheckAndFillMissingFiles();
      return FileFull;
    }

    public static dynamic GetAllTextFileFolder()
    {
      // Make a reference to a directory.
      DirectoryInfo di = new DirectoryInfo(baseDirectory);

      // Get a reference to each directory in that directory.
      DirectoryInfo[] diArr = di.GetDirectories();

      return diArr;
    }

    public static void CheckAndFillMissingFiles()
    {
      // Initialize closest and furthest dates with the current date.
      DateTime closestDate = DateTime.Now;
      DateTime furthestDate = DateTime.Now;

      DirectoryInfo[] existingFiles = GetAllTextFileFolder();

      foreach (DirectoryInfo filePath in existingFiles)
      {
        DateTime fileDate = ExtractDateFromFilePath(filePath.ToString());

        // Check for closest date.
        if (fileDate < closestDate)
        {
          closestDate = fileDate;
        }

        // Check for furthest date.
        if (fileDate > furthestDate)
        {
          furthestDate = fileDate;
        }
      }

      // Check for missing files and create them.
      for (DateTime date = closestDate.AddMonths(1); date < furthestDate; date = date.AddMonths(1))
      {
        string monthYear = date.ToString(FileFormat);
        string folderPath = Path.Combine(baseDirectory, char.ToUpper(monthYear[0]) + monthYear.Substring(1));

        foreach (var fileSpots in existingFiles)
        {
          foreach (var fileName in fileNames)
          {
            string filePath = Path.Combine(folderPath, fileName);
            Directory.CreateDirectory(folderPath);

            if (!File.Exists(filePath))
            {
              File.Create(filePath).Dispose();
            }
          }
        }
      }
    }

    // Helper function to extract date from file path.
    private static DateTime ExtractDateFromFilePath(string filePath)
    {
      // Assuming that the date is included in the file name.
      string fileName = Path.GetFileNameWithoutExtension(filePath);
      if (DateTime.TryParseExact(fileName, FileFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fileDate))
      {
        return fileDate;
      }

      // Return DateTime.MinValue if parsing fails.
      return DateTime.MinValue;
    }

    public static dynamic ProcessExpenseFile(DirectoryInfo FilePath)
    {
      FileInfo[] txtFiles = FilePath.GetFiles("Exspense.txt");
      int TotaalPlus = 0;
      int TotaalMinus = 0;

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
          sr.Close();
        }
      }

      return TotaalPlus - TotaalMinus;
    }

    public static DirectoryInfo[] RemoveIndices(DirectoryInfo[] IndicesArray, int RemoveAt)
    {
      DirectoryInfo[] newIndicesArray = new DirectoryInfo[IndicesArray.Length - 1];

      int i = 0;
      int j = 0;
      while (i < IndicesArray.Length)
      {
        if (i != RemoveAt)
        {
          newIndicesArray[j] = IndicesArray[i];
          j++;
        }

        i++;
      }

      return newIndicesArray;
    }

    public static string CalculateCurrency(double AmountInEuro, string Currency)
    {
      // Define exchange rates for different currencies (example rates)
      double euroToUSD = 1.18;
      double euroToGBP = 0.85;
      double euroToJPY = 129.67;

      double convertedAmount = 0;
      int convertedAmountRounded = 0;
      string FullAmount = "";

      switch (Currency.ToUpper())
      {
        case "EUR":
          convertedAmount = AmountInEuro;
          convertedAmountRounded = Convert.ToInt32(convertedAmount);
          FullAmount = $"€{convertedAmountRounded}";
          break;
        case "USD":
          convertedAmount = AmountInEuro * euroToUSD;
          convertedAmountRounded = Convert.ToInt32(convertedAmount);
          FullAmount = $"${convertedAmountRounded}";
          break;
        case "GBP":
          convertedAmount = AmountInEuro * euroToGBP;
          convertedAmountRounded = Convert.ToInt32(convertedAmount);
          FullAmount = $"£{convertedAmountRounded}";
          break;
        case "JPY":
          convertedAmount = AmountInEuro * euroToJPY;
          convertedAmountRounded = Convert.ToInt32(convertedAmount);
          FullAmount = $"¥{convertedAmountRounded}";
          break;
        default:
          Console.WriteLine("Invalid target currency.");
          return "0";
      }

      return FullAmount;
    }

  }
}
