// 583. Delete Operation for Two Strings   
// https://leetcode.com/problems/delete-operation-for-two-strings
// Medium 43.7%
// 273.2791879776226
// Submission: https://leetcode.com/submissions/detail/105458934/
// Runtime: 122 ms
// Your runtime beats 92.31 % of csharp submissions.

public class Solution {
    public int MinDistance(string word1, string word2) {
        int[,] dp = new int[word1.Length+1, word2.Length+1];
                for (int i=0; i<=word1.Length; i++)
            dp[i,0] = i;
        for (int j=0; j<=word2.Length; j++)
            dp[0,j] = j;
                for (int i=1; i<=word1.Length; i++)
            for (int j=1; j<=word2.Length; j++)
            {
                dp[i,j] = word1[i-1]==word2[j-1] ? dp[i-1,j-1] : Math.Min(dp[i-1,j]+1, dp[i,j-1]+1);
            }
                    return dp[word1.Length, word2.Length];
    }
}
