// 29. Divide Two Integers   
// https://leetcode.com/problems/divide-two-integers
// Medium 16.0%
// 836.0892166158195
// Submission: https://leetcode.com/submissions/detail/73142216/
// Runtime: 49 ms
// Your runtime beats 68.57 % of csharp submissions.

public class Solution {
    public int Divide(long dividend, long divisor) 
    {
        if (divisor==0 || dividend==int.MinValue && divisor==-1)
            return int.MaxValue;
                    int sign = (divisor<0) ^ (dividend<0) ? -1 : 1;
        long dvd = Math.Abs(dividend);
        long dvs = Math.Abs(divisor);
        long result = 0;
        while(dvd>=dvs)
        {
            long tmp = dvs, multiple = 1;
            while (dvd >= (tmp<<1))
            {
                tmp <<= 1;
                multiple <<= 1;
            }
            dvd -= tmp;
            result += multiple;
        }
        return (int)(sign * result);
    }
}
