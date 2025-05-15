// 130. Surrounded Regions   
// https://leetcode.com/problems/surrounded-regions
// Medium 18.1%
// 577.616840232314
// Submission: https://leetcode.com/submissions/detail/71346678/
// Runtime: 161 ms
// Your runtime beats 82.35 % of csharp submissions.

public class Solution {
    public void Solve(char[,] board) {
        int m=board.GetLength(0);
        int n=board.GetLength(1);
                for (int i=0; i<m; i++)
            for (int j=0; j<n; j++)
            {
                            if (board[i,j]=='O' && (i==0 || i==m-1 || j==0 || j==n-1))
                    Mark(board, i, j);
            }
        for (int i=0; i<m; i++)
            for (int j=0; j<n; j++)
                if (board[i,j]=='O')
                    board[i,j]='X';
        for (int i=0; i<m; i++)
            for (int j=0; j<n; j++)
                if (board[i,j]=='1')
                    board[i,j]='O';
    }
        void Mark(char[,] board, int i, int j)
    {
        int n = board.GetLength(1);
        var set = new Queue<int>();
        Enqueue(set, board, i, j);
        while (set.Count > 0)
        {
            var pop = set.Dequeue();
            i = pop/n;
            j = pop%n;
            Enqueue(set, board, i-1, j);
            Enqueue(set, board, i, j-1);
            Enqueue(set, board, i, j+1);
            Enqueue(set, board, i+1, j);
        }
    }
        void Enqueue(Queue<int> set, char[,] board, int i, int j)
    {
        if (i<0 || j<0 || i>=board.GetLength(0) || j>=board.GetLength(1))
            return;
        if (board[i,j] != 'O') return;
        board[i,j] = '1';
        set.Enqueue(i*board.GetLength(1) + j);
    }
    }
