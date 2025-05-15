// 375. Guess Number Higher or Lower II   
// https://leetcode.com/problems/guess-number-higher-or-lower-ii
// Medium 35.5%
// 574.2870019969522
// Submission: https://leetcode.com/submissions/detail/68214179/
// Runtime: 88 ms
// Your runtime beats 35.71 % of csharp submissions.

public class Solution {
    public int GetMoneyAmount(int n) {
        var table = new int[n+1,n+1];
        return DP(table, 1, n);
    }
        public int DP(int[,]table, int lo, int hi)
    {
        if (lo>=hi) return 0;
        if (table[lo,hi] != 0) return table[lo,hi];
        int result = int.MaxValue;
        for (int x=lo; x<=hi; x++)
        {
            int tmp = x + Math.Max(DP(table,lo,x-1), DP(table,x+1,hi));
            result = Math.Min(result, tmp);
        }
        table[lo,hi] = result;
        return result;
    }
    }
