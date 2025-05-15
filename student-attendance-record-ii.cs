// 552. Student Attendance Record II   
// https://leetcode.com/problems/student-attendance-record-ii
// Hard 28.7%
// 116.85979175452267
// Submission: https://leetcode.com/submissions/detail/101839455/
// Runtime: 199 ms
// Your runtime beats 40.00 % of csharp submissions.

public class Solution {
    int MOD = 1000 * 1000 * 1000 + 7;
    public int CheckRecord(int n) {
        var dp = new long[2,3];
        var dp2 = new long[2,3];
                dp[0,0] = 1;
                // Also, matrix exponentiation
        // Sparse matrix multiplication
                for (int i=0; i<n; i++)
        {
            // Add a
            dp2[0,0] = (dp[0,0] + dp[0,1] + dp[0,2]) % MOD;
            dp2[0,1] = dp[0,0]; // add L
            dp2[0,2] = dp[0,1]; // add LL
            dp2[1,0] = (dp[1,0] + dp[1,1] + dp[1,2] + dp2[0,0]) % MOD; // AP PA
            dp2[1,1] = dp[1,0]; // add L
            dp2[1,2] = dp[1,1]; // add LL
                    var tmp = dp;
            dp = dp2;
            dp2 = tmp;
        }
        long count = dp[0,0] + dp[0,1] + dp[0,2] + dp[1,0] + dp[1,1] + dp[1,2];
        return (int)(count % MOD);
    }
}
