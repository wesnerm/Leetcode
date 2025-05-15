// 73. Set Matrix Zeroes   
// https://leetcode.com/problems/set-matrix-zeroes
// Medium 35.7%
// 827.3337781233242
// Submission: https://leetcode.com/submissions/detail/70702113/
// Runtime: 196 ms
// Your runtime beats 22.92 % of csharp submissions.

public class Solution {
    public void SetZeroes(int[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
                bool r0 = false;
        bool c0 = false;
                for (int i=0; i<m; i++)
            if (matrix[i,0] == 0)
                r0 = true;
        for (int i=0; i<n; i++)
            if (matrix[0,i] == 0)
                c0 = true;
        for (int i=0; i<m; i++)
            for (int j=0; j<n; j++)
                if (matrix[i,j] == 0)
                    matrix[0,j] = matrix[i,0] = 0;
        for (int i=1; i<m; i++)
            for (int j=1; j<n; j++)
                if (matrix[i,0] == 0 || matrix[0,j]==0)
                    matrix[i,j] = 0;
                         if (r0)   
            for (int i=0; i<m; i++)
                matrix[i,0] = 0;
        if (c0)
            for (int i=0; i<n; i++)
                matrix[0,i] = 0;
    }
}
