// 56. Merge Intervals   
// https://leetcode.com/problems/merge-intervals
// Medium 29.5%
// 985.6984993706586
// Submission: https://leetcode.com/submissions/detail/68425812/
// Runtime: 572 ms
// Your runtime beats 17.01 % of csharp submissions.

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
    public IList<Interval> Merge(IList<Interval> intervals) {
        var list = new List<Interval>(intervals);
        list.Sort((a,b) => (a.start==b.start) ?  a.end-b.end : a.start-b.start);
                int write=0;
        int read;
        for (read=0; read<list.Count; read++)
        {
            var itemRead = list[read];
                        int last = write-1;
            if (last>=0)
            {
                if (itemRead.start<=list[last].end)
                {
                    list[last].end = Math.Max(list[last].end, itemRead.end);
                    continue;
                }
            }
                        list[write++] = itemRead;
        }
        list.RemoveRange(write, read-write);
        return list;
    }
}
