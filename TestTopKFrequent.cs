public class TestTopKFrequent
{
  public IEnumerable<int> GetResult(int[] nums, int k)
  {
    var count = new Dictionary<int, int>();
    foreach (var num in nums)
    {
      if (!count.ContainsKey(num))
        count[num] = 0;
      count[num]++;
    }

    // 등장 횟수 기준 내림차순 정렬 후 상위 k개 선택
    return count.OrderByDescending(x => x.Value)
                .Take(k)
                .Select(x => x.Key);
  }

  public static void RunTest()
  {
    var topKFrequent = new TestTopKFrequent();
    var nums = new int[] { 1, 1, 1, 2, 2, 3, 3, 3, 4 };
    int k = 3;
    var result = topKFrequent.GetResult(nums, k);

    Console.WriteLine("Top K Frequent Elements:");
    foreach (var num in result)
    {
      Console.WriteLine(num);
    }
  }
}