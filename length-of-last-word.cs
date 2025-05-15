// 58. Length of Last Word   
// https://leetcode.com/problems/length-of-last-word
// Easy 31.6%
// 717.7186282717986
// Submission: https://leetcode.com/submissions/detail/70031695/
// Runtime: 124 ms
// Your runtime beats 21.54 % of csharp submissions.

public class Solution {
    public int LengthOfLastWord(string s) {
         int i=s.Length-1;
        while (i>=0 && s[i]==' ') i--;
        int end = i;
        while (i>=0 && s[i]!=' ') i--;
        return end-i;
    }
}
