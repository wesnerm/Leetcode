// 172. Factorial Trailing Zeroes   
// https://leetcode.com/problems/factorial-trailing-zeroes
// Easy 35.6%
// 1217.693302149692
// Submission: https://leetcode.com/submissions/detail/70444702/
// Runtime: 64 ms
// Your runtime beats 1.49 % of csharp submissions.

public class Solution {
    public int TrailingZeroes(int n) 
    {
        return n==0 ? 0 : n/5 + TrailingZeroes(n/5);
    }
}
