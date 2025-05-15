// 486. Predict the Winner   
// https://leetcode.com/problems/predict-the-winner
// Medium 44.6%
// 276.49087632195796
// Submission: https://leetcode.com/submissions/detail/101885990/
// Runtime: 402 ms
// Your runtime beats 6.06 % of csharp submissions.

using System;
public class Solution {
        int[] nums;
        public bool PredictTheWinner(int[] nums) {
        this.nums = nums;
        int win = Dfs(0, nums.Length-1, 0);
        return (win>=0);
    }
        int Dfs(int left, int right, int score)
    {
        if (left>right) return score;
        int m = -Dfs(left+1, right, -(score+nums[left]));
        int m2 = -Dfs(left, right-1, -(score+nums[right]));
        return Math.Max(m, m2);
    }
    }
