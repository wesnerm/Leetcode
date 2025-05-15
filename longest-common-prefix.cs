// 14. Longest Common Prefix   
// https://leetcode.com/problems/longest-common-prefix
// Easy 31.4%
// 1424.9828315985635
// Submission: https://leetcode.com/submissions/detail/70451224/
// Runtime: 156 ms
// Your runtime beats 94.17 % of csharp submissions.

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length==0) return "";
        var prefix = strs[0];
        int length = prefix.Length;
                for (int i=1; i<strs.Length; i++)
        {
            var s = strs[i];
            int j;
            length = Math.Min(s.Length, length);
            for (j=0; j<length; j++)
                if (s[j] != prefix[j]) break;
            length = Math.Min(length, j);
        }
                return prefix.Substring(0,length);
    }
}
