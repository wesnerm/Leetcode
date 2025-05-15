// 291. Word Pattern II   
// https://leetcode.com/problems/word-pattern-ii
// Hard 37.7%
// 512.4702428738791
// Submission: https://leetcode.com/submissions/detail/70755181/
// Runtime: 212 ms
// Your runtime beats 71.43 % of csharp submissions.

public class Solution {
            Dictionary<char, string> patMap = new Dictionary<char, string>();
        HashSet<string> set = new HashSet<string>();
        public bool WordPatternMatch(string pattern, string str)
        {
            return Dfs(pattern, str, 0, 0);
        }
        bool Dfs(string pattern, string str, int ipat, int istr)
        {
            if (ipat == pattern.Length || istr >= str.Length)
                return ipat == pattern.Length && istr == str.Length;
            var c = pattern[ipat];
            if (patMap.ContainsKey(c))
            {
                var s = patMap[c];
                return s.Length <= str.Length - istr
                    && String.CompareOrdinal(s, 0, str, istr, s.Length) == 0
                    && Dfs(pattern, str, ipat + 1, istr + s.Length);
            }
            for (int i = istr; i < str.Length; i++)
            {
                var newString = str.Substring(istr, i - istr + 1);
                if (set.Contains(newString))
                    continue;
                set.Add(newString);
                patMap[c] = newString;
                var result = Dfs(pattern, str, ipat + 1, istr + newString.Length);
                patMap.Remove(c);
                set.Remove(newString);
                if (result)
                    return true;
            }
            return false;
        }
}
