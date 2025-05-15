// 74. Search a 2D Matrix   
// https://leetcode.com/problems/search-a-2d-matrix
// Medium 35.2%
// 661.2714919173899
// Submission: https://leetcode.com/submissions/detail/70747223/
// Runtime: 152 ms
// Your runtime beats 60.87 % of csharp submissions.

public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int left = 0;
        int right = m*n-1;
                while (left<=right)
        {
            int mid = left + (right-left)/2;
                        int val = matrix[mid/n, mid%n];
            if (target<val)
                right = mid-1;
            else if (target>val)
                left = mid+1;
            else
                return true;
        }
                return false;        
    }
}
