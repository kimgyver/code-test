using System.Text.Json;

public class TestReports
{
  public static void Main()
  {
    var transactionsJson = """
    [
      {"date": "2025-07-01", "amount": 120.5, "type": "credit"},
      {"date": "2025-07-01", "amount": 30.0,  "type": "debit"},
      {"date": "2025-07-02", "amount": 100.0, "type": "credit"}
    ]
    """;
    var transactions = JsonSerializer.Deserialize<List<Transaction>>(transactionsJson);
    var dailyBalance = transactions
      .GroupBy(t => t.date)
      .Select(g => new { Date = g.Key, Balance = g.Sum(t => t.type == "credit" ? t.amount : -t.amount) })
      .ToList();
    Console.WriteLine($@"Daily Balances: {JsonSerializer.Serialize(dailyBalance, new JsonSerializerOptions { WriteIndented = true })}");


    Console.WriteLine("=====================================");
    var invoicesJson = """
      [
        {"id": "INV-001", "customer": "ACME", "amount": 200.0, "status": "paid"},
        {"id": "INV-002", "customer": "ACME", "amount": 300.0, "status": "unpaid"},
        {"id": "INV-003", "customer": "Globex", "amount": 150.0, "status": "paid"}
      ]
    """;
    var paidInvoices = JsonSerializer.Deserialize<List<Invoice>>(invoicesJson)
      .Where(i => i.status == "paid")
      .Select(i => new { i.customer, totalPaid = i.amount })
      .ToList();
    Console.WriteLine($@"Paid Invoices: {JsonSerializer.Serialize(paidInvoices, new JsonSerializerOptions { WriteIndented = true })}");


    Console.WriteLine("=====================================");
    var accountsJson = """
      [
        {"accountId": "A1", "amount": 200.0, "timestamp": "2025-07-22T10:00:00Z"},
        {"accountId": "A2", "amount": 300.0, "timestamp": "2025-07-22T11:00:00Z"},
        {"accountId": "A1", "amount": 300.0, "timestamp": "2025-07-22T12:00:00Z"}
      ]
    """;
    var accounts = JsonSerializer.Deserialize<List<Account>>(accountsJson);
    var balances = accounts
      .GroupBy(a => a.accountId)
      .Select(g => new { AccountId = g.Key, Balance = g.Sum(a => a.amount) })
      .ToList();
    var richestAccount = balances
      .OrderByDescending(b => b.Balance)
      .FirstOrDefault();
    var balancesAndRichestAccount = new
    {
      Balances = balances,
      RichestAccount = richestAccount
    };
    Console.WriteLine($@"Balances and Richest Account: {JsonSerializer.Serialize(balancesAndRichestAccount, new JsonSerializerOptions { WriteIndented = true })}");

    Console.WriteLine("=====================================");
    var billingsJson = """
      [
        {"userId": "U1", "plan": "pro", "amount": 50.0, "timestamp": "2025-07-22T10:00:00Z"},
        {"userId": "U2", "plan": "basic", "amount": 20.0, "timestamp": "2025-07-22T11:00:00Z"},
        {"userId": "U3", "plan": "pro", "amount": 50.0, "timestamp": "2025-07-22T12:00:00Z"}
      ]
      """;
    var billings = JsonSerializer.Deserialize<List<Billing>>(billingsJson);
    var totalBilling = billings
      .GroupBy(b => b.plan)
      .Select(g => new { Plan = g.Key, Total = g.Sum(b => b.amount) })
      .OrderBy(t => t.Plan)
      .ToList();
    var topPlan = totalBilling
      .OrderByDescending(t => t.Total)
      .FirstOrDefault();
    var totalBillingAndTopPlan = new
    {
      PlanTotals = totalBilling,
      TopPlan = topPlan
    };
    Console.WriteLine($@"Total Billing and Top Plan: {JsonSerializer.Serialize(totalBillingAndTopPlan, new JsonSerializerOptions { WriteIndented = true })}");


    Console.WriteLine("=====================================");
    var ticketsStatsJson = """
      [
        {"ticketId": "T1", "status": "open", "priority": "high"},
        {"ticketId": "T2", "status": "closed", "priority": "low"},
        {"ticketId": "T3", "status": "open", "priority": "medium"}
      ]
      """;
    var ticketsStats = JsonSerializer.Deserialize<List<TicketStats>>(ticketsStatsJson);
    var statusCounts = ticketsStats
      .GroupBy(t => t.status)
      .Select(g => new { Status = g.Key, Count = g.Count() })
      .OrderBy(s => s.Status)
      .ToList();
    var priorityCounts = ticketsStats
      .GroupBy(t => t.priority)
      .Select(g => new { Priority = g.Key, Count = g.Count() })
      .OrderBy(p => p.Priority)
      .ToList();
    var ticketsSummary = new
    {
      StatusCounts = statusCounts,
      PriorityCounts = priorityCounts
    };
    Console.WriteLine($@"Tickets Summary: {JsonSerializer.Serialize(ticketsSummary, new JsonSerializerOptions { WriteIndented = true })}");
  }
}

public class Transaction
{
  public string date { get; set; }
  public double amount { get; set; }
  public string type { get; set; }
}

public class Invoice
{
  public string id { get; set; }
  public string customer { get; set; }
  public double amount { get; set; }
  public string status { get; set; }
}

public class Account
{
  public string accountId { get; set; }
  public double amount { get; set; }
  public string timestamp { get; set; }
}

public class Billing
{
  public string userId { get; set; }
  public string plan { get; set; }
  public double amount { get; set; }
  public string timestamp { get; set; }
}

public class TicketStats
{
  public string ticketId { get; set; }
  public string status { get; set; }
  public string priority { get; set; }
}