// 417. Pacific Atlantic Water Flow   
// https://leetcode.com/problems/pacific-atlantic-water-flow
// Medium 33.3%
// 436.80847280461484
// Submission: https://leetcode.com/submissions/detail/101840378/
// Runtime: 499 ms
// Your runtime beats 76.47 % of csharp submissions.

public class Solution {
    int rows;
    int cols;
    int[,] flow;
    int[,] matrix;
    public IList<int[]> PacificAtlantic(int[,] matrix) {
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
        this.matrix = matrix;
                flow = new int[rows, cols];
        var result = new List<int[]>();
        for (int r=0; r<rows; r++)
        {
            Dfs(r,0, int.MinValue, 1);
            Dfs(r,cols-1, int.MinValue, 2);
        }
        for (int c=0; c<cols; c++)
        {
            Dfs(0, c, int.MinValue, 1);
            Dfs(rows-1, c, int.MinValue, 2);
        }
        for (int r=0; r<rows; r++)
        for (int c=0; c<cols; c++)
            if (flow[r,c] == 3) 
                result.Add(new[]{r,c});
        return result;
    }
        void Dfs(int r, int c, int h, int bits)
    {
        if (bits==0 || r<0 || c<0) return;
        if (r>=rows || c>=cols) return;
        int h0 = matrix[r,c];
        if (h0 < h) return;
                var f = flow[r,c];
                if ( (f&bits) == bits) return;
        f |= bits;
                flow[r,c] = f;
                Dfs(r+1, c, h0, f);
        Dfs(r-1, c, h0, f);
        Dfs(r, c+1, h0, f);
        Dfs(r, c-1, h0, f);
    }
        }
