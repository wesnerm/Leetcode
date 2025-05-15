// 48. Rotate Image   
// https://leetcode.com/problems/rotate-image
// Medium 38.1%
// 1023.2270400898274
// Submission: https://leetcode.com/submissions/detail/70634317/
// Runtime: 160 ms
// Your runtime beats 13.51 % of csharp submissions.

public class Solution {
    public void Rotate(int[,] matrix) {
        int n = matrix.GetLength(0);
        Transpose(matrix);
        Flip(matrix);
                // Transpose=> m[y, x]
        // Flip=> m[last-x,y]
        // Rotate=> m[x,y] => m[last-y,x]
            }
        public void Flip(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i=0; i<n; i++)
        for (int j=0; j<n/2; j++)
        {
            int j2 = n-1-j;
            int tmp = matrix[i,j];
            matrix[i,j] = matrix[i,j2];
            matrix[i,j2] = tmp;
        }
    }
        public void Transpose(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i=0; i<n; i++)
        for (int j=i+1; j<n; j++)
        {
            int tmp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = tmp;
        }
            }
    }
