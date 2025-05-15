// 240. Search a 2D Matrix II   
// https://leetcode.com/problems/search-a-2d-matrix-ii
// Medium 38.2%
// 881.493946933387
// Submission: https://leetcode.com/submissions/detail/69532692/
// Runtime: 374 ms
// Your runtime beats 28.57 % of csharp submissions.

public class Solution {
    public bool SearchMatrix2(int[,] matrix, int target) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int t = 0;
        int r = n-1;
        while (t<m && r>=0)
        {
            int cmp = target - matrix[t,r];
            if (cmp==0)
                return true;
            if (cmp < 0)
                r--;
            else
                t++;
        }
        return false;        
    }
        public bool SearchMatrix(int[,] matrix, int target)
    {
        return SearchMatrix(matrix, target, 0, matrix.GetLength(1)-1, 0, matrix.GetLength(0)-1);
    }
        public bool SearchMatrix(int[,] matrix, int target, int left, int right, int top, int bottom)
    {
        if (left>right || top>bottom)
            return false;
                int lt = left;
        int r = right;
        int t = top;
        int b = bottom;
                while (lt<=r && t<=b)
        {
            int midx = (lt + r)/2;
            int midy = (t + b)/2;
            int val = matrix[midy, midx];
            if (target < val)
            {
                r = midx-1;
                b = midy-1;
            }
            else if (target > val)
            {
                lt = midx+1;
                t = midy+1;
            }
            else 
                return true;
        }
                return SearchMatrix(matrix, target, lt,right,top,b)
            || SearchMatrix(matrix, target, left,r,t,bottom);
    }
}
