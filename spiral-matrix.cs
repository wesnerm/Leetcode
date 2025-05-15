// 54. Spiral Matrix   
// https://leetcode.com/problems/spiral-matrix
// Medium 25.5%
// 973.052742058464
// Submission: https://leetcode.com/submissions/detail/68518376/
// Runtime: 488 ms
// Your runtime beats 9.62 % of csharp submissions.

public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        var list = new List<int>();
        int top = 0;
        int left = 0;
        int right = matrix.GetLength(1)-1;
        int bottom = matrix.GetLength(0)-1;
                Action<int,int,int,int,int> enumerate= (r,c,dr,dc,n) =>
        {
            if (top<=bottom && left<=right)
                while (n-- > 0)
                {
                    list.Add(matrix[r,c]);
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
                return list;
    }
}
