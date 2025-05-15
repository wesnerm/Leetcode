// 471. Encode String with Shortest Length   
// https://leetcode.com/problems/encode-string-with-shortest-length
// Hard 41.7%
// 169.00009994204885
// Submission: https://leetcode.com/submissions/detail/111471073/
// Runtime: 199 ms
// Your runtime beats 92.86 % of csharp submissions.

public class Solution {
    public string Encode(string s) {
                var period = new int[s.Length, s.Length+1];
        for (int k=1; k<=s.Length; k++)
            for (int i=0; i+k<=s.Length; i++)
                period[i,k] = k;
                for (int k=s.Length-1; k>=1; k--)
        {
            int prev = 0;
            for (int i=0; i+k<=s.Length; i++)
            {
                int j=i+k-1;
                int curr = (i>=1 && s[j]==s[i-1]) ? prev+1 : 0;
                for (int m=2, p=curr; p>=k; m++, p-=k)
                    period[i-k*(m-1), k*m] = k;
                prev = curr;
            }
        }
                var dp = new string[s.Length, s.Length+1];
                for (int k=1; k<=s.Length; k++)
        {
            for (int i=0; i+k<=s.Length; i++)
            {
                var substr = s.Substring(i,k);
                dp[i,k] = substr;
                if (k<=4) continue;
                                int ind = period[i,k];
                if (ind == 0) ind = k;
                if (ind < substr.Length)
                {
                    var alt = (substr.Length/ind) + "[" + dp[i,ind] + "]";
                    if (alt.Length < k)
                        dp[i,k] = alt;
                }
                                for (int j=1; j<k; j++)
                {
                    if (dp[i,j].Length + dp[j,k-j].Length < dp[i,k].Length)
                        dp[i,k] = dp[i,j] + dp[i+j,k-j];
                }
            }
        }
                return dp[0,s.Length];
    }
        public string Encode2(string s)
    {
        var dp = new string[s.Length, s.Length+1];
                for (int k=1; k<=s.Length; k++)
        {
            for (int i=0; i+k<=s.Length; i++)
            {
                var substr = s.Substring(i,k);
                dp[i,k] = substr;
                if (k<=4) continue;
                                int ind = (substr + substr).IndexOf(substr, 1);
                if (ind < substr.Length)
                {
                    var alt = (substr.Length/ind) + "[" + dp[i,ind] + "]";
                    if (alt.Length < k)
                        dp[i,k] = alt;
                }
                                for (int j=1; j<k; j++)
                {
                    if (dp[i,j].Length + dp[j,k-j].Length < dp[i,k].Length)
                        dp[i,k] = dp[i,j] + dp[i+j,k-j];
                }
            }
        }
                return dp[0,s.Length];
    }
}
