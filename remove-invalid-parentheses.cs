// 301. Remove Invalid Parentheses   
// https://leetcode.com/problems/remove-invalid-parentheses
// Hard 34.9%
// 730.6121103801679
// Submission: https://leetcode.com/submissions/detail/71715509/
// Runtime: 492 ms
// Your runtime beats 87.50 % of csharp submissions.

public class Solution {
        public IList<string> RemoveInvalidParentheses(string s)
        {
            var list = new HashSet<string>();
            Dfs(MinParenRemoved(s), s, 0, s.Length - 1, x => list.Add(x));
            return list.ToList();
        }
        public int[,] MinParenRemoved(string s)
        {
            var dp = new int[s.Length + 1, s.Length + 1];
            for (int i=0; i<s.Length; i++)
                dp[i,i] = s[i] == '(' || s[i] == ')' ? 1 : 0;
            for (int len=1; len<s.Length; len++)
                for (int i = 0; i + len < s.Length; i++)
                {
                    int j = i+len;
                    char ch = s[j];
                    int min = dp[i, j - 1] + (ch=='(' || ch==')' ? 1 : 0);
                    if (ch == ')')
                    {
                        for (int k = i; k < j; k++)
                            if (s[k] == '(')
                            {
                                int lmin = i>k-1 ? 0 : dp[i, k - 1];
                                int rmin = k+1>j-1 ? 0 : dp[k + 1, j - 1];
                                if (lmin + rmin < min)
                                {
                                    min = lmin + rmin; // MinParenRemoved at most 1 smaller
                                    break;
                                }
                            }
                    }
                    dp[i,j] = min;
                }
                            return dp;
        }
        void Dfs(int[,] dp, string s, int left, int right, Action<string> action)
        {
            // Remove extraneous end characters
            while (left <= right && s[left]==')') // Optimization
                left++;
                            while (left <= right && s[right]=='(')  // Necessary
                right--;
            // We only print out well-formed strings
            if (left > right || dp[left, right] == 0)
            {
                action(s.Substring(left, right - left + 1));
                return;
            }
            if (s[right] != ')')
            {
                Dfs(dp, s, left, right - 1, str => action(str + s[right]));
                return;
            }
            int min = dp[left, right];
            if (min > dp[left, right - 1])
                Dfs(dp, s, left, right - 1, action);
            for (int i = left; i < right; i++)
            {
                var ch = s[i];
                if (ch != '(') continue;
                int lmin = left > i - 1 ? 0 : dp[left, i - 1];
                int rmin = i + 1 > right - 1 ? 0 : dp[i + 1, right - 1];
                if (lmin + rmin <= min)
                    Dfs(dp, s, left, i - 1,
                        s2 => Dfs(dp, s, i + 1, right-1,
                            s3 => action(s2 + "(" + s3 + ")")));
            }
        }    
}
