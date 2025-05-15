// 69. Sqrt(x)   
// https://leetcode.com/problems/sqrtx
// Easy 27.6%
// 841.0615069004631
// Submission: https://leetcode.com/submissions/detail/69651401/
// Runtime: 52 ms
// Your runtime beats 48.67 % of csharp submissions.

public class Solution {
    public int MySqrt2(int x) {
        long r = x;
        while (r*r > x)
            r = (r + x/r) / 2;
        return (int) r;
    }
        public int MySqrt(int x)
    {
        long lo = 0;
        long hi = x;
                while (lo<=hi)
        {
            long mid = lo + (hi-lo)/2;
            long sq = mid * mid;
            if (sq > x)
                hi=mid-1;
            else if (sq < x)
                lo=mid+1;
            else
                return (int)mid;
        }
            return (int)hi;
    }
}
