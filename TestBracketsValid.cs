class TestBracketsValid
{
  public bool IsValid(string s)
  {
    var stack = new Stack<char>();
    var map = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

    foreach (char c in s)
    {
      if (map.ContainsKey(c)) // 닫는 괄호
      {
        if (stack.Count == 0 || stack.Pop() != map[c])
          return false;
      }
      else if (map.ContainsValue(c)) // 여는 괄호
      {
        stack.Push(c);
      }
    }

    return stack.Count == 0;
  }


  public static void Main()
  {
    Console.WriteLine("=====================================");

    var test = new TestBracketsValid();
    var input = "({[]})";
    var result = test.IsValid(input);
    Console.WriteLine($"Is the string '{input}' valid? {result}");

    input = "({[})";
    result = test.IsValid(input);
    Console.WriteLine($"Is the string '{input}' valid? {result}");
  }
}
