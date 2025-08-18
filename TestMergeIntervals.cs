using System.Text.Json;

public class TestMergeIntervals
{
  public static List<int[]> Merge(List<int[]> intervals)
  {
    if (intervals.Count == 0) return new List<int[]>();

    // 시작점 기준 정렬
    intervals.Sort((a, b) => a[0].CompareTo(b[0]));
    Console.WriteLine("Sorted Intervals:");
    Console.WriteLine(JsonSerializer.Serialize(intervals));

    var result = new List<int[]>();
    int[] current = intervals[0];

    foreach (var interval in intervals)
    {
      if (interval == intervals[0])
      {
        Console.WriteLine("Skipped first interval for current.");
        continue;
      }


      if (interval[0] <= current[1])
      {
        // 겹치면 끝점 확장
        current[1] = Math.Max(current[1], interval[1]);
      }
      else
      {
        // 겹치지 않으면 결과에 추가하고 current 갱신
        result.Add(current);
        current = interval;
      }
    }

    result.Add(current); // 마지막 구간 추가
    return result;
  }


  public static void Main()
  {
    var intervals = new List<int[]> {
      new int[]{1,3},
      new int[]{2,6},
      new int[]{15,18},
      new int[]{17,20},
      new int[]{8,10}
    };

    var merged = TestMergeIntervals.Merge(intervals);

    foreach (var interval in merged)
    {
      Console.WriteLine($"[{interval[0]}, {interval[1]}]");
    }
  }
}