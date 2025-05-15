// 311. Sparse Matrix Multiplication   
// https://leetcode.com/problems/sparse-matrix-multiplication
// Medium 50.6%
// 689.0018323432615
// Submission: https://leetcode.com/submissions/detail/71330407/
// Runtime: 288 ms
// Your runtime beats 41.46 % of csharp submissions.

public class Solution {
    public int[,] Multiply(int[,] A, int[,] B) {
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        int p = B.GetLength(1);
                var result = new int[m,p];
                for (int i=0; i<m; i++)
        for (int k = 0; k<n; k++)
            if (A[i,k] != 0)
                for (int j=0; j<p; j++)
                    result[i,j] += A[i,k] * B[k,j];
        return result;
    }
}
