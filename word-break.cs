// 139. Word Break   
// https://leetcode.com/problems/word-break
// Medium 29.4%
// 1163.7755590072422
// Submission: https://leetcode.com/submissions/detail/68506980/
// Runtime: 172 ms
// Your runtime beats 37.74 % of csharp submissions.

public class Solution {
    public bool WordBreak(string s, ISet<string> wordDict) {
        if (wordDict.Contains(s))
            return true;
                    bool[] f = new bool[s.Length + 1];
        f[0] = true;
                for(int i=1; i<=s.Length; i++)
        {
            for (int j=0; j<i;j++)
            {
                if (f[j] && wordDict.Contains(s.Substring(j,i-j)))
                {
                    f[i]=true;
                    break;
                }
            }
        }
                return f[s.Length];
    }
}
