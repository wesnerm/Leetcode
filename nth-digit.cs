// 400. Nth Digit   
// https://leetcode.com/problems/nth-digit
// Easy 30.1%
// 443.90077084520726
// Submission: https://leetcode.com/submissions/detail/74865527/
// Runtime: 15 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public int FindNthDigit(long n)
    {
        if (n == 0)
            return 0;
        int digits = 1;
        long factor = 1;
        n--;
        while (true)
        {
            var addend = 9 * digits * factor;
            if (n < addend) break;
            n -= addend;
            factor *= 10;
            digits++;
        }
        var mod = n % digits;
        n /= digits;
        n += factor;
        while (mod + 1 < digits)
        {
            mod++;
            n /= 10;
        }
        return (int)(n%10);
    }
}
