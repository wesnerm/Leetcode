// 36. Valid Sudoku   
// https://leetcode.com/problems/valid-sudoku
// Medium 35.1%
// 968.2647330158262
// Submission: https://leetcode.com/submissions/detail/70445780/
// Runtime: 144 ms
// Your runtime beats 50.00 % of csharp submissions.

public class Solution {
    public bool IsValidSudoku(char[,] board) {
        for (int i=0; i<9; i++)
        {
            int bits = 0;
                        // Check columns
            for (int j=0; j<9; j++)
            {
                var ch = board[i,j];
                if (ch=='.') continue;
                int bit = 1<<(ch-'0');
                if ((bits & bit) != 0) return false;
                bits |= bit;
            }
                        // Check rows
            bits = 0;
            for (int j=0; j<9; j++)
            {
                var ch = board[j,i];
                if (ch=='.') continue;
                int bit = 1<<(ch-'0');
                if ((bits & bit) != 0) return false;
                bits |= bit;
            }
                        // Check rows
            bits = 0;
            var xs = (i/3)*3;
            var ys = (i%3)*3;
            for (int j=0; j<9; j++)
            {
                var ch = board[xs+(j/3),ys+(j%3)];
                if (ch=='.') continue;
                int bit = 1<<(ch-'0');
                if ((bits & bit) != 0) return false;
                bits |= bit;
            }
        }
        return true;
    }
}
