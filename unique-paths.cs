// 62. Unique Paths   
// https://leetcode.com/problems/unique-paths
// Medium 40.5%
// 795.4219825301765
// Submission: https://leetcode.com/submissions/detail/70679583/
// Runtime: 52 ms
// Your runtime beats 32.29 % of csharp submissions.

public class Solution {
    public int UniquePaths(int m, int n) {
        int top = (m-1)+(n-1);
        int bot = Math.Min(m,n)-1;
                long result = 1;
        for (int i=1; i<=bot; i++)
        {
            result = result * top / i;
            top--;
        }
                return (int)result;    
    }
}
