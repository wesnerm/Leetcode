// 306. Additive Number   
// https://leetcode.com/problems/additive-number
// Medium 27.3%
// 872.2030784223227
// Submission: https://leetcode.com/submissions/detail/71314631/
// Runtime: 132 ms
// Your runtime beats 12.50 % of csharp submissions.

using System.Numerics;
public class Solution {
    public bool IsAdditiveNumber(string num) {
        return Dfs(num, 0, 0, 0, 0);
    }
        bool Dfs(string num, int index, int depth, BigInteger first, BigInteger second)
    {
        if (index==num.Length)
            return depth>=3;
        if (num[index]=='0')
            return (depth<2||first+second==0) && Dfs(num, index+1, depth+1, second, 0);
                if (depth < 2)
        {
            int minDigits = Math.Max(1, index/2);
            int maxDigits =num.Length/2;
            for (int i=index+minDigits; i<=index+maxDigits; i++)
            {
                var s = num.Substring(index, i-index);
                if (Dfs(num, i, depth+1, second, BigInteger.Parse(s)))
                    return true;
            }        
        }
        else
        {
            var sum = first + second;
            var sumString = sum.ToString();
            int i = index+sumString.Length;
            if (i <= num.Length
                    && num.Substring(index, i-index) == sumString)
                return Dfs(num, i, depth+1, second, sum);
        }
                return false;
    }
}
