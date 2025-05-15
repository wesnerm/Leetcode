// 128. Longest Consecutive Sequence   
// https://leetcode.com/problems/longest-consecutive-sequence
// Hard 36.3%
// 962.7141604504974
// Submission: https://leetcode.com/submissions/detail/68421128/
// Runtime: 156 ms
// Your runtime beats 27.85 % of csharp submissions.

public class Solution {
    public int LongestConsecutive(int[] nums) {
        int result = 0;
        var map = new Dictionary<int, int>();
        foreach(var n in nums)
        {
            if (map.ContainsKey(n)) continue;
            int left = map.ContainsKey(n-1) ? map[n-1] : 0;
            int right = map.ContainsKey(n+1) ? map[n+1] : 0;
            int sum = left + right + 1;
            map[n] = sum;
                        result = Math.Max(result, sum);
            map[n-left] = sum;
            map[n+right] = sum;
        }
        return result;
    }
}
