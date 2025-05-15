// 562. Longest Line of Consecutive One in Matrix   
// https://leetcode.com/problems/longest-line-of-consecutive-one-in-matrix
// Medium 38.0%
// 139.2121798056421
// Submission: https://leetcode.com/submissions/detail/105459563/
// Runtime: 269 ms
// Your runtime beats 47.83 % of csharp submissions.

public class Solution {
    public int LongestLine(int[,] M) {
        int r = M.GetLength(0);
        int c = M.GetLength(1);
                var mh = (int[,]) M.Clone();
        for (int i=1; i<r; i++)
            for (int j=0; j<c; j++)
                if (mh[i,j]!=0) mh[i,j] = mh[i-1,j] + mh[i,j];
                var mv = (int[,]) M.Clone();
        for (int i=0; i<r; i++)
            for (int j=1; j<c; j++)
                if (mv[i,j]!=0) mv[i,j] = mv[i,j-1] + mv[i,j];
        var md1 = (int[,]) M.Clone();
        for (int i=1; i<r; i++)
            for (int j=1; j<c; j++)
                if (md1[i,j]!=0) md1[i,j] = md1[i-1,j-1] + md1[i,j];
        var md2 = (int[,]) M.Clone();
        for (int i=1; i<r; i++)
            for (int j=0; j<c-1; j++)
                if (md2[i,j]!=0) md2[i,j] = md2[i-1,j+1] + md2[i,j];
        int max = 0;        
        for (int i=0; i<r; i++)
            for (int j=0; j<c; j++)
            {
                if (mh[i,j] > max) max = mh[i,j];                
                if (mv[i,j] > max) max = mv[i,j];                
                if (md1[i,j] > max) max = md1[i,j];                
                if (md2[i,j] > max) max = md2[i,j];                
            }
        return max;
            }
}
