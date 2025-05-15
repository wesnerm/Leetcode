// 633. Sum of Square Numbers   
// https://leetcode.com/problems/sum-of-square-numbers
// Easy 31.5%
// 364.77132270994633
// Submission: https://leetcode.com/submissions/detail/111480916/
// Runtime: 66 ms
// Your runtime beats 76.15 % of csharp submissions.

public class Solution {
    public bool JudgeSquareSum(int c) {
        for (int i=0; i*1L*i<=c; i++)
        {
            var b2 = c-i*i;
            int b = (int)Math.Sqrt(b2);
            if (b*b==b2) return true;
        }
                return false;
    }
}
