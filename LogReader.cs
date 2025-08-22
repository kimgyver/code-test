using System.Globalization;

public class LogEntry
{
  public DateTime Timestamp { get; set; }
  public string? UserId { get; set; }
  public string? Endpoint { get; set; }
  public int StatusCode { get; set; }
}

public class LogReader
{
  public static IEnumerable<LogEntry> ReadLogs(string input, DateTime? start = null, DateTime? end = null)
  {
    IEnumerable<string> lines;

    if (File.Exists(input))
    {
      lines = File.ReadLines(input); // Lazy loading for large files
    }
    else if (input.Contains("\n"))
    {
      lines = input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }
    else
    {
      throw new ArgumentException("Input must be a file path or multi-line log string.");
    }

    return ParseLines(lines)
      .Where(log =>
        (!start.HasValue || log.Timestamp >= start.Value) &&
        (!end.HasValue || log.Timestamp <= end.Value));
  }

  public static IEnumerable<LogEntry> ReadLogs(IEnumerable<string> lines, DateTime? start = null, DateTime? end = null)
  {
    return ParseLines(lines)
      .Where(log =>
        (!start.HasValue || log.Timestamp >= start.Value) &&
        (!end.HasValue || log.Timestamp <= end.Value));
  }

  // Modular parsing logic
  private static IEnumerable<LogEntry> ParseLines(IEnumerable<string> lines)
  {
    foreach (var line in lines)
    {
      var parts = line.Split(',');

      if (parts.Length != 4) continue;

      if (!DateTime.TryParse(parts[0].Trim(), null, DateTimeStyles.RoundtripKind, out DateTime timestamp))
        continue;

      if (!int.TryParse(parts[3].Trim(), out int statusCode))
        continue;

      yield return new LogEntry
      {
        Timestamp = timestamp,
        UserId = parts[1].Trim(),
        Endpoint = parts[2].Trim(),
        StatusCode = statusCode
      };
    }
  }

  // Summary report logic separated for testability
  public static LogSummary GetSummary(IEnumerable<LogEntry> logs)
  {
    var logList = logs as List<LogEntry> ?? logs.ToList();

    var requestsPerUser = logList
      .GroupBy(l => l.UserId ?? "")
      .ToDictionary(g => g.Key, g => g.Count());

    var endpointGroup = logList
      .GroupBy(l => l.Endpoint ?? "")
      .OrderByDescending(g => g.Count())
      .FirstOrDefault();

    var mostHitEndpoint = endpointGroup?.Key;
    var mostHitEndpointCount = endpointGroup?.Count() ?? 0;

    var failedRequestsCount = logList.Count(l => l.StatusCode >= 400);

    return new LogSummary
    {
      TotalRequests = logList.Count,
      RequestsPerUser = requestsPerUser,
      MostHitEndpoint = mostHitEndpoint,
      MostHitEndpointCount = mostHitEndpointCount,
      FailedRequestsCount = failedRequestsCount
    };
  }

  static public void RunTest()
  {
    string logString = """
2025-08-12T10:15:00Z, user1, /login, 200
2025-08-12T10:16:12Z, user1, /products, 200
2025-08-12T10:18:34Z, user2, /login, 403
2025-08-12T10:19:49Z, user3, /main, 202
2025-08-12T10:21:59Z, user3, /login, 200
2025-08-12T11:30:05Z, user1, /logout, 200
""";

    var logs = ReadLogs(logString);

    foreach (var log in logs)
    {
      Console.WriteLine($"{log.Timestamp:o} | {log.UserId} | {log.Endpoint} | {log.StatusCode}");
    }

    // Generate and display summary
    var summary = GetSummary(ReadLogs(logString));
    Console.WriteLine($"Total Requests: {summary.TotalRequests}");

    Console.WriteLine("Requests per User:");
    foreach (var user in summary.RequestsPerUser)
    {
      Console.WriteLine($"{user.Key}: {user.Value}");
    }

    Console.WriteLine($"Most Hit Endpoint: {summary.MostHitEndpoint} with {summary.MostHitEndpointCount} hits");
    Console.WriteLine($"Failed Requests Count: {summary.FailedRequestsCount}");
  }
}

// Modular summary classes for testability
public class LogSummary
{
  public int TotalRequests { get; set; }
  public Dictionary<string, int> RequestsPerUser { get; set; } = new();
  public string? MostHitEndpoint { get; set; }
  public int MostHitEndpointCount { get; set; }
  public int FailedRequestsCount { get; set; }
}