// 576. Out of Boundary Paths   
// https://leetcode.com/problems/out-of-boundary-paths
// Hard 33.3%
// 64.31906267606938
// Submission: https://leetcode.com/submissions/detail/105459271/
// Runtime: 66 ms
// Your runtime beats 80.00 % of csharp submissions.

public class Solution {
    int m;
    int n;
    long[,,] dp;
            public int FindPaths(int m, int n, int N, int i, int j) {
        this.m = m;
        this.n = n;
        dp = new long[m,n,N+1];
        return (int) Dfs(i,j,N);        
    }
        public long Dfs(int i, int j, int N)
    {
        if (i<0||j<0||i>=m||j>=n) return 1;
        if (N==0) return 0;
                var result = dp[i,j,N] - 1; 
        if (result >= 0) return result;
                result = 0;
        result += Dfs(i-1, j, N-1);
        result += Dfs(i+1, j, N-1);
        result += Dfs(i, j-1, N-1);
        result += Dfs(i, j+1, N-1);
        result %= 1000L * 1000L * 1000L + 7;
        dp[i,j,N] = result + 1;
        return result;
    }
    }
