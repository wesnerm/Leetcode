// 44. Wildcard Matching    
// https://leetcode.com/problems/wildcard-matching
// Hard 19.7%
// 674.3089920796015
// Submission: https://leetcode.com/submissions/detail/68038644/
// Runtime: 172 ms
// Your runtime beats 27.59 % of csharp submissions.

public class Solution {
    public bool IsMatch(string s, string p) {
        int pstar=-1;
        int sstar=0;
        int pindex=0;
        int sindex=0;
        while (sindex<s.Length)
        {
            var pch = pindex<p.Length ? p[pindex] : -1;
            if (pch=='*')
            {
                sstar = sindex;
                pstar = pindex++;
            }
            else if (sindex>=s.Length || (pch != s[sindex] && pch != '?')) 
            {
                if (pstar==-1)
                    return false;
                pindex = pstar+1;
                sindex = ++sstar;
            }
            else
            {
               sindex++;
               pindex++;
            }
        }
                while (pindex<p.Length && p[pindex]=='*')
            pindex++;
        return pindex==p.Length;
    }
        public bool IsMatch2(string s, string p) {
        var g = new bool[s.Length+1,p.Length+1];
        g[0,0] = true;
                for (int i=0; i<=s.Length; i++)
            for (int j=1; j<=p.Length; j++)
            {
                var pch = p[j-1];
                g[i,j] = (pch != '*')
                    ? i>0 && g[i-1,j-1] && (pch=='?' || s[i-1]==pch)
                    : j>0 && g[i,j-1] || i>0 && g[i-1, j];
            }
        return g[s.Length, p.Length];
    }
    public bool IsMatch(string s, string p, int sindex, int pindex)
    {
        if (pindex==p.Length) return sindex==s.Length;
        var pch = p[pindex];
        if (pch=='*')
        {
            while (pindex+1 < p.Length && p[pindex+1]=='*')
                pindex++;
                            return IsMatch(s,p,sindex,pindex+1)
                || sindex<s.Length && IsMatch(s,p,sindex+1,pindex);
        }
        return sindex<s.Length && (pch=='?' || pch==s[sindex]) && IsMatch(s,p,sindex+1, pindex+1);
   }
   }
