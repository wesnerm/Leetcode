// 159. Longest Substring with At Most Two Distinct Characters   
// https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters
// Hard 40.5%
// 466.95153411543686
// Submission: https://leetcode.com/submissions/detail/68454569/
// Runtime: 124 ms
// Your runtime beats 45.83 % of csharp submissions.

public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) 
    {
        int i=0, j=-1;
        int maxlen=0;
        int k;
        for (k=0; k<s.Length;k++)
        {
            if (k==0 || s[k]==s[k-1]) continue;
            if (j>-1 && s[k] != s[j])
            {
                maxlen =Math.Max(maxlen, k-i);
                i=j+1;
            }
            j=k-1;
        }
        return Math.Max(maxlen, k-i);
    }
}
