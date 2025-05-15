// 65. Valid Number   
// https://leetcode.com/problems/valid-number
// Hard 12.7%
// 777.9555602546226
// Submission: https://leetcode.com/submissions/detail/70567271/
// Runtime: 184 ms
// Your runtime beats 13.04 % of csharp submissions.

public class Solution {
    public bool IsNumber(string s) {
        int i = 0;
        s = s.Trim();
        bool foundDigit = false;
                if (i<s.Length && (s[i]=='-' || s[i]=='+'))
            i++;
                    if (i<s.Length && s[i]!='.')
        {
            int j = i;
            while (i<s.Length && char.IsDigit(s[i]))
                i++;
            foundDigit |= j != i;
        }
                if (i<s.Length && s[i]=='.')
        {
            i++;
            int j = i;
            while (i<s.Length && char.IsDigit(s[i]))
                i++;
            foundDigit |= j != i;
        }
        if (i<s.Length && char.ToLower(s[i])=='e')
        {
            i++;
            if (i<s.Length && s[i]=='-') i++;
            else if (i<s.Length && s[i]=='+') i++;
            if (!(i<s.Length && char.IsDigit(s[i])))
                return false;
            while (i<s.Length && char.IsDigit(s[i]))
                i++;
        }
                return foundDigit && i==s.Length;
    }
}
