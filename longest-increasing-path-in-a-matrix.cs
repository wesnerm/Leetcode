// 329. Longest Increasing Path in a Matrix   
// https://leetcode.com/problems/longest-increasing-path-in-a-matrix
// Hard 36.0%
// 589.4952579423697
// Submission: https://leetcode.com/submissions/detail/69549088/
// Runtime: 228 ms
// Your runtime beats 70.59 % of csharp submissions.

public class Solution {
    int[,] matrix;
    int[,] lengths;
    int[] delta = new int [] { 0, 1, 0, -1, 0 };
    int rows;
    int cols;
        public int LongestIncreasingPath(int[,] matrix) {
        this.matrix = matrix;
        this.rows = matrix.GetLength(0);
        this.cols = matrix.GetLength(1);
        this.lengths = new int[rows,cols];
                int maxlen = 0;
        for (int r=0; r<rows; r++)
        for (int c=0; c<cols; c++)
        {
            int len = Dfs(r,c);
            maxlen = Math.Max(len, maxlen);
        }
                return maxlen;
    }
        public int Dfs(int r, int c)
    {
        if (lengths[r,c]>0)
            return lengths[r,c];
        int val = matrix[r,c];
        int maxlen = 1;
        for (int d=0; d<4; d++)
        {
            int r2 = r+delta[d];
            int c2 = c+delta[d+1];
            if (r2<0 || c2<0 || r2>=rows || c2>=cols || matrix[r2,c2] <= val)
                continue;
                        int len = 1+Dfs(r2,c2);
            maxlen = Math.Max(len, maxlen);
        }
        lengths[r,c] = maxlen;
        return maxlen;
    }
}
