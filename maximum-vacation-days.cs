// 568. Maximum Vacation Days   
// https://leetcode.com/problems/maximum-vacation-days
// Hard 40.7%
// 210.57398018892872
// Submission: https://leetcode.com/submissions/detail/111729729/
// Runtime: 203 ms
// Your runtime beats 39.51 % of java submissions.

public class Solution {
    public int maxVacationDays(int[][] flights, int[][] days) {
        int N = flights.length;
        int K = days[0].length;
        int[] dp = new int[N];
        Arrays.fill(dp, Integer.MIN_VALUE);
        dp[0] = 0;
                for (int i = 0; i < K; i++) {
            int[] temp = new int[N];
            Arrays.fill(temp, Integer.MIN_VALUE);
            for (int j = 0; j < N; j++) {
                for(int k = 0; k < N; k++) {
                    if (j == k || flights[k][j] == 1) {
                        temp[j] = Math.max(temp[j], dp[k] + days[j][i]);
                    }
                }
            }
            dp = temp;
        }
                int max = 0;
        for (int v : dp) {
            max = Math.max(max, v);
        }
                return max;
    }
}
