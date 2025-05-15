// 498. Diagonal Traverse   
// https://leetcode.com/problems/diagonal-traverse
// Medium 45.9%
// 486.6533322920962
// Submission: https://leetcode.com/submissions/detail/105460792/
// Runtime: 1078 ms
// 

public class Solution {
    public int[] FindDiagonalOrder(int[,] matrix) {
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);
        var list = new List<int>();
        for (int s=0; s<=r+c-2; s++)
        {
            int start = Math.Min(0,c-1);
            int end = Math.Min(s,c-1);
            for (int col=start; col<=end; col++)
            {
                int flipcol = s%2==0 ? col : end-(col-start);
                int row = s-flipcol;
                if (row<0 || row>=r) continue;
                list.Add(matrix[row,flipcol]);
            }
        }
        return list.ToArray();
    }
}
