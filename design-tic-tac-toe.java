// 348. Design Tic-Tac-Toe   
// https://leetcode.com/problems/design-tic-tac-toe
// Medium 45.8%
// 417.98916375505854
// Submission: https://leetcode.com/submissions/detail/69586480/
// Runtime: 120 ms
// Your runtime beats 47.33 % of java submissions.

public class TicTacToe {
    int[] rows;
    int[] cols;
    int diagonal;
    int antiDiagonal;
    /** Initialize your data structure here. */
    public TicTacToe(int n) {
        rows = new int[n];
        cols = new int[n];
    }
        /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
    public int move(int row, int col, int player) {
        int toAdd = player == 1 ? 1 : -1;
                rows[row] += toAdd;
        cols[col] += toAdd;
                if (row==col)
            diagonal += toAdd;
                    if (col==cols.length - row - 1)
            antiDiagonal += toAdd;
                    int size =rows.length;
        if (Math.abs(rows[row]) == size ||
            Math.abs(cols[col]) == size ||
            Math.abs(diagonal) == size ||
            Math.abs(antiDiagonal) == size)
            return player;
                    return 0;
    }
}
/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.move(row,col,player);
 */
