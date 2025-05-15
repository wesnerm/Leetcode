// 59. Spiral Matrix II   
// https://leetcode.com/problems/spiral-matrix-ii
// Medium 39.0%
// 760.2707669989584
// Submission: https://leetcode.com/submissions/detail/70517640/
// Runtime: 56 ms
// Your runtime beats 19.15 % of csharp submissions.

public class Solution {
    public int[,] GenerateMatrix(int n) {
        int [,] matrix= new int[n,n];
        int top=0;
        int left = 0;
        int right =n-1;
        int bottom = n-1;
        int i=1;
                Action<int,int,int,int,int> enumerate= (r,c,dr,dc,m) =>
        {
            if (top<=bottom && left<=right)
                while (m-- > 0)
                {
                    matrix[r,c]=i++;
                    r+=dr;
                    c+=dc;
                }
        };
                while (top<=bottom && left<=right)
        {
            enumerate(top,left,0,1,right-left+1);
            top++;
            enumerate(top,right,1,0,bottom-top+1);
            right--;
            enumerate(bottom,right,0,-1,right-left+1);
            bottom--;
            enumerate(bottom,left,-1,0,bottom-top+1);
            left++;
        }
                return matrix;
    }
    }
