// 335. Self Crossing   
// https://leetcode.com/problems/self-crossing
// Hard 24.8%
// 1048.6016140090805
// Submission: https://leetcode.com/submissions/detail/71470209/
// Runtime: 148 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
    public bool IsSelfCrossing(int[] x) {
        for (int i=3; i< x.Length; i++)
        {
            if (x[i]>=x[i-2] && x[i-3]>=x[i-1]) return true;
            if (i>=4 && x[i-1]==x[i-3] && x[i-2]-x[i]<=x[i-4]) return true;
            if (i>=5 && x[i-2]-x[i]<=x[i-4] && x[i-2]>=x[i-4] && x[i-3]-x[i-1]<=x[i-5] && x[i-3]>=x[i-1]) return true;
        }
                return false;
    }
}
