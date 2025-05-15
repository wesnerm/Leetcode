// 136. Single Number   
// https://leetcode.com/problems/single-number
// Easy 54.0%
// 2320.9975271714306
// Submission: https://leetcode.com/submissions/detail/69956946/
// Runtime: 204 ms
// Your runtime beats 4.83 % of csharp submissions.

public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach (int n in nums)
            result ^= n;
        return result;
    }
}
