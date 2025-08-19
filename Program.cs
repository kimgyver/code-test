// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using code_test;


// LogReader.Main();
// return;


TestBalanceChecker.Main();
return;

TestReports.Main();
Console.WriteLine("=============================");
return;

// Test4.Main();
TestMergeIntervals.Main();
TestTopKFrequent.Main();
return;


Test1.Main();
Console.WriteLine("=============================");

Test2.Main();
Console.WriteLine("=============================");

Test_IEnumerable_ICollection_IList();


EqualPairs([[3, 2, 1], [1, 7, 6], [2, 7, 7]]);

MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
IsSubsequence("abc", "ahbgdc");

Compress(['a', 'a', 'b', 'b', 'c', 'c', 'c']);

IncreasingTriplet([20, 100, 10, 12, 5, 13]);

ProductExceptSelf([1, 2, 3, 4]);

ReverseWords("  hello world  ");

ReverseVowels("HELLO");
CanPlaceFlowers([0, 0], 2);


// var result13 = GcdOfStrings("ABCABC", "ABCD");
// System.Console.WriteLine(result13);

// System.Console.WriteLine(RemoveStars("leet**cod*e"));

// AsteroidCollision([-2, -1, 1, 2]);

// System.Console.WriteLine("GetCharacterCount()" + GetCharacterCount("Hellow my friend"));

// System.Console.WriteLine(DecodeString("3[a]2[bc]"));

// System.Console.WriteLine(DecodeString("3[a2[c]]"));

// // System.Console.WriteLine(RemoveNonAlphanumeric("A man, a plan, a canal: Panama"));
// var alphaNum = RemoveNonAlphanumeric("A man, a plan, a canal: Panama");
// var lowered = alphaNum.ToLower();
// var firstHalf = lowered.Substring(0, lowered.Length / 2);
// var lastHalf = lowered.Substring(lowered.Length - lowered.Length / 2, lowered.Length / 2);
// System.Console.WriteLine(firstHalf + " " + lastHalf);
// System.Console.WriteLine(Reverse(lastHalf));
// System.Console.WriteLine(Reverse(lastHalf) == (firstHalf));
// // 123456789012345678901
// // amanaplana canalpanama
// return;



var result12 = MostFrequentWord("aaa bbb aaa ccc bbb avv bbb");
System.Console.WriteLine(result12);
return;

int[] xs = [4, 7, 9];
int max = xs.Max();
System.Console.WriteLine("max=>" + max);

Test_IEnumerable_ICollection_IList();
// return;

ObjectSearch();

var result11 = CaesarCipher("hello", 3);
Console.WriteLine("CaesarCipher :" + result11);

// string line1 = Console.ReadLine();
// string line2 = Console.ReadLine();
string line1 = "1 2 3 4 5";
string line2 = "2 3 5 7 8";
List<int> a = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> b = line2.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var result10 = CommonElements(a, b);
Console.WriteLine(string.Join(" ", result10));


// string line = Console.ReadLine();
string line = "Hello";
Console.WriteLine("GetCharacterCount => " + GetCharacterCount(line));


// ExceptionMain();

// return;

// Console.Write("Enter a dividend: ");
// int dividend = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a divisor: ");
// int divisor = Convert.ToInt32(Console.ReadLine());

int dividend = Convert.ToInt32("10");
int divisor = Convert.ToInt32("3");

if ((divisor != 0) && (dividend / divisor) is var result)
{
  Console.WriteLine("Quotient: {0}", result);
}
else
{
  Console.WriteLine("Attempted division by 0 ends up here.");
}

var result7 = GeneratePrimeNumbers(20);
Console.WriteLine("Prime numbers");
result7.ForEach(x => Console.Write(x + " "));
Console.WriteLine();

var result6 = Frequency("aaaaBBBBBccDDDDeeeee");
foreach (var (Key, Value) in result6)
{
  Console.Write("frequency =>" + Key + ":" + Value + "  ");
}
Console.WriteLine();

