// 495. Teemo Attacking   
// https://leetcode.com/problems/teemo-attacking
// Medium 51.9%
// 325.3618404765066
// Submission: https://leetcode.com/submissions/detail/101886088/
// Runtime: 219 ms
// Your runtime beats 52.50 % of csharp submissions.

using System;
public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) 
    {        
        long end = long.MinValue;
        long sum = 0;
        foreach(var n in timeSeries)
        {
            long newStart = Math.Max(n, end);
            long newEnd = n+duration;
            sum += Math.Max(0, newEnd - newStart);
            end = newEnd;
        }
        return (int)sum;
    }
}
