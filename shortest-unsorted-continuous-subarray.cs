// 581. Shortest Unsorted Continuous Subarray   
// https://leetcode.com/problems/shortest-unsorted-continuous-subarray
// Easy 29.6%
// 258.6958866655694
// Submission: https://leetcode.com/submissions/detail/105458617/
// Runtime: 215 ms
// Your runtime beats 43.84 % of csharp submissions.

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
                int max = int.MinValue;
        int min = int.MaxValue;
        var maxes = new int[nums.Length];
        var mins = new int[nums.Length];
        for (int i=0; i<nums.Length; i++)
        {
            maxes[i] = max = Math.Max(max, nums[i]);
            mins[nums.Length-i-1] = min = Math.Min(min, nums[nums.Length-i-1]);
        }
                int first = 0;
        while (first<nums.Length && nums[first]<=mins[first])
            first++;
        int last = nums.Length-1;
        while (last>=0 && nums[last] >= maxes[last])
            last--;
                    return Math.Max(0,last-first+1);
    }
}
