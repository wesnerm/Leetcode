// 539. Minimum Time Difference   
// https://leetcode.com/problems/minimum-time-difference
// Medium 45.6%
// 242.0288845195382
// Submission: https://leetcode.com/submissions/detail/105460101/
// Runtime: 175 ms
// Your runtime beats 45.45 % of csharp submissions.

using System;
using System.Linq;
public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        int[] array = timePoints.Select(x=>{
            var split = x.Split(':').Select(int.Parse).ToArray();
            return split[0] * 60 + split[1];
        }).ToArray();
                Array.Sort(array);
        int diff = 24*60+array[0] - array[array.Length-1];
        for (int i=1; i<array.Length;i++)
            diff = Math.Min(diff, array[i]-array[i-1]);
        return diff;
    }
}
