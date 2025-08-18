// Balance Checker
// Given a list of daily transactions (amount, type), where type is "credit" or "debit", return:
// The final balance
// The highest balance at any point in time
// Example:
// transactions = [
//   (100, "credit"),
//   (50, "debit"),
//   (500, "credit"),
//   (200, "debit")
// ]

public class Trnsction
{
  public decimal amount { get; set; }
  public string type { get; set; }
}

public class TestBalanceChecker
{
  public static void Main()
  {
    var transactions = new List<Trnsction>
        {
            new Trnsction { amount = 100, type = "credit" },
            new Trnsction { amount = 50, type = "debit" },
            new Trnsction { amount = 500, type = "credit" },
            new Trnsction { amount = 200, type = "debit" }
        };

    var balanceChecker = new TestBalanceChecker();
    var result = balanceChecker.CheckBalance(transactions);

    Console.WriteLine($"Final Balance: {result.FinalBalance}");
    Console.WriteLine($"Highest Balance: {result.HighestBalance}");
  }

  public class BalanceResult
  {
    public decimal FinalBalance { get; set; }
    public decimal HighestBalance { get; set; }
  }

  private BalanceResult CheckBalance(List<Trnsction> transactions)
  {
    decimal balance = 0;
    decimal highestBalance = 0;

    foreach (var transaction in transactions)
    {
      if (transaction.type == "credit")
      {
        balance += transaction.amount;
      }
      else if (transaction.type == "debit")
      {
        balance -= transaction.amount;
      }

      if (balance > highestBalance)
      {
        highestBalance = balance;
      }
    }

    return new BalanceResult { FinalBalance = balance, HighestBalance = highestBalance };
  }
}