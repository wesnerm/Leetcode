// 186. Reverse Words in a String II   
// https://leetcode.com/problems/reverse-words-in-a-string-ii
// Medium 27.6%
// 431.40735554878995
// Submission: https://leetcode.com/submissions/detail/68948190/
// Runtime: 56 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public void ReverseWords(char[] s) {
        int end = s.Length;
        for (int i=s.Length-1; i>=-1; i--)
        {
            if (i>=0 && !char.IsWhiteSpace(s[i]))
                continue;
            int st = i+1;
            int en = end-1;
            while(st < en)
            {
                var ch = s[st];
                s[st++]=s[en];
                s[en--]=ch;
            }
            end=i;
        }
        Array.Reverse(s);        
    }
}
