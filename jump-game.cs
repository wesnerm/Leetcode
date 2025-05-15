// 55. Jump Game   
// https://leetcode.com/problems/jump-game
// Medium 29.4%
// 748.636424915571
// Submission: https://leetcode.com/submissions/detail/70781097/
// Runtime: 180 ms
// Your runtime beats 13.19 % of csharp submissions.

public class Solution {
    public bool CanJump(int[] nums) {
        int max = 0;
        for (int i=0; i<nums.Length; i++)
        {
            if (i>max) return false;
            max = Math.Max(max, nums[i]+i);
        }
        return true;
    }
}
