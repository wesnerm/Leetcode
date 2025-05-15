// 372. Super Pow   
// https://leetcode.com/problems/super-pow
// Medium 33.9%
// 606.8096942524609
// Submission: https://leetcode.com/submissions/detail/66636764/
// Runtime: 188 ms
// Your runtime beats 36.36 % of csharp submissions.

public class Solution {
    const int MOD = 1337;
        public int SuperPow(int a, int[] b) {
        int result = 1;
        int ax = a % 1337;
        for (int i=0; i<b.Length; i++)
            result = (ModPow(result, 10) * ModPow(ax, b[i])) % 1337;
        return result;        
    }
        public static int ModPow(int n, int p)
    {
        int b = n;
        int result = 1;
        while (p != 0)
        {
            if ((p & 1) != 0)
                result = (result * b) % MOD;
            p >>= 1;
            b = (b * b) % MOD;
        }
        return result;
    }
}
