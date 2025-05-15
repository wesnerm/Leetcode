// 289. Game of Life   
// https://leetcode.com/problems/game-of-life
// Medium 36.6%
// 880.0233757624901
// Submission: https://leetcode.com/submissions/detail/69478684/
// Runtime: 237 ms
// 

using System.Threading.Tasks;
public class Solution {
    public void GameOfLife(int[,] board) {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
                Parallel.For(0, rows, i=>
        {
            int leftsum = 0;
            int sum = 0<cols ? (board[i,0]&1) + (i>0?board[i-1,0]&1:0) + (i+1<rows?board[i+1,0]&1:0) : 0;
            for (int j=0; j<cols; j++)
            {
                int rightsum = j+1<cols ? (board[i,j+1]&1) + (i>0?board[i-1,j+1]&1:0) + (i+1<rows?board[i+1,j+1]&1:0) : 0;
                                int count = leftsum + sum + rightsum;
                if (count==3 || count - board[i,j] == 3)
                    board[i,j] |= 2;
                                leftsum = sum;
                sum = rightsum;
            }
        });
                for (int i=0; i<rows; i++)
            for (int j=0; j<cols; j++)
            board[i,j] >>= 1;
    }
}
