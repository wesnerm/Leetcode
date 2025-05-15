// 414. Third Maximum Number   
// https://leetcode.com/problems/third-maximum-number
// Easy 27.7%
// 412.06048370835856
// Submission: https://leetcode.com/submissions/detail/92228548/
// Runtime: 148 ms
// Your runtime beats 49.28 % of csharp submissions.

public class Solution {
    public int ThirdMax(int[] nums) {
        long n1 = long.MinValue;
        long n2 = long.MinValue;
        long n3 = long.MinValue;
        foreach(var k in nums)
        {
            if (k <= n3 ) continue;
            if (k > n2)
            {
                if (k > n1)
                {
                    n3 = n2;
                    n2 = n1;
                    n1 = k;
                }
                else if (k < n1)
                {
                    n3 = n2;
                    n2 = k;
                }
            }
            else if (k < n2)
            {
                n3 = k;
            }
        }
            Console.WriteLine($"{n1} {n2} {n3}");
        if (n3==long.MinValue) return (int)Math.Max(int.MinValue, n1);
        return (int)n3;
    }
}
