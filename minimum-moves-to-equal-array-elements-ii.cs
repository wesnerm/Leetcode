// 462. Minimum Moves to Equal Array Elements II   
// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii
// Medium 51.1%
// 300.16093883043675
// Submission: https://leetcode.com/submissions/detail/101885429/
// Runtime: 149 ms
// Your runtime beats 90.32 % of csharp submissions.

public class Solution {
    public int MinMoves2(int[] nums) {
       if (nums.Length <= 1)
        return 0;
              Array.Sort(nums);
       int median = nums[nums.Length/2];
       return nums.Sum(x=>Math.Abs(x-median));
    }
}
