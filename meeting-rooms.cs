// 252. Meeting Rooms   
// https://leetcode.com/problems/meeting-rooms
// Easy 46.7%
// 606.8277687995661
// Submission: https://leetcode.com/submissions/detail/68492852/
// Runtime: 216 ms
// Your runtime beats 35.59 % of csharp submissions.

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
    public bool CanAttendMeetings(Interval[] intervals) {
        Array.Sort(intervals, (a,b)=>a.start-b.start);
        for(int i=1; i<intervals.Length;i++)
        {
            if (intervals[i-1].end > intervals[i].start)
                return false;
        }
        return true;
    }
}
