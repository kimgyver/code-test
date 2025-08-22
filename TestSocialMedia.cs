
using System.Text.Json;

class TestSocialMedia
{
  public static void RunTest()
  {
    var events = new string[][] {
      new string[] { "CONNECT", "Alice", "Bob" },
      new string[] { "DISCONNECT", "Bob", "Alice" },
      new string[] { "CONNECT", "Alice", "Charlie"},
      new string[] { "CONNECT", "Dennis", "Bob" },
      new string[] { "CONNECT", "Pam", "Dennis" },
      new string[] { "DISCONNECT", "Pam", "Dennis" },
      new string[] { "CONNECT", "Pam", "Dennis" },
      new string[] { "CONNECT", "Edward", "Bob" },
      new string[] { "CONNECT", "Dennis", "Charlie" },
      new string[] { "CONNECT", "Alice", "Nicole" },
      new string[] { "CONNECT", "Pam", "Edward" },
      new string[] { "DISCONNECT", "Dennis", "Charlie" },
      new string[] { "CONNECT", "Dennis", "Edward" },
      new string[] { "CONNECT", "Charlie", "Bob" }
    };

    // Assuming SocialMediaEvents is a method that processes the events
    // and returns a list containing two lists:
    // 1. person list with connections of less than some value
    // 2. person list with connections of equal to some value or more
    // The value is passed as the second argument to the method.
    // For example, if the value is 3, it will return persons with less than 3 connections
    // and persons with 3 or more connections.


    var result = SocialMediaEvents(events, 3);
    Console.WriteLine(JsonSerializer.Serialize(result));

    result = SocialMediaEvents(events, 1);
    Console.WriteLine(JsonSerializer.Serialize(result));

    result = SocialMediaEvents(events, 10);
    Console.WriteLine(JsonSerializer.Serialize(result));
  }

  private static object SocialMediaEvents(string[][] events, int threshold)
  {
    var connections = new Dictionary<string, HashSet<string>>();

    foreach (var ev in events)
    {
      var action = ev[0];
      var person1 = ev[1];
      var person2 = ev[2];

      if (!connections.ContainsKey(person1))
        connections[person1] = new HashSet<string>();
      if (!connections.ContainsKey(person2))
        connections[person2] = new HashSet<string>();

      if (action == "CONNECT")
      {
        connections[person1].Add(person2);
        connections[person2].Add(person1);
      }
      else if (action == "DISCONNECT")
      {
        connections[person1].Remove(person2);
        connections[person2].Remove(person1);
      }
    }

    var lessThanGroup = new List<string>();
    var moreThanGroup = new List<string>();

    foreach (var kvp in connections)
    {
      Console.WriteLine($"Person: {kvp.Key}, Connections: {kvp.Value.Count}");
      if (kvp.Value.Count < threshold)
        lessThanGroup.Add(kvp.Key);
      else if (kvp.Value.Count >= threshold)
        moreThanGroup.Add(kvp.Key);
    }

    return new List<List<string>> { lessThanGroup, moreThanGroup };
  }
}
