using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Test4
{
  public static void RunTest()
  {
    var result1 = CountOfVowels("hello world");
    Console.WriteLine(result1);

    var result2 = IsPangram("The quick brown fox jumps over the lazy dog");
    Console.WriteLine(result2);

    var result3 = StringCompression("AAbbbccddddd");
    Console.WriteLine(result3);

    var result4 = RotateArrayToRight([1, 2, 3, 4, 5, 6, 7], 3);
    Console.WriteLine(String.Join(",", result4));

    var result5 = MergeSortedArrays([10, 20, 30], [25, 40, 55]);
    Console.WriteLine(String.Join(',', result5));
  }

  private static int CountOfVowels(string input)
  {
    int count = 0;
    foreach (char c in input)
    {
      if ("AEIOUaeiou".Contains(c)) count++;
    }
    return count;
  }

  private static bool IsPangram(string input)
  // 모든 알파벳이 포함되어 있는지 확인
  // Input: "The quick brown fox jumps over the lazy dog"
  // Output: true
  {
    var charSet = new HashSet<char>();

    foreach (char c in input)
    {
      if (char.IsLetter(c)) charSet.Add(char.ToUpper(c));
    }

    // Console.WriteLine(charSet.Count);
    if (charSet.Count == 26) return true;
    return false;
  }

  private static string StringCompression(string input)
  // 문자열 압축
  // Input: "AAbbbccddddd"
  // Output: "A2b3c2d5"
  // Input: "aaabbbcc"
  // Output: "a3b3c2"
  // Input: "abc"
  // Output: "abc"
  {
    if (string.IsNullOrEmpty(input)) return input;

    var sb = new StringBuilder();
    char currentChar = input[0];
    int count = 1;

    for (int i = 1; i < input.Length; i++)
    {
      if (input[i] == currentChar)
      {
        count++;
      }
      else
      {
        sb.Append(currentChar);
        if (count > 1) sb.Append(count);
        currentChar = input[i];
        count = 1;
      }
    }

    // 마지막 문자 처리
    sb.Append(currentChar);
    if (count > 1) sb.Append(count);

    return sb.ToString();
  }

  private static int[] RotateArrayToRight(int[] input, int k)
  // 배열을 오른쪽으로 k번 회전
  // Input: [1, 2, 3, 4, 5, 6, 7], k = 3
  // Output: [5, 6, 7, 1, 2, 3, 4]
  // Input: [1, 2, 3, 4, 5], k = 2
  // Output: [4, 5, 1, 2, 3]
  // Input: [1, 2, 3], k = 0
  // Output: [1, 2, 3]
  {
    int rotateTimes = k % input.Length;

    var leftPart = new int[rotateTimes];
    var rightPart = new int[input.Length - rotateTimes];

    //Console.WriteLine(rotateTimes);
    //Console.WriteLine(input.Length - rotateTimes);

    // leftPart
    Array.Copy(input, input.Length - rotateTimes, leftPart, 0, rotateTimes);
    // rightPart 
    Array.Copy(input, 0, rightPart, 0, input.Length - rotateTimes);

    return leftPart.Concat(rightPart).ToArray();
  }

  private static int[] MergeSortedArrays(int[] input1, int[] input2)
  {
    var result = new List<int>();

    int index1 = 0;
    int index2 = 0;

    while (index1 < input1.Length && index2 < input2.Length)
    {
      if (input1[index1] < input2[index2])
      {
        result.Add(input1[index1]);
        index1++;
      }
      else
      {
        result.Add(input2[index2]);
        index2++;
      }
    }

    while (index1 < input1.Length)
    {
      result.Add(input1[index1]);
      index1++;
    }

    while (index2 < input2.Length)
    {
      result.Add(input2[index2]);
      index2++;
    }

    return result.ToArray();
  }
}