// 435. Non-overlapping Intervals   
// https://leetcode.com/problems/non-overlapping-intervals
// Medium 40.5%
// 330.82645661886005
// Submission: https://leetcode.com/submissions/detail/101882007/
// Runtime: 202 ms
// Your runtime beats 32.14 % of csharp submissions.

/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public int EraseOverlapIntervals(Interval[] intervals)
    {
        var list = intervals.ToList();
        list.Sort((a, b) =>
        {
            int cmp = a.end.CompareTo(b.end);
            if (cmp != 0)
                return cmp;
            return a.start.CompareTo(b.start);
        });
        int remove = 0;
        Interval ival = null;
        foreach (var v in list)
        {
            if (ival == null)
            {
                ival = v;
                continue;
            }
            if (v.start < ival.end)
                remove++;
            else
                ival = v;
        }
        return remove;
    }
}