var result5 = CountOfVowel("1234567890abcdefgijop");
Console.WriteLine("countOfVowel =>" + result5);

var result4 = UniqueElements(new List<string>() { "aaa", "bbb", "ccc", "aaa" });
Console.WriteLine("uniqueElements =>" + result4.Count);
result4.ForEach(x => Console.Write(x + " "));
Console.WriteLine();

var result3 = Fibo(15);
Console.WriteLine("Fibonacci numbers");
result3.ForEach(x => Console.Write(x + " "));
Console.WriteLine();

var result2 = IsPalindrom("12345654321");
Console.WriteLine("isPalinedrom =>" + result2);


var result1 = AreAnagrams("112221aaa", "111aaa222");
Console.WriteLine("areAnagrams =>" + result1);

return;

Console.WriteLine("Hello, LINQ!");

// Data source
string[] names = { "Bill", "Steve", "James", "Mohan" };

// LINQ Query 
var myLinqQuery = from name in names
                  where name.Contains('a')
                  select "Mr " + name;

// Query execution
foreach (var name in myLinqQuery)
  Console.Write(name + " ");

IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Bill",  Age = 32 } ,
};



static List<int> Fibo(int n)
{
  List<int> result = new List<int>() { 0, 1 };
  for (int i = 2; i < n; i++)
  {
    result.Add(result[i - 1] + result[i - 2]);
  }
  return result;
}


static bool IsPalindrom(String input)
{
  int halfLength = input.Length / 2;
  string firstHalf = input.Substring(0, halfLength);
  string lastHalf = input.Substring(input.Length - halfLength, halfLength);
  return firstHalf.Equals(ReverseString(lastHalf));
}

static string ReverseString(string input)
{
  char[] inputArray = input.ToArray();
  Array.Reverse(inputArray);
  return new string(inputArray);

  // StringBuilder reverse = new StringBuilder();
  // for (int i = input.Length - 1; i >= 0; i--)
  // {
  //   reverse.Append(input[i]);
  // }
  // return reverse.ToString();
}

static long Factorial(int n)
{
  return (n == 0 || n == 1) ? 1 : n * Factorial(n - 1);
}

static int getMax(List<int> numbers)
{
  return numbers.Max();
}

static bool AreAnagrams(String a, String b)
{
  var aList = new List<char>(a);
  var bList = new List<char>(b);
  aList.Sort();
  bList.Sort();
  Console.WriteLine(aList.ToArray());
  Console.WriteLine(bList.ToArray());
  return aList.SequenceEqual(bList);

  var aArr = a.ToCharArray();
  var bArr = b.ToCharArray();
  Array.Sort(aArr);
  Array.Sort(bArr);

  return aArr.SequenceEqual(bArr);
}



