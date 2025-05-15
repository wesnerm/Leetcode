// 342. Power of Four   
// https://leetcode.com/problems/power-of-four
// Easy 38.2%
// 630.3261746008806
// Submission: https://leetcode.com/submissions/detail/68930802/
// Runtime: 72 ms
// Your runtime beats 1.89 % of csharp submissions.

public class Solution {
    public bool IsPowerOfFour(int num) {
        return num>=1
            && (num & (num-1)) == 0
            && (num & 0x55555555) != 0;
    }
}
