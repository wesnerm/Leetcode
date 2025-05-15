// 308. Range Sum Query 2D - Mutable    
// https://leetcode.com/problems/range-sum-query-2d-mutable
// Hard 21.8%
// 529.5879070413314
// Submission: https://leetcode.com/submissions/detail/67760988/
// Runtime: 556 ms
// Your runtime beats 57.14 % of csharp submissions.

public class NumMatrix {
    int[,] mat;
    int[,] tree;
    int rows;
    int cols;
        public NumMatrix(int[,] matrix) {
                if (matrix == null)
            matrix = new int[0,0];
                rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
        mat = new int[rows,cols];
        tree = new int[rows+1,cols+1];
        for (int r=0; r<rows; r++)
            for (int c=0; c<cols; c++)
                Update(r,c,matrix[r,c]);
    }
    public void Update(int row, int col, int val) {
        if (rows==0 && cols==0)
            return;
                    int delta = val - mat[row,col];
        mat[row,col] = val;
        for (int i=row+1; i<=rows; i+= (i&-i))
            for (int j=col+1; j<=cols; j+= (j&-j))
                tree[i,j] += delta;
            }
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return Sum(row2+1,col2+1)+Sum(row1,col1)-Sum(row1,col2+1)-Sum(row2+1, col1);
    }
        public int Sum(int row, int col)
    {
        int sum=0;
        for (int i=row; i>0; i -= i&-i)
            for (int j=col; j>0; j -= j&-j)
                sum += tree[i,j];
        return sum;
    }
}
// Your NumMatrix object will be instantiated and called as such:
// NumMatrix numMatrix = new NumMatrix(matrix);
// numMatrix.SumRegion(0, 1, 2, 3);
// numMatrix.Update(1, 1, 10);
// numMatrix.SumRegion(1, 2, 3, 4);
