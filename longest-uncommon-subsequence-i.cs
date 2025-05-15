// 521. Longest Uncommon Subsequence I   
// https://leetcode.com/problems/longest-uncommon-subsequence-i
// Easy 53.6%
// 329.27035855425953
// Submission: https://leetcode.com/submissions/detail/105459737/
// Runtime: 96 ms
// Your runtime beats 97.17 % of csharp submissions.

public class Solution {
        int[] ac = new int[26];
    int[] bc = new int[26];
    string a;
    string b;
        public int FindLUSlength(string a, string b) {
        if (a.Length > b.Length)
            return a.Length;
        if (b.Length > a.Length)
            return b.Length;
        if (a == b || a.Length==0) return -1;
        return a.Length;
        /*
        foreach(var c in a) ac[c%26]++;
        foreach(var c in b) bc[c%26]++;
                for (int i=0; i<26; i++)
            if (ac[i] != bc[i])
                return a.Length;
                this.a=a;
        this.b=b;
        int lastdiff;
        for (lastdiff=a.Length-1; lastdiff>=0; lastdiff--)
        {
            if (a[lastdiff] != b[lastdiff])
                break;
        }
        if (lastdiff==0)
            return 0;
        int firstdiff = 0;
        for (firstdiff=0; i<a.Length; firstdiff++)
        {
            if (a[firstdiff] != b[firstdiff])
                break;
        }
        */
    }
    }
