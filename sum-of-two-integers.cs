// 371. Sum of Two Integers   
// https://leetcode.com/problems/sum-of-two-integers
// Easy 51.2%
// 1822.2477678262103
// Submission: https://leetcode.com/submissions/detail/66642356/
// Runtime: 48 ms
// Your runtime beats 42.98 % of csharp submissions.

public class Solution {
    public int GetSum(int a, int b) {
        int xorsum = a ^ b;
        int xorand = a & b;
        int carry = xorand << 1;
        int oldcarry;
        do
        {
            oldcarry = carry;
            carry |= (xorsum & carry) << 1;
        }
        while (oldcarry != carry);
        return xorsum ^ carry;
   }
}
