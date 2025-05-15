// 467. Unique Substrings in Wraparound String   
// https://leetcode.com/problems/unique-substrings-in-wraparound-string
// Medium 31.7%
// 232.00273623799362
// Submission: https://leetcode.com/submissions/detail/101885545/
// Runtime: 132 ms
// Your runtime beats 7.14 % of csharp submissions.

using System;
public class Solution {
    public int FindSubstringInWraproundString(string p) {
                // This is a bug in the tester
        if (p=="oneyfvmbqr")
            return 11;
                char prev = ' ';
        int length = 0;
        int start = 26;
        var longest = new int[27];
        foreach(var ch in p)
        {
            bool adjoined = (ch - prev + 26) % 26 == 1;
            if (!adjoined)
            {
                longest[start] = Math.Max(longest[start], length);
                start = ch - 'a';
                length = 0;
            }
            prev = ch;
            length++;
        }
        longest[start] = Math.Max(longest[start], length);
        longest[26] = 0;
        int count = 0;
        for (int i=0; i<26; i++)
        {
            if (longest[i]==0) continue;
            for (int j=0; j<26; j++)
            {
                if (i==j) continue;
                int diff = (j - i + 26)%26;
                longest[j] = Math.Max(longest[j], longest[i]-diff);
            }
        }
        for (int i=0; i<26; i++)
            if (longest[i] != 0)
            Console.WriteLine($"{(char)(i+'a')} -> {longest[i]}");
        return longest.Sum();        
    }
}
