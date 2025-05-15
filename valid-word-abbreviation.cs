// 408. Valid Word Abbreviation   
// https://leetcode.com/problems/valid-word-abbreviation
// Easy 27.7%
// 149.1154414175976
// Submission: https://leetcode.com/submissions/detail/102777560/
// Runtime: 132 ms
// Your runtime beats 12.50 % of csharp submissions.

public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        return Match(word, abbr, 0, 0);
    }
        public bool Match(string word, string abbr, int i, int j) {
        if (i>=word.Length)
            return i==word.Length && j==abbr.Length;
        while (j<abbr.Length)
        {
            if (i>=word.Length) return false;
            if (word[i] != abbr[j])
            {
                if (!(abbr[j]>'0' && abbr[j]<='9')) return false;
                                int d=0;
                while (j<abbr.Length && abbr[j]>='0' && abbr[j]<='9')
                {
                    d = d*10 + abbr[j]-'0';
                    j++;
                }
                i+=d;
                continue;
            }
            j++;
            i++;
        }
        return i == word.Length;
    }
}
