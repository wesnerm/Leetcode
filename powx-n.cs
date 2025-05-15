// 50. Pow(x, n)   
// https://leetcode.com/problems/powx-n
// Medium 26.5%
// 1099.1125493370646
// Submission: https://leetcode.com/submissions/detail/67565291/
// Runtime: 72 ms
// Your runtime beats 5.93 % of csharp submissions.

public class Solution {
    public double MyPow(double x, int n) {
        double result = 1;
        double b = x;
        if (n<0)
        {
            if (n==int.MinValue)
                return 1/MyPow(x, int.MaxValue)/x;
            return 1/MyPow(x,-n);
        }
                while (n>0)
        {
            if (n % 2 == 1)
                result *= b; 
            n >>= 1;
            b *= b;
        }
                return result;
    }
    }
