// 651. 4 Keys Keyboard   New
// https://leetcode.com/problems/4-keys-keyboard
// Medium 43.6%
// 121.1202232388655
// Submission: https://leetcode.com/submissions/detail/111782307/
// Runtime: 65 ms
// Your runtime beats 56.67 % of csharp submissions.

public class Solution {
    public int MaxA(int N) {
        int[] dp = new int[100];
                for (int i=1; i<=N; i++)
        {
            dp[i]=i;
            for (int j=1;j<6;j++)
            {
                int tmp;
                int k = 1 + j;
                if (i-k<0) break;
                dp[i] = Math.Max(dp[i], dp[i-k] * j);
            }
        }
                return dp[N];
    }
}
