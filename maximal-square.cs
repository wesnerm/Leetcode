// 221. Maximal Square   
// https://leetcode.com/problems/maximal-square
// Medium 28.3%
// 661.6717591556388
// Submission: https://leetcode.com/submissions/detail/71159792/
// Runtime: 158 ms
// Your runtime beats 21.05 % of csharp submissions.

public class Solution {
    public int MaximalSquare2(char[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
                int[,] dp = new int[m+1,n+1];
        int result = 0;
        for (int i=1; i<=m; i++)
        for (int j=1; j<=n; j++)
            if (matrix[i-1,j-1] == '1')
            {
                dp[i,j] = Math.Min(Math.Min(dp[i,j-1], dp[i-1,j]), dp[i-1,j-1]) + 1;
                result = Math.Max(dp[i,j], result);            
            }
                return result * result;
    }
        public int MaximalSquare(char[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
                int[] dp = new int[n+1];
        int result = 0;
        for (int i=1; i<=m; i++)
        {
            int prev = 0;
            for (int j=1; j<=n; j++)
            {
                int tmp = dp[j];
                if (matrix[i-1,j-1] == '1')
                {
                    dp[j] = Math.Min(Math.Min(dp[j-1], dp[j]), prev) + 1;
                    result = Math.Max(dp[j], result);            
                }
                else
                {
                    // Add this case, when optimizing dp problems... we have to initialize every cell,
                    // because the cells are reused and may not be zero
                    dp[j] = 0;
                }
                prev = tmp;
            }
        }
        return result * result;
    }
}
