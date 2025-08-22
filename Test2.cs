using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Test2
{
  public static void RunTest()
  {
    Console.WriteLine("Test2 Main Method");
    var result1 = Fibo(10);
    Console.WriteLine(string.Join(", ", result1)); // Example output: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
    var result2 = Factorial(5);
    Console.WriteLine(result2); // Example output: 120
    var result3 = AreAnagrams("listen", "silent");
    Console.WriteLine(result3); // Example output: True
    var result4 = UniqueElements(new List<string> { "apple", "banana", "apple", "orange" });
    Console.WriteLine(result4.Count); // Example output: 3
    var result5 = CountOfVowel("hello world");
    Console.WriteLine(result5); // Example output: 3
    var result6 = GeneratePrimeNumbers(20);
    Console.WriteLine(string.Join(", ", result6)); // Example output: 2, 3, 5, 7, 11, 13, 17, 19
    var result7 = RewriteStringToCharCount("Hello World");
    Console.WriteLine(result7); // Example output: h1e1l3o2w1r1d1
    var result8 = CommonElements(new List<int> { 1, 2, 3 }, new List<int> { 2, 3, 4 });
    Console.WriteLine(string.Join(", ", result8)); // Example output: 2, 3
    var result9 = CaesarCipher("abc", 2);
    Console.WriteLine(result9); // Example output: cde
    var result10 = ReverseVowels("hello");
    Console.WriteLine(result10); // Example output: holle
    var result11 = ReverseWords("hello world");
    Console.WriteLine(result11); // Example output: world hello
    var result12 = ProductExceptSelf(new int[] { 1, 2, 3, 4 });
    Console.WriteLine(string.Join(", ", result12)); // Example output: 24, 12, 8, 6
    var result13 = IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
    Console.WriteLine(result13); // Example output: True
    var result14 = Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
    Console.WriteLine(result14); // Example output: 6 (compressed array length)
    var result15 = FindDifference(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 });
    Console.WriteLine(string.Join(", ", result15[0])); // Example output: 1
    Console.WriteLine(string.Join(", ", result15[1])); // Example output: 4
    var result16 = UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3 });
    Console.WriteLine(result16); // Example output: True
    var result17 = CloseStrings("abc", "bca");
    Console.WriteLine(result17); // Example output: True
    var result18 = EqualPairs(new int[][] { new int[] { 1, 2 }, new int[] { 2, 1 } });
    Console.WriteLine(result18); // Example output: 2
    var result19 = RemoveStars("leet**cod*e");
    Console.WriteLine(result19); // Example output: lecoe
    var result20 = DecodeString("3[a2[c]]");
    Console.WriteLine(result20); // Example output: accaccacc
    var result21 = RemoveNonAlphanumeric("abc123!@#");
    Console.WriteLine(result21); // Example output: abc123
    var result22 = GetRow(new int[,] { { 1, 2 }, { 3, 4 } }, 0);
    Console.WriteLine(string.Join(", ", result22)); // Example output: 1, 2
    var result23 = GetRow(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }, 1);
    Console.WriteLine(string.Join(", ", result23)); // Example output: 4, 5, 6
    var result24 = EqualPairs(new int[][] { new int[] { 1, 2 }, new int[] { 2, 1 } });
    Console.WriteLine(result24); // Example output: 2
    var result25 = DecodeString("2[abc]3[cd]ef");
    Console.WriteLine(result25); // Example output: abcabccdcdcdef
    var result26 = DecodeString("3[a]2[bc]");
    Console.WriteLine(result26); // Example output: aaabcbc
  }

  public static List<int> Fibo(int n)
  {
    List<int> result = new List<int>() { 0, 1 };
    for (int i = 2; i < n; i++)
    {
      result.Add(result[i - 1] + result[i - 2]);
    }
    return result;
  }

  public static long Factorial(int n)
  {
    return (n == 0 || n == 1) ? 1 : n * Factorial(n - 1);
  }

  public static bool AreAnagrams(String a, String b)
  {
    var aList = a.OrderBy(c => c).ToList();
    var bList = b.OrderBy(c => c).ToList();
    return aList.SequenceEqual(bList);
  }

  // Returns a list of unique elements from the input list.
  // 중복된 요소를 제거하고 고유한 요소만 포함하는 리스트를 반환합니다.
  // 예를 들어, [1, 2, 2, 3]가 주어지면 [1, 2, 3]을 반환합니다.
  public static List<String> UniqueElements(List<String> input)
  {
    List<String> result = new List<string>();
    for (var i = 0; i < input.Count; i++)
    {
      if (input.IndexOf(input[i]) == i)
      {
        result.Add(input[i]);
      }
    }
    return result;
  }

  public static int CountOfVowel(String input)
  {
    int count = 0;
    foreach (var ch in input.ToUpper())
    {
      if ("AEIOU".Contains(ch))
      {
        count++;
      }
    }
    return count;
  }

  public static List<int> GeneratePrimeNumbers(int n)
  // n이 주어지면 n까지의 소수 목록을 생성합니다.
  {
    List<int> primes = new List<int>();
    for (int i = 2; i <= n; i++)
    {
      bool isPrime = true;
      for (int j = 2; j * j <= i; j++)
      {
        if (i % j == 0)
        {
          isPrime = false;
          break;
        }
      }
      if (isPrime)
      {
        primes.Add(i);
      }
    }
    return primes;
  }

  public static string RewriteStringToCharCount(string input)
  // Returns a string that contains each character and its count in the input string
  // strings should be sorted alphabetically
  // 예를 들어, "Hello World"가 주어지면 " 1d1e1h1l3o2r1w1"을 반환합니다.
  {
    var charCount = new SortedDictionary<char, int>();
    foreach (char ch in input.ToLower())
    {
      charCount[ch] = charCount.ContainsKey(ch) ? charCount[ch] + 1 : 1;
    }
    StringBuilder sb = new StringBuilder();
    foreach (var key in charCount.Keys)
    {
      sb.Append(key).Append(charCount[key]);
    }
    return sb.ToString();
  }

  // Returns the common elements between two lists.
  // 예를 들어, [1, 2, 3]과 [2, 3, 4]가 주어지면 [2, 3]을 반환합니다
  public static List<int> CommonElements(List<int> a, List<int> b)
  {
    List<int> result = new List<int>();
    foreach (int aElem in a)
    {
      if (b.IndexOf(aElem) != -1)
        result.Add(aElem);
    }
    return result;
  }

  public static string CaesarCipher(string input, int shift)
  {
    StringBuilder sb = new();
    foreach (char ch in input)
    {
      sb.Append((char)(ch + shift));
    }
    return sb.ToString();
  }

  // Reverses the vowels in a string.
  // For example, "hello" becomes "holle", and "leetcode" becomes "leotcede".
  // For example, "aeiou" becomes "uoiea".
  public static string ReverseVowels(string s)
  {
    const string Vowels = "AEIOUaeiou";
    var stack = new Stack<char>();
    foreach (var c in s)
    {
      if (Vowels.Contains(c))
      {
        stack.Push(c);
      }
    }
    for (int i = 0; i < s.Length; i++)
    {
      if (Vowels.Contains(s[i]))
      {
        char lastChar = stack.Pop();
        s = s.Remove(i, 1).Insert(i, lastChar.ToString());
      }
    }
    return s;
  }

  public static string ReverseWords(string s)
  {
    string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    StringBuilder result = new();
    for (int i = words.Length - 1; i >= 0; i--)
    {
      result.Append(words[i]);
      result.Append(" ");
    }
    return result.ToString();
  }

  public static int[] ProductExceptSelf(int[] nums)
  // 주어진 배열에서 각 요소를 제외한 나머지 요소들의 곱을 포함하는 배열을 반환합니다.
  // 예를 들어, [1, 2, 3, 4]가 주어지면 [24, 12, 8, 6]을 반환합니다.
  {
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
      int result_el = 1;
      for (int j = 0; j < nums.Length; j++)
      {
        if (j == i) continue;
        result_el *= nums[j];
      }
      result[i] = result_el;
    }
    return result;
  }

  // Checks if there exists a triplet (i, j, k) such that nums[i] < nums[j] < nums[k] and i < j < k.
  // 주어진 배열에서 i < j < k를 만족하는 nums[i] < nums[j] < nums[k]인 삼중항이 존재하는지 확인합니다.
  // 예를 들어, [1, 2, 3, 4, 5]가 주어지면 (1, 2, 3)이라는 유효한 삼중항이 존재하므로 true를 반환합니다.
  // [5, 4, 3, 2, 1]이 주어지면 유효한 삼중항이 없으므로 false를 반환합니다.
  // 이 함수는 O(n) 시간 복잡도로 실행되어야 합니다.
  // 입력 배열이 비어 있거나 3개 미만의 요소를 가지면 false를 반환해야 합니다.
  // 예를 들어, []가 주어지면 false를 반환합니다.
  // [1, 2]가 주어지면 false를 반환합니다.
  // [1, 2, 3]이 주어지면 true를 반환합니다. (1, 2, 3)이 유효한 삼중항입니다.
  public static bool IncreasingTriplet(int[] nums)
  {
    if (nums.Length < 3) return false;

    int first = int.MaxValue, second = int.MaxValue;

    foreach (int num in nums)
    {
      if (num <= first)
      {
        first = num;
      }
      else if (num <= second)
      {
        second = num;
      }
      else
      {
        return true; // Found a triplet
      }
    }

    return false; // No triplet found
  }

  // 주어진 문자 배열을 압축하고 새로운 길이를 반환합니다.
  // 예를 들어, ['a', 'a', 'b', 'b', 'c', 'c', 'c']가 주어지면, 배열을 ['a', '2', 'b', '2', 'c', '3']로 수정하고 6을 반환합니다.
  // 입력 배열은 제자리에서 수정되므로 원래 배열이 변경됩니다.
  // 압축된 문자열이 원래 문자열보다 길면 원래 문자열은 변경되지 않습니다.
  // 예를 들어, ['a', 'b', 'c']가 주어지면 3을 반환하고 배열은 변경되지 않습니다.
  // 입력 배열이 비어 있으면 0을 반환하고 배열은 변경되지 않습니다.
  public static int Compress(char[] chars)
  {
    int i = 0;
    int n = chars.Length;
    StringBuilder sb = new StringBuilder();
    while (i < n)
    {
      int j = i + 1;
      while (j < n && chars[i] == chars[j])
      {
        j++;
      }
      sb.Append(chars[i]);
      int count = j - i;
      if (count > 1)
      {
        sb.Append(count);
      }
      i = j;
    }
    char[] comp = sb.ToString().ToCharArray();
    for (int j = 0; j < comp.Length; j++)
    {
      chars[j] = comp[j];
    }
    return comp.Length;
  }

  // 주어진 두 배열에서 서로 다른 요소를 찾아 반환합니다.
  // 예를 들어, [1, 2, 3]과 [2, 3, 4]가 주어지면 [1]과 [4]를 반환합니다.
  // [1, 2, 3]과 [1, 2, 3]가 주어지면 빈 배열을 반환합니다.
  // [1, 2, 3]과 []가 주어지면 [1, 2, 3]을 반환합니다.
  // []와 []가 주어지면 빈 배열을 반환합니다.
  public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
  {
    IList<int> list1 = new List<int>();
    foreach (int num in nums1)
    {
      if (!nums2.Contains(num) && !list1.Contains(num))
      {
        list1.Add(num);
      }
    }
    IList<int> list2 = new List<int>();
    foreach (int num in nums2)
    {
      if (!nums1.Contains(num) && !list2.Contains(num))
      {
        list2.Add(num);
      }
    }
    IList<IList<int>> result = new List<IList<int>> { list1, list2 };
    return result;
  }

  // Checks if the number of occurrences of each element in the array is unique.
  // 주어진 배열에서 각 요소의 발생 횟수가 고유한지 확인합니다.
  // 예를 들어, [1, 2, 2, 1, 1, 3]가 주어지면 1은 3번, 2는 2번, 3은 1번 발생하므로 true를 반환합니다.
  // [1, 2, 2, 3, 3]가 주어지면 1은 1번, 2는 2번, 3은 2번 발생하므로 false를 반환합니다.
  public static bool UniqueOccurrences(int[] arr)
  {
    var dictionary = new Dictionary<int, int>();
    foreach (var num in arr)
    {
      dictionary[num] = dictionary.ContainsKey(num) ? dictionary[num] + 1 : 1;
    }
    var countSet = new HashSet<int>(dictionary.Values);
    return countSet.Count == dictionary.Count;
  }

  // Checks if two words are close.
  // 두 단어가 가까운지 확인합니다.
  // 두 단어가 가까운 경우, 두 단어는 같은 문자 집합을 가지고 있으며, 각 문자의 빈도수가 서로 다른 순서로 나타납니다.
  // 예를 들어, "abc"와 "bca"는 가까운 단어입니다.
  // "aabbcc"와 "abcabc"는 가까운 단어입니다. 왜냐하면 두 단어는 같은 문자 집합을 가지고 있으며, 각 문자의 빈도수가 서로 다르게 나타나기 때문입니다.
  // "aabbcc"와 "abc"는 가까운 단어가 아닙니다.
  // "aabbcc"와 "aabbc"는 가까운 단어가 아닙니다.
  // "aabbcc"와 "aabbcc"는 가까운 단어입니다.
  // "aabbcc"와 "aabbc"는 가까운 단어가 아닙니다.
  // "aabbcc"와 "abcabc"는 가까운 단어입니다.
  // "aabbcc"와 "abc"는 가까  운 단어가 아닙니다.
  public static bool CloseStrings(string word1, string word2)
  {
    var dic1 = new Dictionary<char, int>();
    var dic2 = new Dictionary<char, int>();
    foreach (char ch in word1.ToCharArray())
    {
      dic1[ch] = dic1.ContainsKey(ch) ? dic1[ch] + 1 : 1;
    }
    foreach (char ch in word2.ToCharArray())
    {
      dic2[ch] = dic2.ContainsKey(ch) ? dic2[ch] + 1 : 1;
    }
    var l1Keys = dic1.Keys.ToList();
    var l2Keys = dic2.Keys.ToList();
    l1Keys.Sort();
    l2Keys.Sort();
    if (l1Keys.SequenceEqual(l2Keys) == false)
      return false;
    var l1Values = dic1.Values.ToList();
    var l2Values = dic2.Values.ToList();
    l1Values.Sort();
    l2Values.Sort();
    if (l1Values.SequenceEqual(l2Values) == false)
      return false;
    return true;
  }

  public static int EqualPairs__(int[][] grid)
  {
    int[,] columnGrid = new int[grid.Length, grid.Length];
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid.Length; j++)
      {
        columnGrid[i, j] = grid[j][i];
      }
    }
    int equalCount = 0;
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid.Length; j++)
      {
        if (grid[i].SequenceEqual(GetRow(columnGrid, j)))
        {
          equalCount++;
        }
      }
    }
    return equalCount;
  }

  public static int[] GetRow(int[,] matrix, int nth)
  // Returns the nth row of a 2D matrix.
  // 예를 들어, [[1, 2], [3, 4]]가 주어지면 0번째 행은 [1, 2]를 반환합니다.
  // [[1, 2, 3], [4, 5, 6]]가 주어지면 1번째 행은 [4, 5, 6]를 반환합니다.
  // [[1, 2], [3, 4], [5, 6]]가 주어지면 2번째 행은 [5, 6]를 반환합니다.
  {
    return Enumerable.Range(0, matrix.GetLength(0))
        .Select(x => matrix[nth, x])
        .ToArray();
  }

  public static int EqualPairs(int[][] grid)
  // 주어진 2차원 배열에서 행과 열이 동일한 쌍의 개수를 반환합니다.
  // 예를 들어, [[1, 2], [2, 1]]이 주어지면 2를 반환합니다.
  // [[1, 2, 3], [2, 1, 3], [3, 2, 1]]이 주어지면 0을 반환합니다.
  // [[1, 2], [1, 2]]가 주어지면 2를 반환합니다.
  // [[1, 2, 3], [1, 2, 3], [1, 2, 3]]가 주어지면 3을 반환합니다.
  {
    IList<int[]> columnGrid = new List<int[]>();
    for (int i = 0; i < grid.Length; i++)
    {
      var column = new int[grid.Length];
      for (int j = 0; j < grid.Length; j++)
      {
        column[j] = grid[j][i];
      }
      columnGrid.Add(column);
    }
    int equalCount = 0;
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid.Length; j++)
      {
        if (grid[i].SequenceEqual(columnGrid[j]))
        {
          equalCount++;
        }
      }
    }
    return equalCount;
  }

  // 주어진 문자열에서 별표(*)를 제거하고, 별표가 나타날 때마다 이전 문자를 제거합니다.
  // 예를 들어, "leet**cod*e"가 주어지면 "lecoe"를 반환합니다.
  // "erase*****"가 주어지면 ""를 반환합니다.
  // "a*b*c"가 주어지면 "c"를 반환합니다.
  // "abc"가 주어지면 "abc"를 반환합니다.
  public static string RemoveStars(string s)
  {
    Stack stack = new();
    foreach (var ch in s)
    {
      if (ch != '*') stack.Push(ch);
      else stack.Pop();
    }
    var arr = stack.ToArray();
    Array.Reverse(arr);
    return string.Join("", arr);
  }

  // 주어진 배열에서 충돌하는 소행성을 처리합니다.
  // 소행성은 양수는 오른쪽으로, 음수는 왼쪽으로 이동합니다.
  // 충돌이 발생하면 큰 소행성이 남고 작은 소행성이 사라집니다.
  // 예를 들어, [5, 10, -5]가 주어지면 [5, 10]이 남습니다.
  // [8, -8]이 주어지면 빈 배열이 됩니다.
  // [10, -10]이 주어지면 빈 배열이 됩니다.
  // [1, 2, -2]이 주어지면 [1]이 남습니다.
  // [1, -1]이 주어지면 빈 배열이 됩니다.
  // [1, 2, 3, -1]이 주어지면 [1, 2, 3]이 남습니다.
  // [1, -2, 3, -4]이 주어지면 [1, 3, -4]가 남습니다.
  public static int[] AsteroidCollision(int[] asteroids)
  {
    Stack<int> stack = new();
    foreach (var a in asteroids)
    {
      bool newPush = true;
      if (stack.Count <= 0)
      {
        stack.Push(a);
        continue;
      }
      while (stack.Peek() * a < 0)
      {
        if (Math.Abs(stack.Peek()) > Math.Abs(a))
        {
          newPush = false;
          break;
        }
        else if (Math.Abs(stack.Peek()) < Math.Abs(a))
        {
          stack.Pop();
          newPush = true;
        }
        else
        {
          stack.Pop();
          newPush = false;
          break;
        }
      }
      if (newPush)
        stack.Push(a);
    }
    var arr = stack.ToArray();
    Array.Reverse(arr);
    return arr;
  }


  public static string DecodeString(string s)
  // 주어진 문자열을 디코딩합니다.
  // 예를 들어, "3[a2[c]]"가 주어지면 "accaccacc"를 반환합니다.
  // "2[abc]3[cd]ef"가 주어지면 "abcabccdcdcdef"를 반환합니다.
  // "3[a]2[bc]"가 주어지면 "aaabcbc"를 반환합니다
  {
    Stack<int> countStack = new Stack<int>();
    Stack<string> resultStack = new Stack<string>();
    string result = "";
    int index = 0;
    while (index < s.Length)
    {
      if (Char.IsDigit(s[index]))
      {
        int count = 0;
        while (Char.IsDigit(s[index]))
        {
          count = count * 10 + (s[index] - '0');
          index++;
        }
        countStack.Push(count);
      }
      else if (s[index] == '[')
      {
        resultStack.Push(result);
        result = "";
        index++;
      }
      else if (s[index] == ']')
      {
        StringBuilder temp = new StringBuilder(resultStack.Pop());
        int repeatTimes = countStack.Pop();
        for (int i = 0; i < repeatTimes; i++)
        {
          temp.Append(result);
        }
        result = temp.ToString();
        index++;
      }
      else
      {
        result += s[index];
        index++;
      }
    }
    return result;
  }

  public static string RemoveNonAlphanumeric(string input)
  // 주어진 문자열에서 알파벳과 숫자를 제외한 모든 문자를 제거합니다.
  // 예를 들어, "abc123!@#"가 주어지면 "abc123"을 반환합니다.
  // "Hello, World!"가 주어지면 "HelloWorld"를 반환합니다.
  // "1234567890"가 주어지면 "1234567890"을 반환합니다.
  {
    StringBuilder sb = new();
    foreach (char c in input)
    {
      if (char.IsLetterOrDigit(c))
      {
        sb.Append(c);
      }
    }
    return sb.ToString();
  }
}