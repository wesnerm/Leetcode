// 343. Integer Break   
// https://leetcode.com/problems/integer-break
// Medium 45.6%
// 678.5223719766705
// Submission: https://leetcode.com/submissions/detail/71198498/
// Runtime: 52 ms
// Your runtime beats 45.95 % of csharp submissions.

public class Solution {
    public int IntegerBreak(int n) {
        if (n==2) return 1;
        if (n==3) return 2;
        int product = 1;
                if (n>4)
        {
            int p = ((n-4)+2)/3;
            product *= Pow(3,p);
            n -= p*3;
        }
                /*
        while (n>4)
        {
            product *= 3;
            n-=3;
        }
                */
        product *= n;
        return product;
    }
            int Pow(int n, int p)
    {
        int b = n;
        int result = 1;
                while (p>0)
        {
            if (p%2==1)
                result *= b;
            b*=b;
            p>>=1;
        }
                return result;
    }
}
