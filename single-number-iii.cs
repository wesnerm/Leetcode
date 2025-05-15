// 260. Single Number III   
// https://leetcode.com/problems/single-number-iii
// Medium 50.9%
// 902.2274466760265
// Submission: https://leetcode.com/submissions/detail/69978275/
// Runtime: 508 ms
// Your runtime beats 23.53 % of csharp submissions.

public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach(var n in nums)
            xor = xor ^ n;
        int [] res = new int[2];
        int bit = xor & -xor;
        foreach(var n in nums)
            res[(n&bit)==0? 0:1] ^= n;
        return res;
    }
}
