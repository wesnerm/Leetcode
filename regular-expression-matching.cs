// 10. Regular Expression Matching   
// https://leetcode.com/problems/regular-expression-matching
// Hard 24.1%
// 1176.184163418485
// Submission: https://leetcode.com/submissions/detail/68034194/
// Runtime: 152 ms
// Your runtime beats 54.47 % of csharp submissions.

public class Solution {
    public bool IsMatch(string s, string p) {
        // return IsMatch(s,p,0,0);
                var g = new bool[s.Length+1,p.Length+1];
        g[0,0] = true;
                for (int i=0; i<=s.Length; i++)
        {
            for (int j=1; j<=p.Length; j++)
            {
                var pch = p[j-1];
                g[i,j] = (pch != '*')
                    ? i>0 && g[i-1,j-1] && (pch=='.' || s[i-1]==pch)
                    : j>=2 && g[i,j-2] 
                        || i>=1 && g[i-1, j] && (p[j-2]=='.' || p[j-2]==s[i-1]);
            }
        }
                return g[s.Length, p.Length];        
    }
        public bool IsMatch(string s, string p, int sindex, int pindex)
    {
        if (pindex==p.Length) return sindex==s.Length;
        var pch = p[pindex];
        bool matched = sindex<s.Length && (pch=='.' || s[sindex]==pch);
        if (pindex+1<p.Length && p[pindex+1]=='*')
        {
            while(true)
            {
                if (IsMatch(s,p,sindex,pindex+2))
                    return true;
                                matched = sindex<s.Length && (pch=='.' || s[sindex]==pch);
                if (!matched)
                    return false;
                                    sindex++;
            }
        }
        return matched && IsMatch(s,p,sindex+1,pindex+1);
   }
   }
