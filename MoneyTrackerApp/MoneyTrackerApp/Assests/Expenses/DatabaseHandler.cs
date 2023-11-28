using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTrackerApp.Assests.Expenses
{
  public class ExpenseData
  {
    public string MonthName { get; set; }
    public double Expense { get; set; }

    public ExpenseData(string monthName, double expense)
    {
      MonthName = monthName;
      Expense = expense;
    }
  }
  internal class DatabaseHandler
  {
    public static string connectionString = "Data Source=ExpenseDatabase.db;Version=3;";
    private static string FileFormat = "MM-yyyy";

    public static string GetCurrentMonthYear()
    {
      DateTime currentDate = DateTime.Now;
      return $"{currentDate.ToString(FileFormat)}";
    }

    public static void InitializeDatabase()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          // Check if Expenses table exists
          command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Expenses'";
          var expensesTableExists = command.ExecuteScalar() != null;

          if (!expensesTableExists)
          {
            // Create Expenses table if not exists
            command.CommandText = "CREATE TABLE Expenses (Sign TEXT, Value INTEGER, Description TEXT, Date TEXT)";
            command.ExecuteNonQuery();
          }
          else
          {
            // Check if all columns are in the right place
            command.CommandText = "PRAGMA table_info(Expenses)";
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
              List<string> existingColumns = new List<string>();
              while (reader.Read())
              {
                existingColumns.Add(reader["name"].ToString());
              }

              List<string> expectedColumns = new List<string> { "Sign", "Value", "Description", "Date" };

              if (!existingColumns.SequenceEqual(expectedColumns))
              {
                // Columns are not in the right place; recreate the Expenses table
                command.CommandText = "DROP TABLE Expenses";
                command.ExecuteNonQuery();

                command.CommandText = "CREATE TABLE Expenses (Sign TEXT, Value INTEGER, Description TEXT, Date TEXT)";
                command.ExecuteNonQuery();
              }
            }
          }

          // Check if Goal table exists
          command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Goal'";
          var goalTableExists = command.ExecuteScalar() != null;

          if (!goalTableExists)
          {
            // Create Goal table if not exists
            command.CommandText = "CREATE TABLE Goal (Goal INTEGER, Date TEXT)";
            command.ExecuteNonQuery();
          }
          else
          {
            // Check if all columns are in the right place
            command.CommandText = "PRAGMA table_info(Goal)";
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
              List<string> existingColumns = new List<string>();
              while (reader.Read())
              {
                existingColumns.Add(reader["name"].ToString());
              }

              List<string> expectedColumns = new List<string> { "Goal", "Date" };

              if (!existingColumns.SequenceEqual(expectedColumns))
              {
                // Columns are not in the right place; recreate the Goal table
                command.CommandText = "DROP TABLE Goal";
                command.ExecuteNonQuery();

                command.CommandText = "CREATE TABLE Goal (Goal INTEGER, Date TEXT)";
                command.ExecuteNonQuery();
              }
            }
          }
        }
      }
    }

    public static void InsertExpense(string sign, int value, string description)
    {
      string currentMonthYear = GetCurrentMonthYear();

      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "INSERT INTO Expenses (Sign, Value, Description, Date) VALUES (@Sign, @Value, @Description, @Date)";
          command.Parameters.AddWithValue("@Sign", sign);
          command.Parameters.AddWithValue("@Value", value);
          command.Parameters.AddWithValue("@Description", description);
          command.Parameters.AddWithValue("@Date", DatabaseHandler.GetCurrentMonthYear());

          command.ExecuteNonQuery();
        }
      }
    }

    public static int GetTotalExpenses()
    {
      string currentMonthYear = GetCurrentMonthYear();
      int totalExpenses = 0;

      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "SELECT SUM(Value) FROM Expenses WHERE Date = @Date";
          command.Parameters.AddWithValue("@Date", currentMonthYear);

          var result = command.ExecuteScalar();

          if (result != DBNull.Value)
          {
            totalExpenses = Convert.ToInt32(result);
          }
        }
      }

      return totalExpenses;
    }

    public static void ClearDatabase()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "DELETE FROM Expenses";
          command.ExecuteNonQuery();
        }
      }
    }
    public static int GetGoal()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "SELECT Goal FROM Goal";
          var result = command.ExecuteScalar();

          return result != null ? Convert.ToInt32(result) : 0;
        }
      }
    }

    public static void SetGoal(int goal)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "INSERT INTO Goal (Goal, Date) VALUES (@Goal, @Date)";
          command.Parameters.AddWithValue("@Goal", goal);
          command.Parameters.AddWithValue("@Date", GetCurrentMonthYear());

          command.ExecuteNonQuery();
        }
      }
    }

    public static List<ExpenseData> GetAllMonthlyExpenses()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "SELECT strftime('%Y-%m', Date) AS MonthYear, SUM(Value) AS Expense " +
                                "FROM Expenses " +
                                "GROUP BY MonthYear " +
                                "ORDER BY MonthYear";

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            List<ExpenseData> monthlyExpenses = new List<ExpenseData>();
            while (reader.Read())
            {
              string monthYear = reader["MonthYear"].ToString();
              double expense = Convert.ToDouble(reader["Expense"]);
              monthlyExpenses.Add(new ExpenseData(monthYear, expense));
            }

            return monthlyExpenses;
          }
        }
      }
    }

    public static Dictionary<int, float> GetAllYearlyExpenses()
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();

        using (SQLiteCommand command = new SQLiteCommand(connection))
        {
          command.CommandText = "SELECT strftime('%Y', Date) AS Year, SUM(Value) AS Expense " +
                                "FROM Expenses " +
                                "GROUP BY Year " +
                                "ORDER BY Year";

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            Dictionary<int, float> yearlyExpenses = new Dictionary<int, float>();
            while (reader.Read())
            {
              int year = Convert.ToInt32(reader["Year"]);
              float expense = Convert.ToSingle(reader["Expense"]);
              yearlyExpenses[year] = expense;
            }

            return yearlyExpenses;
          }
        }
      }
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
