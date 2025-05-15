// 64. Minimum Path Sum   
// https://leetcode.com/problems/minimum-path-sum
// Medium 38.0%
// 779.1531851355522
// Submission: https://leetcode.com/submissions/detail/70679026/
// Runtime: 184 ms
// Your runtime beats 14.49 % of csharp submissions.

public class Solution {
    public int MinPathSum(int[,] grid) {
        int m = grid.GetLength(0);
        int n = grid.GetLength(1);
                int[] v = new int[n+1];
        for (int i = 0; i<=n; i++)
            v[i] = int.MaxValue;
        v[1] = 0;
                    for (int i=1; i<=m; i++)
            for (int j=1; j<=n; j++)
                v[j] = grid[i-1,j-1] + Math.Min(v[j], v[j-1]);
        return v[n];
    }
}
