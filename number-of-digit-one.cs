// 233. Number of Digit One   
// https://leetcode.com/problems/number-of-digit-one
// Hard 28.0%
// 1044.0631363720295
// Submission: https://leetcode.com/submissions/detail/70443716/
// Runtime: 52 ms
// Your runtime beats 46.67 % of csharp submissions.

public class Solution {
    public int CountDigitOne(int n) {
        if (n<1) return 0;
        if (n<10) return 1;
        int factor = 1;
        int log10 = 0;
        while (n>=(long)10*factor)
        {
            factor *= 10;
            log10++;
        }
                int result = 0;
        int d = n/factor;
        result += d * log10 * (int)Pow(10,log10-1);
        result += CountDigitOne(n % factor);
                if (d>1)
            result += factor;
        else
            result += n-factor+1;
                    return result;
    }
        long Pow(long n, long p)
    {
        var b = n;
        long result = 1;
        while (p>0)
        {
            if (p%2==1) result *= b;
            p/=2;
            b*=b;
        }
        return result;
    }
    }
