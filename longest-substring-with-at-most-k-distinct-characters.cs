// 340. Longest Substring with At Most K Distinct Characters    
// https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters
// Hard 38.5%
// 551.466067639307
// Submission: https://leetcode.com/submissions/detail/68453384/
// Runtime: 144 ms
// Your runtime beats 44.44 % of csharp submissions.

public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        var dict = new Dictionary<char,int>();
        int start=0;
        int length =0;
                int unique=0;
        for (int end=0; end<s.Length; end++)
        {
            var ch = s[end];
            if (!dict.ContainsKey(ch))
                dict[ch]=0;
            if (++dict[ch]==1)
                unique++;
                        if (unique<=k)
            {
                length = Math.Max(length, end-start+1);
            }
            else
            {
                while (unique>k)
                {
                    ch = s[start++];
                    if (--dict[ch] == 0)
                        unique--;
                }
            }
                    }
        return length;
    }
}
