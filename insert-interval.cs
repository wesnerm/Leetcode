// 57. Insert Interval   
// https://leetcode.com/problems/insert-interval
// Hard 27.2%
// 594.4785440697427
// Submission: https://leetcode.com/submissions/detail/68426878/
// Runtime: 544 ms
// Your runtime beats 27.59 % of csharp submissions.

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
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval) {
        var list = new List<Interval>();
                int read = 0;
        // Read before
        while (read <intervals.Count && intervals[read].end < newInterval.start)
            list.Add(intervals[read++]);
        var ival = newInterval;
        if (read < intervals.Count)
        {
            if (ival.start > intervals[read].start)
                ival.start = intervals[read].start;
            while (read < intervals.Count && intervals[read].start<=ival.end)
            {
                ival.end = Math.Max(intervals[read].end, ival.end);
                read++;
            }
        }
        list.Add(ival);
        while (read <intervals.Count)
            list.Add(intervals[read++]);
                    return list;
    }
}
