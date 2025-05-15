// 265. Paint House II   
// https://leetcode.com/problems/paint-house-ii
// Hard 37.7%
// 315.03574356352846
// Submission: https://leetcode.com/submissions/detail/71336148/
// Runtime: 204 ms
// Your runtime beats 21.05 % of csharp submissions.

public class Solution {
    public int MinCostII(int[,] costs) {
        int n = costs.GetLength(0);
        int k = costs.GetLength(1);
        if (n==0 || k==0) return 0;
        var dp = new int[n+1, k];
        for (int r=n-1; r<n; r++)
        for (int c=0; c<k; c++)
        {
            dp[r,c] = costs[r,c];
        }
                for (int r=n-2; r>=0; r--)
        for (int c=0; c<k; c++)
        {
            dp[r,c] = int.MaxValue;
            for (int c2=0; c2<k; c2++)
                if (c2 != c)
                    dp[r,c] = Math.Min(dp[r,c], dp[r+1,c2]);
            dp[r,c] += costs[r,c];
        }
        int mincost = int.MaxValue;
        for (int c=0; c<k; c++)
                mincost = Math.Min(mincost, dp[0,c]);
        return mincost;
    }
    }