static List<String> UniqueElements(List<String> input)
{
  // input.ForEach(x => Console.Write(x + " " + input.IndexOf(x)));
  // return input.Where(x => input.IndexOf(x).Equals(x))
  //   .ToList();

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

static int CountOfVowel(String input)
{
  // var inputSplit = Regex.Split("this is a test", string.Empty);
  // var inputSplit = input.ToUpper().Select(x => new string(x, 1));
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

static Dictionary<char, int> Frequency(String input)
{
  Dictionary<char, int> freq = new Dictionary<char, int>();
  foreach (var ch in input)
  {
    // freq.TryGetValue(ch, out int currentValue);
    // freq[ch] = currentValue + 1;
    freq[ch] = freq.ContainsKey(ch) ? freq[ch] + 1 : 1;
  }

  return freq;
}


static List<int> GeneratePrimeNumbers(int n)
{
  List<int> primeNumbers = new List<int>();
  bool isPrime;
  for (int i = 2; primeNumbers.Count < n; i++)
  {
    isPrime = true;
    for (int j = 2; j <= i / 2; j++)
    {
      if (i != j && i % j == 0)
      {
        isPrime = false;
        break;
      }
    }

    if (isPrime)
    {
      primeNumbers.Add(i);
    }
  }
  return primeNumbers;
}


static string GetCharacterCount(string input)
{
  var charCount = new SortedDictionary<char, int>();

  foreach (char ch in input.ToLower())
  {
    charCount[ch] = charCount.ContainsKey(ch) ? charCount[ch] + 1 : 1;
  }

  StringBuilder sb = new StringBuilder();
  foreach (var key in charCount.Keys)
  {
    // sb.Append(Convert.ToChar(key) + charCount[key]);
    sb.Append(key).Append(charCount[key]);
  }
  return sb.ToString();

  // Dictionary<char, int> charCount = new Dictionary<char, int>();

  // // Count the occurrences of each character, ignoring case
  // foreach (char c in input.ToLower())
  // {
  //   // charCount.TryGetValue(c, out int count);
  //   // charCount[c] = count == 0 ? 1 : count + 1;
  //   charCount[c] = charCount.ContainsKey(c) ? charCount[c] + 1 : 1;
  // }

  // // Convert the dictionary to a sorted list of characters
  // var sortedChars = charCount.Keys.ToArray();
  // Array.Sort(sortedChars);

  // // Build the result string
  // string result = "";
  // foreach (char c in sortedChars)
  // {
  //   result += $"{c}{charCount[c]}";
  // }

  // return result;
}

static List<int> CommonElements(List<int> a, List<int> b)
{
  List<int> result = new List<int>();
  foreach (int aElem in a)
  {
    if (b.IndexOf(aElem) != -1)
      result.Add(aElem);
  }
  ;
  return result;
}

static string CaesarCipher(string input, int shift)
{
  StringBuilder sb = new();
  foreach (char ch in input)
  {
    sb.Append((char)(ch + shift));
  }
  return sb.ToString();
}

static void ObjectSearch()
{
  List<Domain> list = new List<Domain>();
  list.Add(new Domain { Id = 30, Url = "www.hindi100.com" });
  list.Add(new Domain { Id = 10, Url = "www.JavaTpoint.com" });
  list.Add(new Domain { Id = 15, Url = "www.abc.com" });
  list.Add(new Domain { Id = 20, Url = "www.sssit.com" });

  var found1 = list.FirstOrDefault(d => d.Id == 30);
  Console.WriteLine(found1);

  var found2 = list.FirstOrDefault(d => d.Url.Equals("www.abc.com"));
  Console.WriteLine(found2);

  var found3 = list.Where(d => d.Url.Contains("sssit1")).FirstOrDefault();
  // var found3 = list.Where(d => d.Url.Contains("sssit"))[0];
  Console.WriteLine(found3);

  var found4 = list.FirstOrDefault(d => d.Id % 10 != 0);
  Console.WriteLine(found4);
}

static void Test_IEnumerable_ICollection_IList()
{
  //// IEnumerable
  int[] years = { 2001, 2002, 2003, 2004, 2005 };

  IEnumerable<int> cubeQuery = years.Where(y => y >= 2002).Select(y => y - 1000).OrderBy(x => x);
  // cubeQuery.Add(2222);
  Console.WriteLine(string.Join(" ", cubeQuery));

  IEnumerable<(int hour, int temperature)> hourlyTemperatures = new List<(int, int)> { (1, 23), (2, 26), (3, 20), (4, 34), (5, 30), (6, 22), (7, 24), (8, 20), (9, 25) };
  var query = hourlyTemperatures.GroupBy(ht => ht.temperature / 10, ht => ht.hour);
  foreach (var group in query)
  {
    Console.WriteLine($"Hours when the temperature was in the {group.Key * 10}s: {string.Join(", ", group)}");
  }

  List<string> cityList = new() { "New York", "London", "Paris", "Tokyo" };
  IEnumerator cityEnum = cityList.GetEnumerator();
  while (cityEnum.MoveNext())
  {
    Console.WriteLine(cityEnum.Current);
  }

  //// ICollection
  Console.WriteLine("====================");
  ICollection<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
  numbers.Add(6); // Adding an element
  numbers.Remove(3); // Removing an element
  bool exists = numbers.Contains(2); // Checking existence of an element
  int count = numbers.Count; // Getting the count of elements
  Console.WriteLine(string.Join(" ", numbers));


  /// IList
  Console.WriteLine("====================");
  IList<int> numberlist = new List<int>() { 1, 2, 3, 4, 5 };
  numberlist.Insert(0, 0); // Inserting an element at a specific position
  numberlist.RemoveAt(2); // Removing an element from a specific position
  int firstNumber = numberlist[0]; // Accessing element by index
  numberlist[0] = 10; // Setting element at a specific position
  Console.WriteLine(string.Join(" ", numberlist));
}

static void ExceptionMain()
{
  try
  {
    Method2();
  }
  catch (Exception ex)
  {
    Console.Write(ex.StackTrace.ToString());
    // Console.ReadKey();
  }
}

static void Method2()
{
  try
  {
    Method1();
  }
  catch (Exception ex)
  {
    //throw ex resets the stack trace Coming from Method 1 and propogates it to the caller(Main)
    throw ex;
  }
}

static void Method1()
{
  try
  {
    throw new Exception("Inside Method1");
  }
  catch (Exception)
  {
    throw;
  }
}


// delegate void MyDelegate(string msg); //declaring a delegate
// public delegate void Print(int value);

// static void PrintHelperMethod(Print printDel, int val)
// {
//   val += 10;
//   printDel(val);
// }

static string MostFrequentWord(string line)
{
  // split
  var words = line.Split(' ');

  // key: word, value: count
  var freq = new Dictionary<string, int>();

  // put to dictionary (for loop)
  foreach (var word in words)
  {
    freq[word] = freq.ContainsKey(word) ? freq[word] + 1 : 1;
  }

  // finding max one
  int maxCount = 0;
  string maxCountWord = "";
  foreach (var kp in freq)
  {
    if (kp.Value > maxCount)
    {
      maxCount = kp.Value;
      maxCountWord = kp.Key;
    }
  }

  // Console.Write(freq.ToString());

  return maxCountWord;

  // sort dictionary by count
  var maxOne = freq.OrderByDescending(x => x.Value).FirstOrDefault();
  return maxOne.Key;
}

static string GcdOfStrings(string str1, string str2)
{
  string str2__ = str2;
  int i = 0;
  bool found = false;
  string[] splitted = { };
  do
  {
    splitted = str1.Split(str2__);
    if (string.IsNullOrEmpty(string.Join("", splitted)))
    {
      found = true;
      break;
    }
    str2__ = str2.Substring(0, str2.Length - i - 1);
    i++;
  } while (!string.IsNullOrEmpty(str2__));
  if (found)
  {
    return str2__;
  }

  return "";
}

static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{
  int max = int.MinValue;
  List<bool> results = new();

  foreach (var candy in candies)
  {
    if (candy + extraCandies > max)
    {
      max = candy;
      results.Add(true);
    }
    else
    {
      results.Add(false);
    }
  }
  return results;
}


static bool CanPlaceFlowers(int[] flowerbed, int n)
{
  int count = 0;

  for (int i = 0; i < flowerbed.Length; i++)
  {
    if (flowerbed[i] == 1) continue;

    if (flowerbed.Length == 1 && flowerbed[0] == 0)
    {
      count++;
    }
    else if ((i == 0 && flowerbed[1] == 0) || (i == flowerbed.Length - 1 && flowerbed[flowerbed.Length - 2] == 0))
    {
      flowerbed[i] = 1;
      count++;
    }
    if ((i >= 1 && flowerbed[i - 1] == 0)
    && (i + 1 <= flowerbed.Length - 1 && flowerbed[i + 1] == 0))
    {
      flowerbed[i] = 1;
      count++;
      System.Console.WriteLine(i);
    }

  }

  return count >= n;
}

static string ReverseVowels(string s)
{
  // collect vowels
  // var chars = s.ToCharArray()
  //     .Where(c => "AEIOUaeiou".Contains(c))
  //     .Select(c => c.ToString())
  //     .ToList();
  // var stack = new Stack<String>(chars);

  const string Vowels = "AEIOUaeiou";

  var stack = new Stack<char>();
  // s.ToCharArray()
  //     .Where(c => Vowels.Contains(c))
  //     .ToList()
  //     .ForEach(c => stack.Push(c));

  foreach (var c in s)
  {
    if (Vowels.Contains(c))
    {
      stack.Push(c);
    }
  }

  // iterate string
  // if char is vowel, replace the last vowel of collected vowels
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

static string ReverseWords(string s)
{
  string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
  StringBuilder result = new();
  for (int i = words.Length - 1; i >= 0; i--)
  {
    result.Append(words[i]);
    if (i > 0)
    {
      result.Append(" ");
    }
  }

  return result.ToString();
}

static int[] ProductExceptSelf(int[] nums)
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

static bool IncreasingTriplet(int[] nums)
{
  int first_small = 100;
  int second_small = 100;
  for (int i = 0; i < nums.Length; i++)
  {
    if (nums[i] <= first_small)
      first_small = nums[i];
    else if (nums[i] <= second_small)
      second_small = nums[i];
    else
      return true;
  }
  return false;
}

static int Compress(char[] chars)
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

static bool IsSubsequence(string s, string t)
{
  char[] sChars = s.ToCharArray();
  char[] tChars = t.ToCharArray();

  int lastIndex = 0;
  int currentIndex = -1;
  for (int i = 0; i < sChars.Length; i++)
  {
    currentIndex = t.IndexOf(sChars[i], lastIndex);
    if (currentIndex == -1 || (currentIndex != 0 && currentIndex <= lastIndex))
    {
      return false;
    }
    lastIndex = currentIndex;
  }
  return true;
}

static int MaxArea(int[] height)
{
  int maxArea = 0;
  for (int i = 0; i < height.Length; i++)
  {
    for (int j = i + 1; j < height.Length; j++)
    {
      // height: min of 2 values
      // width : j - i 
      int h = height[i] < height[j] ? height[i] : height[j];
      int area = h * (j - i);
      if (area > maxArea) maxArea = area;
    }
  }
  return maxArea;
}

static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
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

static bool UniqueOccurrences(int[] arr)
{
  var dictionary = new Dictionary<int, int>();
  foreach (var num in arr)
  {
    dictionary[num] = dictionary.ContainsKey(num) ? dictionary[num] + 1 : 1;
  }

  var countSet = new HashSet<int>(dictionary.Values);
  return countSet.Count == dictionary.Count;
}

static bool CloseStrings(string word1, string word2)
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

static int EqualPairs__(int[][] grid)
{
  int[,] columnGrid = new int[grid.Length, grid.Length];
  // [[3,2,1],[1,7,6],[2,7,7]]

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

static int[] GetRow(int[,] matrix, int nth)
{
  return Enumerable.Range(0, matrix.GetLength(0))
      .Select(x => matrix[nth, x])
      .ToArray();
}

static int EqualPairs(int[][] grid)
{
  IList<int[]> columnGrid = new List<int[]>();
  // [[3,2,1],[1,7,6],[2,7,7]]

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
      // if (grid[i].ToList().SequenceEqual(columnGrid[])
      if (grid[i].SequenceEqual(columnGrid[j]))
      {
        equalCount++;
      }
    }
  }

  return equalCount;
}

// RemoveStars("leet**cod*e");
static string RemoveStars(string s)
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

static int[] AsteroidCollision(int[] asteroids)
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
        // stack.Push(a);
      }
      else // absolute values are equal
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


static string DecodeString(string s)
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

static string RemoveNonAlphanumeric(string input)
{
  // Replace all characters that are not letters or digits with an empty string
  // return Regex.Replace(input, @"[^\w\d]", "");

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

static string Reverse(string input)
{
  StringBuilder sb = new();
  for (int i = input.Length - 1; i >= 0; i--)
  {
    sb.Append(input[i]);
  }
  return sb.ToString();
}