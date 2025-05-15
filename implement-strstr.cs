// 28. Implement strStr()   
// https://leetcode.com/problems/implement-strstr
// Easy 27.7%
// 893.3194582998447
// Submission: https://leetcode.com/submissions/detail/73251278/
// Runtime: 102 ms
// Your runtime beats 88.41 % of csharp submissions.

public class Solution {
    public int StrStr2(string haystack, string needle) {
        int end = haystack.Length - needle.Length;
        for (int i=0; i<=end; i++)
        {
            int j=0;
            while (j<needle.Length)
            {
                if (haystack[i+j]!=needle[j])
                    break;
                j++;
            }
            if (j==needle.Length)
                return i;
        }
        return -1;
    }
        public int StrStr(string text, string pat)
    {
        if (pat.Length==0) return 0;
                int[] t = new int[pat.Length];
                for (int i=1, j=0; i<pat.Length; i++)
        {
            while (j>0 && pat[i] != pat[j])
                j = t[j-1];
            t[i] = j += pat[i]==pat[j] ? 1 : 0;
        }
                /*
        t[i] = t[i-1];
        while (t[i]>0 && pat[i] != pat[t[i]])
            t[i] = t[t[i]-1];
        t[i] += pat[i]==pat[t[i]] ? 1 : 0;
        */
                for (int i=0, j=0; i<text.Length; )
        {
            if (text[i] == pat[j])
            {
                i++;
                j++;
                if (j==pat.Length)
                    return i-pat.Length;
            }
            else if (j==0)
                i++;
            else
                j = t[j-1];
        }
                return -1;
    }
}
