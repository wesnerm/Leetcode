// 79. Word Search   
// https://leetcode.com/problems/word-search
// Medium 26.3%
// 892.2076972331552
// Submission: https://leetcode.com/submissions/detail/71108341/
// Runtime: 168 ms
// Your runtime beats 45.59 % of csharp submissions.

public class Solution {
    int m;
    int n;
        public bool Exist(char[,] board, string word) {
        m = board.GetLength(0);
        n = board.GetLength(1);
                for (int r=0; r<m; r++)
        for (int c=0; c<n; c++)
            if (Exists(board, r,c, word, 0))
                return true;
                        return false;
    }
        bool Exists(char[,] board, int r, int c, string word, int i)
    {
        if (i>=word.Length) return true;
        if (c<0 || r <0 || c>=n || r>=m) return false;
        var ch = word[i];
        if (board[r,c] != ch) return false;
        board[r,c] = (char)(ch ^ 0x80);
        bool exists = 
            Exists(board, r-1, c, word, i+1) ||
            Exists(board, r+1, c, word, i+1) ||
            Exists(board, r, c-1, word, i+1) ||
            Exists(board, r, c+1, word, i+1);
        board[r,c] = ch;
        return exists;
    }
        }
