// 436. Find Right Interval   
// https://leetcode.com/problems/find-right-interval
// Medium 41.0%
// 197.68509452575785
// Submission: https://leetcode.com/submissions/detail/101882078/
// Runtime: 672 ms
// Your runtime beats 92.86 % of csharp submissions.

/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
 using System.Linq;
 public class Solution {
    public int[] FindRightInterval(Interval[] intervals)
    {
        var indexMap = Enumerable.Range(0, intervals.Length).ToDictionary(i => intervals[i]);
        var list = intervals.ToList();
        list.Sort((a, b) =>
        {
            int cmp = a.start.CompareTo(b.start);
            if (cmp == 0)
                cmp = a.end.CompareTo(b.end);
            return cmp;
        });
        int[] result = new int[list.Count];
        foreach (var ival in list)
        {
            int i = indexMap[ival];
            int index = BinSearch(list, ival.end);
            if (index >= list.Count)
                index = -1;
            else
                index = indexMap[list[index]];
            result[i] = index;
        }
        return result;
    }
    public int BinSearch(List<Interval> list, int target)
    {
        int left = 0;
        int right = list.Count - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (target > list[mid].start)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return left;
    }
}
