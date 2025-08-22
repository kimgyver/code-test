using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

public class Test1
{
  public static void RunTest()
  {
    Console.WriteLine("Hello World");
    var result1 = MostFrequentWord("this is a test this is only a test");
    Console.WriteLine(result1);

    var result2 = IsAnagram("listen", "silent");
    Console.WriteLine(result2);
    var result21 = IsAnagram("listena", "silentb");
    Console.WriteLine(result21);

    var result3 = ReverseEachWordInASentence("hello world");
    Console.WriteLine(result3);

    var result4 = FirstNonRepeatingChar("swiss");
    Console.WriteLine(result4);

    var result5 = FindDuplicateNumbers([1, 2, 3, 2, 4, 5, 1, 5, 6, 6]);
    Console.WriteLine(string.Join(',', result5));

    var result6 = IsPalindromeNumber(123454321);
    Console.WriteLine(result6);

    var result7 = SecondLargestNumber([3, 5, 2, 9, 5, 8, 7]);
    Console.WriteLine(result7);

    var result8 = IsBalancedParentheses("((()))[]");
    Console.WriteLine(result8);

    var result9 = TopKFrequent([1, 1, 1, 2, 2, 3, 4, 4, 4, 4], 3);
    Console.WriteLine(string.Join(',', result9));
  }

  private static string MostFrequentWord(string input)
  {
    // Input: "this is a test this is only a test"
    // Output: "this"
    var words = input.Split(' ');
    var wordDic = new Dictionary<string, int>();
    foreach (var word in words)
    {
      wordDic[word] = wordDic.ContainsKey(word) ? wordDic[word] + 1 : 1;
    }

    // var BiggestKey = wordDic.OrderByDescending(x => x.Value).FirstOrDefault().Key;

    string BiggestKey = "";
    int BiggestCount = int.MinValue;
    foreach (var kp in wordDic)
    {
      if (kp.Value > BiggestCount)
      {
        BiggestKey = kp.Key;
        BiggestCount = kp.Value;
      }
    }
    return BiggestKey;
  }

  private static bool IsAnagram(string input1, string input2)
  {
    // Input: "listen", "silent"
    // Output: true
    if (input1.Length != input2.Length) return false;
    var charCount = new Dictionary<char, int>();
    foreach (var c in input1)
    {
      if (charCount.ContainsKey(c))
        charCount[c]++;
      else
        charCount[c] = 1;
    }
    foreach (var c in input2)
    {
      if (!charCount.ContainsKey(c) || charCount[c] == 0)
        return false;
      charCount[c]--;
    }
    return charCount.Values.All(v => v == 0);

    // // Input: "listen", "silent"
    // // Output: true
    // var list1 = new List<char>(input1);
    // var list2 = new List<char>(input2);
    // list1.Sort();
    // list2.Sort();
    // return string.Join('/', list1).Equals(string.Join('/', list2));
    // //return list1.SequenceEqual(list2);

    // 다른 버전

  }

  private static string ReverseEachWordInASentence(string input)
  {
    // Input: "hello world"
    // Output: "olleh dlrow"
    string[] words = input.Split(' ');
    var sb = new StringBuilder();
    foreach (var word in words)
    {
      sb.Append(ReverseString(word));
      sb.Append(" ");
    }
    return sb.ToString();
  }

  private static string ReverseString(string input)
  {
    var sb = new StringBuilder();
    //Console.WriteLine("ReverseString");
    for (var i = input.Length - 1; i >= 0; i--)
    {
      sb.Append(input[i]);
      //Console.WriteLine(input[i]);
    }
    return sb.ToString();

    //var inputArray = input.ToCharArray();
    //Array.Reverse(inputArray);
    //return inputArray;
  }

  private static char FirstNonRepeatingChar(string input)
  {
    // Input: "swiss"
    // Output: "w"
    for (int index = 0; index < input.Length; index++)
    {
      if (input.LastIndexOf(input[index]) == index)
        return input[index];
    }
    return char.MinValue;
  }

  private static List<int> FindDuplicateNumbers(List<int> input)
  {
    // Input: [1, 2, 3, 2, 4, 5, 1]
    // Output: [1, 2]
    var result = new List<int>();
    for (int index = 0; index < input.Count; index++)
    {
      if (input.LastIndexOf(input[index]) != index)
        result.Add(input[index]);
    }
    return result;
  }

  private static bool IsPalindromeNumber(int input)
  {
    string inputString = input.ToString();
    for (int i = 0; i < inputString.Length / 2; i++)
    {
      //Console.WriteLine(inputString.Length - i);
      if (inputString[i] != inputString[inputString.Length - i - 1])
        return false;
    }
    return true;
  }

  private static int SecondLargestNumber(List<int> input)
  {
    int firstBiggest = int.MinValue;
    int secondBiggest = int.MinValue;

    foreach (var num in input)
    {
      if (num > firstBiggest)
      {
        secondBiggest = firstBiggest;
        firstBiggest = num;
      }
      else if (num > secondBiggest)
      {
        secondBiggest = num;
      }
    }
    return secondBiggest;
  }

  private static bool IsBalancedParentheses(string input)
  {
    var pairs = new Dictionary<char, char>
    {
      { '(', ')' },
      { '[', ']' },
      { '{', '}' },
    };
    var stack = new Stack<char>();
    foreach (char c in input)
    {
      if (pairs.ContainsKey(c))
      {
        stack.Push(c);
      }
      else if (pairs.ContainsValue(c))
      {
        if (stack.Count == 0)
        {
          return false; // 닫는 괄호가 먼저 나옴
        }
        char popped = stack.Pop();
        char key = pairs.FirstOrDefault(x => x.Value == c).Key;
        if (popped != key)
        {
          return false;
        }
      }
    }
    return stack.Count == 0;
  }

  public static IList<int> TopKFrequent(int[] nums, int k)
  {
    // Step 1: Count frequency using a dictionary
    Dictionary<int, int> freqMap = new Dictionary<int, int>();
    foreach (int num in nums)
    {
      if (freqMap.ContainsKey(num))
        freqMap[num]++;
      else
        freqMap[num] = 1;
    }

    // Step 2: Sort the dictionary entries by frequency (descending)
    return freqMap
      .OrderByDescending(pair => pair.Value)
      .Take(k)
      .Select(pair => pair.Key)
      .ToList();
  }

  // 정확히 3개의 대문자 로 시작합니다
  // 정확히 4자리 숫자가 뒤따릅니다.
  // 선택적으로 "-NZ" 로 끝남
  // 유효한 코드의 예:
  // INV1234, ABC5678-NZ
  // 유효하지 않은 코드의 예:
  // AB1234, abc5678,XYZ12-NZ
  public static bool IsValidInvoiceCode(string code)
  {
    // var regex = new Regex(@"^[A-Z]{3}\d{4}(-NZ)?$");
    // return regex.IsMatch(code);

    // 다른 버전 (정규표현 안 쓰고)
    if (code.Length < 7 || code.Length > 10) return false;
    if (!char.IsUpper(code[0]) || !char.IsUpper(code[1]) || !char.IsUpper(code[2])) return false;
    if (!char.IsDigit(code[3]) || !char.IsDigit(code[4]) || !char.IsDigit(code[5]) || !char.IsDigit(code[6])) return false;
    if (code.Length == 9 && code.EndsWith("-NZ")) return false;
    return true;
  }
}
