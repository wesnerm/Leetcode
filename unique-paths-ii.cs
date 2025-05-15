// 63. Unique Paths II   
// https://leetcode.com/problems/unique-paths-ii
// Medium 31.4%
// 461.00319931761146
// Submission: https://leetcode.com/submissions/detail/70680565/
// Runtime: 156 ms
// Your runtime beats 15.15 % of csharp submissions.

public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        int m = obstacleGrid.GetLength(0);
        int n = obstacleGrid.GetLength(1);
                int[] v= new int [n+1];
        v[1] = 1;
                for (int i=1; i<=m; i++)
            for (int j=1; j<=n; j++)
            {
                v[j] = obstacleGrid[i-1,j-1]==1
                    ? 0
                    : v[j-1] + v[j];
            }
        return v[n];
    }
}
