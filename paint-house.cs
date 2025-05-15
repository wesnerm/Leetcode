// 256. Paint House   
// https://leetcode.com/problems/paint-house
// Easy 45.9%
// 534.7815911637604
// Submission: https://leetcode.com/submissions/detail/71334514/
// Runtime: 188 ms
// 

public class Solution {
    public int MinCost(int[,] costs) {
        int n = costs.GetLength(0);
        var dp = new int[n+1, 3];
                for (int r=n-1; r>=0; r--)
            for (int c=0; c<3; c++)
                dp[r,c] = Math.Min(dp[r+1,(c+1)%3],dp[r+1,(c+2)%3])+costs[r,c];
        return Math.Min(dp[0,0], Math.Min(dp[0,1], dp[0,2]));
    }
    }
