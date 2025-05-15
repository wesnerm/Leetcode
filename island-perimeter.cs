// 463. Island Perimeter   
// https://leetcode.com/problems/island-perimeter
// Easy 57.0%
// 967.2563823280133
// Submission: https://leetcode.com/submissions/detail/101885295/
// Runtime: 352 ms
// Your runtime beats 42.73 % of csharp submissions.

public class Solution {
    int rw;
    int cl;
    int[,] grid;
        public int IslandPerimeter(int[,] grid) {
        this.grid = grid;
        rw = grid.GetLength(0);
        cl = grid.GetLength(1);
        int cnt = 0;
        for (int r=0; r<rw; r++)
        for (int c=0; c<cl; c++)
        {
            var cell = grid[r,c] == 1;
            if (cell != Check(r-1,c)) cnt++;
            if (cell != Check(r,c-1)) cnt++;
        }
                for (int r=0; r<rw; r++)
            if (Check(r,cl-1)) cnt++;
                    for (int c=0; c<cl; c++)
            if (Check(rw-1,c)) cnt++;
                    return cnt;
    }
        public bool Check(int r, int c)
    {
        return r>=0 && c>=0 && r<rw && c<cl && grid[r,c]==1;
    }
    }
