// 200. Number of Islands   
// https://leetcode.com/problems/number-of-islands
// Medium 33.8%
// 1112.0737070841205
// Submission: https://leetcode.com/submissions/detail/67594262/
// Runtime: 152 ms
// Your runtime beats 21.38 % of csharp submissions.

public class Solution {
        public int rows;
    public int cols;
    public char[,] grid;
        public int NumIslands(char[,] grid) {
        rows = grid.GetLength(0);
        cols = grid.GetLength(1);
        this.grid = grid;
                int count = 0;
                for (int i=0; i<rows; i++)
            for (int j=0; j<cols; j++)
                if (grid[i,j] != '0' )
                {
                    Dfs(i,j);
                    count++;
                }
                        return count;
    }
        private void Dfs(int r, int c)
    {
        if (r<0 || r>=rows || c<0 || c>=cols)
            return;
                if (grid[r,c] == '0')
            return;
                grid[r,c] = '0';
        Dfs(r-1,c);
        Dfs(r+1,c);
        Dfs(r,c-1);
        Dfs(r,c+1);
    }
    }
