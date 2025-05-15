// 290. Word Pattern   
// https://leetcode.com/problems/word-pattern
// Easy 32.7%
// 754.6533137324225
// Submission: https://leetcode.com/submissions/detail/70753343/
// Runtime: 152 ms
// Your runtime beats 1.96 % of csharp submissions.

public class Solution {
    public bool WordPattern(string pattern, string str) {
        var dict = new Dictionary<char,string>();
        var matched = new HashSet<string>();
        var split = str.Split();
        if (split.Length != pattern.Length)
            return false;
                    for (int i=0; i<pattern.Length; i++)
        {
            var c = pattern[i];
            var s = split[i];
            if (dict.ContainsKey(c))
            {
                if (dict[c] != s)
                    return false;
            }
            else
            {
                if (matched.Contains(s))
                    return false;
                                dict[c] = s;
                matched.Add(s);
            }
        }
                return true;
    }
}
