public class Test3
{
  public static int FindMissingNumber(int[] numbers)
  {
    // 1부터 n까지의 합을 구합니다.
    int n = numbers.Length + 1;
    int expectedSum = n * (n + 1) / 2;

    // 주어진 배열의 합을 구합니다.
    int actualSum = 0;
    foreach (int number in numbers)
    {
      actualSum += number;
    }

    // 누락된 숫자를 계산합니다.
    return expectedSum - actualSum;
  }

  public static string LongestCommonPrefix(string[] strs)
  {
    if (strs == null || strs.Length == 0) return "";

    // 첫 번째 문자열을 기준으로 설정
    string prefix = strs[0];

    foreach (string str in strs)
    {
      // 현재 접두사와 비교하여 일치하지 않는 부분을 찾음
      while (str.IndexOf(prefix) != 0)
      {
        prefix = prefix.Substring(0, prefix.Length - 1);
        if (prefix.Length == 0) return "";
      }
    }

    return prefix;
  }

  public static List<List<string>> GroupAnagrams(string[] strs)
  {
    var anagramGroups = new Dictionary<string, List<string>>();

    foreach (string str in strs)
    {
      // 문자열을 정렬하여 키로 사용
      char[] charArray = str.ToCharArray();
      Array.Sort(charArray);
      string key = new string(charArray);

      if (!anagramGroups.ContainsKey(key))
      {
        anagramGroups[key] = new List<string>();
      }
      anagramGroups[key].Add(str);
    }

    return new List<List<string>>(anagramGroups.Values);
  }

  public static int MaxSubArray(int[] nums)
  {
    if (nums == null || nums.Length == 0) return 0;

    int maxSoFar = nums[0];
    int maxEndingHere = nums[0];

    Console.WriteLine($"At index {0}, maxEndingHere: {maxEndingHere}, maxSoFar: {maxSoFar}");

    for (int i = 1; i < nums.Length; i++)
    {
      maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
      maxSoFar = Math.Max(maxSoFar, maxEndingHere);
      Console.WriteLine($"At index {i}, maxEndingHere: {maxEndingHere}, maxSoFar: {maxSoFar}");
    }

    return maxSoFar;
  }

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value, TreeNode left = null, TreeNode right = null)
    {
      val = value;
      this.left = left;
      this.right = right;
    }

    public static bool ValidateBST(TreeNode node, int min = int.MinValue, int max = int.MaxValue)
    {
      if (node == null) return true;

      if (node.val <= min || node.val >= max)
      {
        Console.WriteLine($"Invalid BST at node {node.val}, min: {min}, max: {max}");
        return false;
      }

      return ValidateBST(node.left, min, node.val) && ValidateBST(node.right, node.val, max);
    }
  }

  public static void Main()
  {
    // Test FindMissingNumber
    int[] numbers = { 1, 2, 4, 5 };
    Console.WriteLine($"Missing number: {FindMissingNumber(numbers)}");

    // Test LongestCommonPrefix
    string[] strs = { "flower", "flow", "flight" };
    Console.WriteLine($"Longest common prefix: {LongestCommonPrefix(strs)}");

    // Test GroupAnagrams
    string[] anagrams = { "eat", "tea", "tan", "ate", "nat", "bat" };
    var groupedAnagrams = GroupAnagrams(anagrams);
    Console.WriteLine("Grouped Anagrams:");
    foreach (var group in groupedAnagrams)
    {
      Console.WriteLine(string.Join(", ", group));
    }

    // Test MaxSubArray
    int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
    Console.WriteLine($"Maximum Subarray Sum: {MaxSubArray(nums)}");

    // Test ValidateBST
    TreeNode root = new TreeNode(10,
      new TreeNode(5,
        new TreeNode(3),
        new TreeNode(7)),
      new TreeNode(15,
        null,
        new TreeNode(20)));

    Console.WriteLine($"Is valid BST: {TreeNode.ValidateBST(root)}");
  }
}