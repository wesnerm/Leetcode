// 45. Jump Game II   
// https://leetcode.com/problems/jump-game-ii
// Hard 26.1%
// 700.3725331350888
// Submission: https://leetcode.com/submissions/detail/70782883/
// Runtime: 168 ms
// Your runtime beats 31.37 % of csharp submissions.

public class Solution {
    public int Jump(int[] nums) 
    {
        int reach = 0;
        int max = 0;
        int steps = 0;
                for (int i=0; i<nums.Length-1; i++)
        {
            max = Math.Max(max, nums[i] + i);
            if (i==reach)
            {
                steps++;
                reach = max;
            }
        }
        return steps;
    }
}
