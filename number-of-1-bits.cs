// 191. Number of 1 Bits   
// https://leetcode.com/problems/number-of-1-bits
// Easy 39.2%
// 1537.9755221280107
// Submission: https://leetcode.com/submissions/detail/68817737/
// Runtime: 52 ms
// Your runtime beats 27.89 % of csharp submissions.

public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        while (n > 0)
        {
            n &= n-1;
            count++;
        }
        return count;
    }
}
