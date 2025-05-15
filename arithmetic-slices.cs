// 413. Arithmetic Slices   
// https://leetcode.com/problems/arithmetic-slices
// Medium 54.7%
// 445.25298366346493
// Submission: https://leetcode.com/submissions/detail/102952461/
// Runtime: 125 ms
// Your runtime beats 89.13 % of csharp submissions.

public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
                int count = 0;
        int len = 0;
        int d=int.MinValue;
        for (int i=0; i+1<A.Length; i++)
        {
            int j;
            int d2 = A[i+1]-A[i];
            if (d2 != d)
            {
                len = 2;
                d = d2;
            }
            else
            {
                len++;
                if (len>=3)
                    count += len-2;
            }
        }
                return count;        
    }
}
