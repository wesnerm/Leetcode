// 37. Sudoku Solver   
// https://leetcode.com/problems/sudoku-solver
// Hard 29.5%
// 717.6129707187125
// Submission: https://leetcode.com/submissions/detail/71453645/
// Runtime: 176 ms
// Your runtime beats 73.08 % of csharp submissions.

public class Solution {
    public void SolveSudoku(char[,] board) {
        Dfs(board, 0, 0);
    }
        bool Dfs(char[,] board, int r, int c)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
                while (r<rows && c<cols && board[r,c] != '.')
        {
            c++;
            if (c>=cols) { c = 0; r++; }
        }
                if (r>=rows)
            return true;
                int validnums = ValidNumbers(board,r,c);
        for (int i=0; i<9; i++)
        {
            if ((validnums & (1<<i)) != 0)
            {
                board[r,c] = (char)('1' + i);
                if (Dfs(board, r,c))
                    return true;
            }
        }
        board[r,c] = '.';
        return false;
    }
        public int ValidNumbers(char[,] board, int r, int c)
    {
        int mask = 0;
                int rs = (r/3)*3;
        int cs = (c/3)*3;
        for (int i=0; i<9; i++)
        {
            if (board[i,c] != '.') mask |= 1<<(board[i,c]-'1');
            if (board[r,i] != '.') mask |= 1<<(board[r,i]-'1');
            if (board[rs+i/3,cs+i%3] != '.') mask |= 1<<(board[rs+i/3,cs+i%3]-'1');
        }
                return mask ^ (1<<9)-1;
    }
}
