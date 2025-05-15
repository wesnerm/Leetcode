// 137. Single Number II   
// https://leetcode.com/problems/single-number-ii
// Medium 41.0%
// 1145.1368802006011
// Submission: https://leetcode.com/submissions/detail/69977007/
// Runtime: 140 ms
// Your runtime beats 83.02 % of csharp submissions.

public class Solution {
    public int SingleNumber(int[] nums) {
        int m0 = -1;
        int m1 = 0;
        int m2 = 0;
        foreach (int n in nums)
        {
            int m2old = m2;
            m2 = m2 & ~n | m1 & n;
            m1 = m1 & ~n | m0 & n;
            m0 = m0 & ~n | m2old & n;
        }
        return m1;
    }
}
