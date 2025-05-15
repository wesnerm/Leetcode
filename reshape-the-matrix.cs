// 566. Reshape the Matrix   
// https://leetcode.com/problems/reshape-the-matrix
// Easy 60.0%
// 300.3481655224676
// Submission: https://leetcode.com/submissions/detail/101893549/
// Runtime: 202 ms
// Your runtime beats 9.84 % of csharp submissions.

public class Solution {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        int r0 = nums.GetLength(0);
        int c0 = nums.GetLength(1);
        if (r0*c0 != r*c || r==r0) return nums;
                int[,] result = new int[r, c];
                int rr0 = 0;
        int cc0 = 0;
        for (int rr=0; rr<r; rr++)
            for (int cc=0; cc<c; cc++)
            {
                result[rr,cc] = nums[rr0,cc0++];
                if (cc0>=c0) { cc0=0; rr0++; }
            }
                    return result;
    }
}
